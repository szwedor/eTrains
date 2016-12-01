using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Domain;
using DomainModel;
using DomainModel.Models;

namespace Services
{
    public class StationManagment
    {
        public IUnitOfWork u;
     
        public  StationManagment(IUnitOfWork uu)
        {
            
            u=uu;
         
        }
        public StationManagment()
        {
            u = Scope.Resolve<IUnitOfWork>();
          
            
        }
        public static ILifetimeScope Scope;
        public bool Add(string newStationText)
        {
            if (newStationText.Length == 0) return false;
            Station s=new Station();
            s.Name = newStationText;
            s.IsArchival = false;
            u.StartTransaction();
            {
               u.StationsRepository.Add(s);
               u.EndTransaction();
            }
            return true;
        }

        public List<Station> AllStations()
        {
            List<Station> s;
            
            {
                s=u.StationsRepository.Find(p => p.IsArchival == false).ToList();
              
            }
            return s;
        }

        public bool ChangeStation(Station station, string text)
        {
            if (text.Length == 0) return false;

            u.StartTransaction();
            {
                u.StationsRepository.Atached(station);
                station.Name = text;
                u.EndTransaction();
            }
            return true;
            

        }

        public bool ChangeStation(Station station, bool archivalChecked)
        {

            u.StartTransaction();
            {
                u.StationsRepository.Atached(station);
                station.IsArchival = archivalChecked;
                if (archivalChecked)
                {
                    List<ConnectionDefinition> cd =
                        u.ConnectionDefinitionRepository.Find(
                            p => p.IsArchival == false && (p.Arrival == station || p.Departure == station)).ToList();
                    foreach (var x in cd)
                    {
                        x.IsArchival = true;
                    }
                }
                u.EndTransaction();
            }
            return true;

        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Domain;
using DomainModel;
using DomainModel.Models;

namespace Services
{
    public class Reservation
    {
        public IUnitOfWork u;

        public  Reservation(IUnitOfWork uu)
        {

            u = uu;

        }
        public Reservation()
        {
            u = Scope.Resolve<IUnitOfWork>();


        }
        public static ILifetimeScope Scope;
        private User _user;
        private List<Connection> _connections;
        private DateTime _dt;

        public List<Station> DepartureStations()
        {
            return ArrivalStations();
        }
        public List<Station> ArrivalStations()
        {
               
            {
                return u.StationsRepository.Find(p => p.IsArchival == false).ToList();
            }
        }
        public List<Connection> FindConnection(Station departure, Station arrival, DateTime date)
        {

            DayOfWeek dow = date.DayOfWeek;
            _dt = date;
            DateTime dend=new DateTime(date.Year,date.Month,date.Day,23,59,59);
            
            {
                var cd = u.ConnectionDefinitionRepository.Find(p => p.IsArchival != true &&
                                                                             p.Departure.Id == departure.Id &&
                                                                             p.Arrival.Id == arrival.Id, "Departure",
                    "Arrival").Select(p => p.Id).ToList();
                _connections =
                    u.ConnectionsRepository.Find((t) => cd.Contains(t.ConnectionDefinition.Id) &&t.DepartureTime>date &&t.DepartureTime<dend).ToList();

            }
            
            return _connections;
        }
        public bool FindEmail(string email)
        {
            {
                _user = new User();
                var x = u.UsersRepository.Find(p => p.Email == email).ToList();
                if (x.Count > 0) return false;
                return true;
            }
        }
        public User FindUser(string login)
        {
            
            {
                _user = new User();
                var x = u.UsersRepository.Find(p => p.Email == login).ToList();
                if(x.Count==0)
                    { return null; }

               else  _user = u.UsersRepository.Find(p => p.Email == login).First();
            }
            return _user;
        }
        public bool ValidateUser(User passager,string pass)
        {
           
            {
                _user = passager;
                string hashpass;
                var x = u.UsersRepository.Get(passager.Id);
                using (var sha = new System.Security.Cryptography.SHA256Managed())
                {
                    byte[] textData = System.Text.Encoding.UTF8.GetBytes(pass);
                    byte[] hash = sha.ComputeHash(textData);
                    hashpass=BitConverter.ToString(hash).Replace("-", String.Empty);
                }
                if (x.PassWord==hashpass)
                {
                    return true;
                }
                return false;

            }
        }
        public int MakeReservation(Connection con)
        {
            int seat = -1;
            u.StartTransaction();
            {
                var x = u.ConnectionsRepository.Find(p=>p.Id==con.Id, "ConnectionDefinition").ToList().First();
                if (x.ConnectionDefinition.IsArchival || x.AvailableSeatNo == 0)
                {
                    
                    return seat;

                }
                else
                {

                    Ticket ticket = new Ticket();
                    ticket.Connection = x;
                    ticket.User = _user;
                    u.UsersRepository.Atached(_user);
                    u.TicketsRepository.Add(ticket);
                    ticket.Seat = ticket.Connection.AvailableSeatNo;
                    ticket.Connection.AvailableSeatNo--;
                    u.EndTransaction();
                    
                    return ticket.Connection.AvailableSeatNo;
                }

            }
        }
        public void AddUser(User a)
        {
            a.Email = a.Email.ToLower();
            _user = a;
            u.StartTransaction();
            {
                u.UsersRepository.Add(a);
                u.EndTransaction();
            }
            
        }

    }
}
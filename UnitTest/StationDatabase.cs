using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Domain;
using DomainModel;
using DomainModel.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace UnitTest
{
    [TestClass]
    public class StationDatabase

    {
        public ILifetimeScope scope;

        [TestInitialize]
        public void Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            var c = builder.Build();
            scope = c.BeginLifetimeScope();
            StationManagment.Scope = ConnectionManagment.Scope = Reservation.Scope = Services.StationLocal.Scope = scope;
        }

        [TestMethod]
        public void AddStation()
        {

            using (IUnitOfWork um = scope.Resolve<IUnitOfWork>(new NamedParameter("Changes", true)))
            {
                um.StartTransaction();

                StationManagment smManagmet = new StationManagment(um);
                smManagmet.Add("tak");
                Assert.IsNotNull(um.StationsRepository.Find(p => p.Name == "tak"));
                um.Rollback();
                um.EndTransaction();
            }
        }

        [TestMethod]
        public void AllStation()
        {

            using (IUnitOfWork u = scope.Resolve<IUnitOfWork>())
            {
                u.StartTransaction();
                StationManagment smManagmet = new StationManagment(u);
                Random m = new Random();
                List<Station> list = new List<Station>(10000);
                for (int i = 1; i < 10000; i++)
                {
                    u.StationsRepository.Add(new Station()
                    {
                        Id = i,
                        IsArchival = m.Next(5000) > 2500,
                        Name = m.Next(5000).ToString()
                    });
                }
                var x = smManagmet.AllStations();
                

                foreach (var station in x)
                {
                    Assert.IsTrue(
                        u.StationsRepository.Find(
                                p =>
                                    p.Id == station.Id && p.Name == (station.Name) &&
                                    p.IsArchival == station.IsArchival)
                            .ToList().Count == 1);

                }
                u.Rollback();
            }
        }

        [TestMethod]
        public void ModifyStation()
        {
            using (IUnitOfWork u = scope.Resolve<IUnitOfWork>())
            {
                u.StartTransaction();

                StationManagment smManagmet = new StationManagment(u);
                Random m = new Random();
                List<Station> list = new List<Station>(10000);
                List<Station> list2 = new List<Station>(10000);
                for (int i = 1; i < 10000; i++)
                {
                    var s = new Station()
                    {
                        Id = i + 5000,
                        IsArchival = m.Next(5000) > 2500,
                        Name = m.Next(5000).ToString()
                    };
                    var ss = new Station()
                    {
                        Id = i + 5000,
                        IsArchival = m.Next(5000) > 2500,
                        Name = m.Next(5000).ToString()
                    };
                    list.Add(s);
                    list2.Add(ss);
                    u.StartTransaction();
                    u.StationsRepository.Add(s);
                    u.EndTransaction();
                    smManagmet.ChangeStation(s, ss.IsArchival);
                    smManagmet.ChangeStation(s, ss.Name);
                
            }

                
                for (int i = 1; i < 10000; i++)
                    Assert.IsTrue(
                        u.StationsRepository.Find(
                                p =>
                                    p.Id == list[i - 1].Id && int.Parse(p.Name) == int.Parse(list2[i - 1].Name) &&
                                    p.IsArchival == list2[i - 1].IsArchival)
                            .ToList().Count == 1);

                u.Rollback();
              
            }
            

        }
    }
}

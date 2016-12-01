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
    public class ConnectionLocal
    {
        public ILifetimeScope scope;
        [TestInitialize]
        public void Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UnitMoq>().As<IUnitOfWork>();
            var c = builder.Build();
             scope = c.BeginLifetimeScope();
            StationManagment.Scope = ConnectionManagment.Scope = Reservation.Scope = Services.StationLocal.Scope = scope;
        }
        [TestMethod]
        public void AddConnection()
        {
            
            using (IUnitOfWork um = scope.Resolve<IUnitOfWork>())
            {
                StationManagment smManagmet=new StationManagment(um);
                smManagmet.Add("D");
                smManagmet.Add("A");
                ConnectionManagment cm=new ConnectionManagment(um);
                cm.AddNewConnection(
                    um.StationsRepository.Find(p => p.Name == "D").FirstOrDefault(),
                    um.StationsRepository.Find(p => p.Name == "A").FirstOrDefault(), 15, 13,20, "Name");


                var z = um.ConnectionDefinitionRepository.Find(
                    p => p.Name == "Name" && p.Arrival.Name == "A" && p.Departure.Name == "D" && p.Price == 20
                        && p.TravelTime.Hours == 15 && p.TravelTime.Minutes == 13 );
                
                Assert.IsTrue(z.ToList().Count == 1);
            }
        }
        
       
    }
}

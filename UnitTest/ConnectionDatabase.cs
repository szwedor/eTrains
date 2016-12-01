using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Domain;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace UnitTest
{
    [TestClass]
    class ConnectionDatabase
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
        


    }



}

using System;
using System.Windows.Forms;
using Autofac;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var builder = new ContainerBuilder();

            //builder.RegisterType<UnitOfWork>().SingleInstance().As<IUnitOfWork>(); ;
            //var c = builder.Build();
            //var scope = c.BeginLifetimeScope();
            //StationManagment.Scope = ConnectionManagment.Scope = Reservation.Scope = StationLocal.Scope = scope;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

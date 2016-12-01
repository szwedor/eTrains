using System;
using System.Activities;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Autofac;
using Domain;
using DomainModel;
using Services;

namespace AdminGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UnitOfWork>().SingleInstance().As<IUnitOfWork>(); ;
            var c = builder.Build();
            var scope = c.BeginLifetimeScope();
            StationManagment.Scope = ConnectionManagment.Scope = Reservation.Scope = StationLocal.Scope = scope;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Font DefaultFont=new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold,
                     System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static int padding = 10;
        public static Color BackColor = Color.MediumSpringGreen;
        public static Color ForeColor = Color.White;
        public static Button MakeStylishButton(Size s, Point l,string t)
        {
            return  new Button()
            {

                BackColor = BackColor,
                Font = DefaultFont,
                ForeColor = ForeColor,
                Location = l,
                Size = s,
                Text = t,
                UseVisualStyleBackColor = false
            };
        }
    }
}

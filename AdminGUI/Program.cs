using System;
using System.Drawing;
using System.Windows.Forms;
using Autofac;

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
            //var builder = new ContainerBuilder();

            //builder.RegisterType<UnitOfWork>().SingleInstance().As<IUnitOfWork>(); ;
            //var c = builder.Build();
            //var scope = c.BeginLifetimeScope();
            //StationManagment.Scope = ConnectionManagment.Scope = Reservation.Scope = StationLocal.Scope = scope;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Font DefaultFont=new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold,
                     System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static int Padding = 10;
        public static Color BackColor = Color.FromArgb(200, 200, 66);
        public static Color BackGroundColor = Color.FromArgb(90, 80, 200);
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

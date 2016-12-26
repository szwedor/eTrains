using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI.Forms
{
    public partial class AddStation : ControlTemplete
    {
        public AddStation()
        {
            InitializeComponent();
        }

        private Label _name;
        private TextBox _newStation;
        private Form1 p; 
        public AddStation(Size s, Panel returnP, Admin.AdminClient ac, Task<List<DomainModel.Models.Station>> l, Form1 LO) : base(s, returnP,ac,l)
        {
            p = LO;
            SaveButton.Text = "Dodaj";
            _name=new Label();
            _name.Location=new Point(SaveButton.Location.X-SaveButton.Width-Program.Padding,SaveButton.Location.Y+2*SaveButton.Height);
            _name.Font = Program.DefaultFont;
            _name.Size = SaveButton.Size;
            _name.Text = "Podaj nową stacje";
            Background.Controls.Add(_name);

            _newStation=new TextBox();
            _newStation.Font = Program.DefaultFont;
            _newStation.Size = SaveButton.Size;
            _newStation.Location=new Point(_name.Location.X,_name.Location.Y+_name.Size.Height);
            Background.Controls.Add(_newStation);
            SaveButton.Enabled = true;
            
        }

        Task<DomainModel.Models.Station> lol;
        protected override void SaveClick(object sender, EventArgs e)
        {
            lol = AC.AddAsync(_newStation.Text);
            ReturnButton.PerformClick();
            _name.Text = "Podaj nową stacje";
            _newStation.Text = "";
        }
       
        public void sync()
        {
            if (lol == null) return;
            lol.Wait();
            _stationList.Result.Add(lol.Result);
            lol = null;
        }

    }
}

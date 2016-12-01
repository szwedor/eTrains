using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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

        private Label Name;
        private TextBox newStation;
        public AddStation(Size s, Panel returnP) : base(s, returnP)
        {
            SaveButton.Text = "Dodaj";
            Name=new Label();
            Name.Location=new Point(SaveButton.Location.X-SaveButton.Width-Program.padding,SaveButton.Location.Y+2*SaveButton.Height);
            Name.Font = Program.DefaultFont;
            Name.Size = SaveButton.Size;
            Name.Text = "Podaj nową stacje";
            Background.Controls.Add(Name);

            newStation=new TextBox();
            newStation.Font = Program.DefaultFont;
            newStation.Size = SaveButton.Size;
            newStation.Location=new Point(Name.Location.X,Name.Location.Y+Name.Size.Height);
            Background.Controls.Add(newStation);
            SaveButton.Enabled = true;
        }

        protected override void SaveClick(object sender, EventArgs e)
        {
            
            var s = new Services.StationManagment();
            if(s.Add(newStation.Text))
            base.SaveClick(sender, e);
            returnButton.PerformClick();
            Name.Text = "Podaj nową stacje";
            newStation.Text = "";
        }
    }
}

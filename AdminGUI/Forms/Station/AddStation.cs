using System;
using System.Drawing;
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
        public AddStation(Size s, Panel returnP) : base(s, returnP)
        {
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

        protected override void SaveClick(object sender, EventArgs e)
        {
            
       //     var s = new Services.StationManagment();
       //     if(s.Add(newStation.Text))
            base.SaveClick(sender, e);
            ReturnButton.PerformClick();
            _name.Text = "Podaj nową stacje";
            _newStation.Text = "";
        }
    }
}

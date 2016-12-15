using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminGUI.Forms.Station
{
    public partial class EditStation : ControlTemplete
    {
        public EditStation()
        {
            InitializeComponent();
        }

        private Button _selectStation;
        private ListBox _listOfStations;
        private TextBox _newNameStation;
      //  private StationManagment sm;
        public EditStation(Size s, Panel returnP) : base(s, returnP)
        {
            _selectStation = Program.MakeStylishButton(SaveButton.Size,
                new Point(SaveButton.Location.X , SaveButton.Location.Y+SaveButton.Size.Height+Program.Padding),
                "Wybierz stacje");
            _selectStation.Click+=new System.EventHandler(SelectStationClick);
            Background.Controls.Add(_selectStation);
            ReturnButton.Width *= 2;
            _listOfStations=new ListBox();
            _listOfStations.Location=new Point(ReturnButton.Location.X,ReturnButton.Location.Y+ReturnButton.Height+Program.Padding);
            _listOfStations.Size=new Size(ReturnButton.Width, Background.Height-_listOfStations.Height+2*Program.Padding);
            Background.Controls.Add(_listOfStations);

            _newNameStation = new TextBox();
            _newNameStation.Font = Program.DefaultFont;
            _newNameStation.Size = SaveButton.Size;
            _newNameStation.Location = new Point(SaveButton.Location.X,_selectStation.Location.Y+_selectStation.Height+Program.Padding);
            Background.Controls.Add(_newNameStation);
        //    sm=new StationManagment();
        //    ListOfStations.DataSource = sm.AllStations();
            _listOfStations.DisplayMember = "Name";
            DoubleBuffered = true;
            this.VisibleChanged+=new EventHandler(Loading);
        }

        private void Loading(object sender, EventArgs e)
        {
            _listOfStations.Enabled = true;
            _locked = false;
            _selectStation.Text = "Wybierz stacje";
            SaveButton.Enabled = false;
            _newNameStation.Text = "";
        //    ListOfStations.DataSource = sm.AllStations();
        }

        private bool _locked = false;
        private void SelectStationClick(object sender, EventArgs e)
        {
            if(_listOfStations.SelectedItem==null) return;
            if (_locked)
            {
                _listOfStations.Enabled=true;
                _locked = false;
                _selectStation.Text = "Wybierz stacje";
                SaveButton.Enabled = false;
                _newNameStation.Text = "";
                return;
            }
            _selectStation.Text = "Wybrano stacje";
            _listOfStations.Enabled = false;
            SaveButton.Enabled = true;
            _locked = true;
            _newNameStation.Text = (_listOfStations.SelectedItem as DomainModel.Models.Station).Name;
        }

        protected override void SaveClick(object sender, EventArgs e)
        {
            _listOfStations.Enabled = true;
            _locked = false;
            _selectStation.Text = "Wybierz stacje";
        //    if (sm.ChangeStation(ListOfStations.SelectedItem as DomainModel.Models.Station, NewNameStation.Text))
            {
                _listOfStations.DisplayMember = "";
                _listOfStations.DisplayMember = "Name";
                base.SaveClick(sender, e);
            }
            
        }
    }
}

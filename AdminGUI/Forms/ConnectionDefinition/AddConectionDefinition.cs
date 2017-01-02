using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI.Forms
{
    public partial class AddConectionDefinition : ControlTemplete
    {
        public AddConectionDefinition()
        {
            InitializeComponent();
        }

       // private StationManagment sm;
        private Button _selectStationDeparture;
        private Button _selectStationArrival;
       // private List<DomainModel.Models.Station> Stations;
        private ListBox _listOfStations;
        private Button _ok;
        private DateTimePicker _hourTimePicker;
        private DateTimePicker _minutesTimePicker;
        private TextBox _priceBox;
        public AddConectionDefinition(Size s, Panel returnP, Admin.AdminClient ac,Task<List<DomainModel.Models.Station>> l) : base(s,returnP,ac,l)
        {
            
           
            SaveButton.Text = "Dodaj";
            _selectStationDeparture = Program.MakeStylishButton(new Size(Background.Width - Program.Padding * 2, SaveButton.Height), 
                new Point(Program.Padding, SaveButton.Location.Y+SaveButton.Size.Height+Program.Padding),
                "Wybierz stacje początkową");
            _selectStationDeparture.Click+=new System.EventHandler(SelectStationDepartureClick);
            Background.Controls.Add(_selectStationDeparture);

            _selectStationArrival = Program.MakeStylishButton(new Size(Background.Width-Program.Padding*2 , SaveButton.Height),
               new Point(Program.Padding, _selectStationDeparture.Location.Y + SaveButton.Size.Height + Program.Padding),
               "Wybierz stacje końcową");
            _selectStationArrival.Click += new System.EventHandler(SelectStationArrivalClick);
            Background.Controls.Add(_selectStationArrival);
            _selectStationArrival.Enabled = false;

            Label travelTime;
            travelTime = new Label();
            travelTime.Location = new Point(Program.Padding, SaveButton.Location.Y +  4*SaveButton.Height);
            travelTime.Font = Program.DefaultFont;
            travelTime.Size = SaveButton.Size;
            travelTime.Text = "Podaj długość przejazdu hh:mm";
             Background.Controls.Add(travelTime);
            _hourTimePicker=new DateTimePicker();
            _hourTimePicker.Format=DateTimePickerFormat.Custom;
            _hourTimePicker.ShowUpDown = true;
            _hourTimePicker.CustomFormat = "HH";
            _hourTimePicker.Location=new Point(travelTime.Location.X+travelTime.Size.Width,travelTime.Location.Y);
            _hourTimePicker.Font = Program.DefaultFont;
            _hourTimePicker.Size=new Size(55,20);
            Background.Controls.Add(_hourTimePicker);


            _minutesTimePicker = new DateTimePicker();
            _minutesTimePicker.Format = DateTimePickerFormat.Custom;
            _minutesTimePicker.ShowUpDown = true;
            _minutesTimePicker.CustomFormat = "mm";
            _minutesTimePicker.Location = new Point(_hourTimePicker.Location.X + _hourTimePicker.Size.Width, travelTime.Location.Y);
            _minutesTimePicker.Font = Program.DefaultFont;
            _minutesTimePicker.Size = new Size(55, 20);
            Background.Controls.Add(_minutesTimePicker);

            Label Price;
            Price = new Label();
            Price.Location = new Point(Background.Width-3*SaveButton.Width/2, SaveButton.Location.Y + 4 * SaveButton.Height);
            Price.Font = Program.DefaultFont;
            Price.Size = new Size(150, 40);
            Price.Text = "Podaj cenę";
            Background.Controls.Add(Price);

            _priceBox = new TextBox();
            _priceBox.Font = Program.DefaultFont;
            _priceBox.TextChanged += new System.EventHandler(TextChanged);
            _priceBox.Location=new Point(Price.Location.X+Price.Width,Price.Location.Y);
            _priceBox.Size = Price.Size;
            Background.Controls.Add(_priceBox);
            _ok = new Button()
            {
                Size = new Size(100, 25),
                Text = "Wybierz stacje",
                Location = new Point(Width/2 - 50, Height-30),

            };
            Controls.Add(_ok);
            _ok.Click+=new System.EventHandler(AcceptStationClick);
            _ok.Visible = false;
            ReturnButton.Width *= 2;
            _listOfStations=new ListBox();
            _listOfStations.Location = Background.Location;
            _listOfStations.Size = Background.Size;
        this.Controls.Add(_listOfStations);
         

          //   sm=new StationManagment();
      //  ListOfStations.DataSource = sm.AllStations();
            _listOfStations.DisplayMember = "Name";

            DoubleBuffered = true;
            this.VisibleChanged += new EventHandler(Loading);
        }

        private void Loading(object sender, EventArgs e)
        {
            _selectStationArrival.Text = "Wybierz stacje końcową";
                _selectStationDeparture.Text= "Wybierz stacje początkową";
            _departureStation = _arrivalStation = null;
            SaveButton.Enabled = false;
            _listOfStations.DataSource = _stationList.Result;
         _listOfStations.DisplayMember = "";
            _listOfStations.DisplayMember = "Name";
        }
        private bool _departure = false;
        private bool _arrival = false;
        private DomainModel.Models.Station _departureStation;
        private DomainModel.Models.Station _arrivalStation;
        private void AcceptStationClick(object sender, EventArgs e)
        {
            if (_listOfStations.SelectedItem == null) return;
            

            if (_departure)
            {
                if((_listOfStations.SelectedItem as DomainModel.Models.Station)==_arrivalStation)
                {
                    MessageBox.Show("Wybrano tą samą stacje jako stacje odjazdu oraz stacje przyjazdu");
                    return;
                }
                _departure = false;
                _departureStation= (_listOfStations.SelectedItem as DomainModel.Models.Station);
                _selectStationArrival.Enabled = true;
                _selectStationDeparture.Text = "Stacja początkowa: " + _departureStation.Name;
            }
            else if (_arrival)
            {
                if ((_listOfStations.SelectedItem as DomainModel.Models.Station) == _departureStation)
                {
                    MessageBox.Show("Wybrano tą samą stacje jako stacje odjazdu oraz stacje przyjazdu");
                    return;
                }
                _departure = false;
                _arrivalStation = (_listOfStations.SelectedItem as DomainModel.Models.Station);
                _selectStationArrival.Text = "Stacja końcowa: " + _arrivalStation.Name;
            }
            _ok.Visible = false;
            Background.Visible = true;
        }

        private void SelectStationArrivalClick(object sender, EventArgs e)
        {
            _arrival = true;
            Background.Visible = false;
            _ok.Visible = true;
        }

        private void SelectStationDepartureClick(object sender, EventArgs e)
        {
            _ok.Visible = true;
            _departure = true;
            Background.Visible = false;
        }

        private int _price;
        private void TextChanged(object sender, EventArgs e)
        {

           
            if (!int.TryParse(_priceBox.Text, out _price))
            {
                SaveButton.Enabled = false;
                if (_priceBox.Text.Length != 0)
                    _priceBox.Text = _priceBox.Text.Remove(_priceBox.Text.Length - 1);
            }
            else
            {
                if (_arrival != null && _departure != null)
                    SaveButton.Enabled = true;
            }

        }

        protected override void SaveClick(object sender, EventArgs e)
        {
           
           
            AC.AddNewConnection(_departureStation, _arrivalStation, _hourTimePicker.Value.Hour,
                  _minutesTimePicker.Value.Minute, _price,_departureStation.Name+" "+_arrivalStation.Name);
            {
                 base.SaveClick(sender, e);
                base.ReturnButton.PerformClick();
            }
           
        }
    }
}

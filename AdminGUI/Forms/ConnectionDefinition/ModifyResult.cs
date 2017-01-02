using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI.Forms.ConnectionDefinition
{
    public partial class ModifyResult : ControlTemplete
    { 
        public ModifyResult()
        {
            InitializeComponent();
        }

      //  private StationManagment sm;
        private Button _selectStationDeparture;
        private Button _selectStationArrival;
        private ListBox _listOfStations;
        private Button _ok;
        private DateTimePicker _hourTimePicker;
        private DateTimePicker _minutesTimePicker;
        private TextBox _priceBox;
        private DomainModel.Models.ConnectionDefinition _cd;
        private Button _removeButton;
        SearchResult ss;
        public ModifyResult(Size s, Panel returnP,DomainModel.Models.ConnectionDefinition cd, Admin.AdminClient ac, Task<List<DomainModel.Models.Station>> l,SearchResult sr) : base(s,returnP,ac,l)
        {
            InitializeComponent();
            ss = sr;
            this._cd = cd;
            _departureStation = cd.Departure;
            _arrivalStation = cd.Arrival;
        //    sm=new StationManagment();
            SaveButton.Text = "Zapisz";
        _selectStationDeparture = Program.MakeStylishButton(new Size(Background.Width - Program.Padding * 2, SaveButton.Height), 
                new Point(Program.Padding, SaveButton.Location.Y+SaveButton.Size.Height+Program.Padding),
                "Stacja początkowa: "+cd.Departure.Name);
            _selectStationDeparture.Click+=new System.EventHandler(SelectStationDepartureClick);
            Background.Controls.Add(_selectStationDeparture);

            _selectStationArrival = Program.MakeStylishButton(new Size(Background.Width-Program.Padding*2 , SaveButton.Height),
               new Point(Program.Padding, _selectStationDeparture.Location.Y + SaveButton.Size.Height + Program.Padding),
               "Stacja końcowa: "+cd.Arrival.Name);
            _selectStationArrival.Click += new System.EventHandler(SelectStationArrivalClick);
            Background.Controls.Add(_selectStationArrival);


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
            _hourTimePicker.Value = new DateTime(1970,1,1,cd.TravelTime.Hours,0,0);
            Background.Controls.Add(_hourTimePicker);


            _minutesTimePicker = new DateTimePicker();
            _minutesTimePicker.Format = DateTimePickerFormat.Custom;
            _minutesTimePicker.ShowUpDown = true;
            _minutesTimePicker.CustomFormat = "mm";
            _minutesTimePicker.Location = new Point(_hourTimePicker.Location.X + _hourTimePicker.Size.Width, travelTime.Location.Y);
            _minutesTimePicker.Font = Program.DefaultFont;
            _minutesTimePicker.Size = new Size(55, 20);
            _minutesTimePicker.Value = new DateTime(1970,1,1,0,cd.TravelTime.Minutes,0);
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
            _priceBox.Text = cd.Price.ToString();
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

            _removeButton = Program.MakeStylishButton(new Size(SaveButton.Width-Program.Padding,SaveButton.Height), 
               new Point(SaveButton.Location.X - SaveButton.Width, SaveButton.Location.Y), "Usuń");
            Background.Controls.Add(_removeButton);
            _removeButton.Click+=new System.EventHandler(RemoveClick);
            _listOfStations =new ListBox();
            _listOfStations.Location = Background.Location;
            _listOfStations.Size = Background.Size;
        this.Controls.Add(_listOfStations);

            //      sm=new StationManagment();
            _listOfStations.DataSource = l.Result;
            _listOfStations.DisplayMember = "Name";

            DoubleBuffered = true;
        }

        protected override void ReturnPanelClick(object sender, EventArgs e)
        {
            base.ReturnPanelClick(sender, e);
            ss.add(_cd);
        }
        private void RemoveClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć to połączenie?", "Usunięcie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                ss.add(null);
                AC.MakeArchival(_cd);
                base.ReturnPanelClick(sender, e);
                base.SaveClick(sender, e);
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private bool _departure = false;
        private bool _arrival = false;
        private DomainModel.Models.Station _departureStation;
        private DomainModel.Models.Station _arrivalStation;
        private void AcceptStationClick(object sender, EventArgs e)
        {
            if (_listOfStations.SelectedItem == null) return;
            Background.Visible = true;

            if (_departure)
            {
                _departure = false;
                _departureStation= (_listOfStations.SelectedItem as DomainModel.Models.Station);
                _selectStationArrival.Enabled = true;
                _selectStationDeparture.Text = "Stacja początkowa: " + _departureStation.Name;
            }
            else if (_arrival)
            {
                _departure = false;
                _arrivalStation = (_listOfStations.SelectedItem as DomainModel.Models.Station);
                _selectStationArrival.Text = "Stacja końcowa: " + _arrivalStation.Name;
            }
            _ok.Visible = false;

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
        bool b = false;
      //   ConnectionManagment m=new ConnectionManagment();
        protected override async void SaveClick(object sender, EventArgs e)
        {
            if (b) return;
            b = true;
      
            //m.ModifyConnection(cd.Id,departureStation, arrivalStation, hourTimePicker.Value.Hour,
            //    minutesTimePicker.Value.Minute, price);

         //   ss.add(_cd);
            TimeSpan ts= new TimeSpan(_hourTimePicker.Value.Hour, _minutesTimePicker.Value.Minute, 0);
            base.ReturnPanelClick(sender,e);
            base.SaveClick(sender, e);
            await AC.UpdateConnectionAsync(_cd,_departureStation,_arrivalStation,_price,ts);
          
            ss.refresh();
            this.Dispose();
        }
    }
}


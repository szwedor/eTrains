using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AdminGUI.Forms.ConnectionDefinition;
using System.Threading.Tasks;

namespace AdminGUI.Forms
{
    public partial class EditConnectionDefinition : ControlTemplete
    {
        public EditConnectionDefinition()
        {
            InitializeComponent();
        }

      //  private StationManagment sm;
        private Button _selectStationDeparture;
        private Button _selectStationArrival;
        private List<DomainModel.Models.Station> _stations;
        private ListBox _listOfStations;
        private Button _ok;
        private DateTimePicker _hourTimePicker;
        private DateTimePicker _minutesTimePicker;
        private TextBox _priceBox;
     //   private ConnectionManagment m;
        private CheckBox _arrivalCheckbox;
        private CheckBox _departureCheckbox;
        private CheckBox _priceCheckBox;
        private CheckBox _time;

        public EditConnectionDefinition(Size s, Panel returnP, Admin.AdminClient ac, Task<List<DomainModel.Models.Station>> l,SearchResult.Mode mode=SearchResult.Mode.Edit) : base(s, returnP,ac,l)
        {
            _departureCheckbox = new CheckBox()
            {
                Location = new Point(SaveButton.Location.X, SaveButton.Location.Y + SaveButton.Height),
                Size = new Size(SaveButton.Width, SaveButton.Height / 2),
                Text = "Uwzględnij stację odjazdu",
             
            };
            Background.Controls.Add(_departureCheckbox);
            _arrivalCheckbox = new CheckBox()
            {
                Location = new Point(SaveButton.Location.X, _departureCheckbox.Location.Y + _departureCheckbox.Height),
                Size = new Size(SaveButton.Width, SaveButton.Height / 2),
                Text = "Uwzględnij stację docelową"
            };
            Background.Controls.Add(_arrivalCheckbox);
            _priceCheckBox = new CheckBox()
            {
                Location = new Point(SaveButton.Location.X, _arrivalCheckbox.Location.Y + _arrivalCheckbox.Height),
                Size = new Size(SaveButton.Width, SaveButton.Height / 2),
                Text = "Uwzględnij cenę biletu"
            };
            Background.Controls.Add(_priceCheckBox);
            _time = new CheckBox()
            {
                Location = new Point(SaveButton.Location.X, _priceCheckBox.Location.Y + _priceCheckBox.Height),
                Size = new Size(SaveButton.Width, SaveButton.Height / 2),
                Text = "Uwzględnij długość przejazdu"
            };
            Background.Controls.Add(_time);
            SaveButton.Enabled = true;


          
            SaveButton.Text = "Szukaj";
            _selectStationDeparture = Program.MakeStylishButton(new Size(Background.Width - 2*Program.Padding * 2-SaveButton.Width, SaveButton.Height),
                    new Point(Program.Padding, SaveButton.Location.Y + SaveButton.Size.Height + Program.Padding),
                    "Wybierz stacje początkową");
            _selectStationDeparture.Click += new System.EventHandler(SelectStationDepartureClick);
            Background.Controls.Add(_selectStationDeparture);

            _selectStationArrival = Program.MakeStylishButton(new Size(Background.Width -2* Program.Padding * 2-SaveButton.Width, SaveButton.Height),
               new Point(Program.Padding, _selectStationDeparture.Location.Y + SaveButton.Size.Height + Program.Padding),
               "Wybierz stacje końcową");
            _selectStationArrival.Click += new System.EventHandler(SelectStationArrivalClick);
            Background.Controls.Add(_selectStationArrival);

            Label travelTime;
            travelTime = new Label();
            travelTime.Location = new Point(Program.Padding, SaveButton.Location.Y + 4 * SaveButton.Height);
            travelTime.Font = Program.DefaultFont;
            travelTime.Size = SaveButton.Size;
            travelTime.Text = "Podaj długość przejazdu hh:mm";
            Background.Controls.Add(travelTime);
            _hourTimePicker = new DateTimePicker();
            _hourTimePicker.Format = DateTimePickerFormat.Custom;
            _hourTimePicker.ShowUpDown = true;
            _hourTimePicker.CustomFormat = "HH";
            _hourTimePicker.Location = new Point(travelTime.Location.X + travelTime.Size.Width, travelTime.Location.Y);
            _hourTimePicker.Font = Program.DefaultFont;
            _hourTimePicker.Size = new Size(55, 20);
            Background.Controls.Add(_hourTimePicker);

            

            Label Price;
            Price = new Label();
            Price.Location = new Point(Background.Width - 3 * SaveButton.Width / 2, SaveButton.Location.Y + 4 * SaveButton.Height);
            Price.Font = Program.DefaultFont;
            Price.Size = new Size(150, 70);
            Price.Text = "Podaj cenę (PLN)";
            Background.Controls.Add(Price);

            _priceBox = new TextBox();
            _priceBox.Font = Program.DefaultFont;
            _priceBox.TextChanged += new System.EventHandler(TextChanged);
            _priceBox.Location = new Point(Price.Location.X + Price.Width, Price.Location.Y);
            _priceBox.Size = Price.Size;
            Background.Controls.Add(_priceBox);
            _ok = new Button()
            {
                Size = new Size(100, 25),
                Text = "Wybierz stacje",
                Location = new Point(Width / 2 - 50, Height - 30),

            };
            Controls.Add(_ok);
            _ok.Click += new System.EventHandler(AcceptStationClick);
            _ok.Visible = false;
            ReturnButton.Width *= 2;
            _listOfStations = new ListBox();
            _listOfStations.Location = Background.Location;
            _listOfStations.Size = Background.Size;
            this.Controls.Add(_listOfStations);

       //     sm = new StationManagment();
       //     ListOfStations.DataSource = sm.AllStations();
            _listOfStations.DisplayMember = "Name";

            DoubleBuffered = true;
            _searchResult=new SearchResult(Size,Background,AC,_stationList,mode);
            this.Controls.Add(_searchResult);
            this.Visible = false;
           this.VisibleChanged += new EventHandler(Loading);
    }

    private void Loading(object sender, EventArgs e)
    {
            _selectStationArrival.Text = "Wybierz stacje końcową";
            _selectStationDeparture.Text = "Wybierz stacje początkową";
            _departureStation = _arrivalStation = null;
          //  SaveButton.Enabled = false;
            //       ListOfStations.DataSource = sm.AllStations();

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
            Background.Visible = true;
           // SaveButton.Enabled = true;
            if (_departure)
            {
                _departure = false;
                _departureStation = (_listOfStations.SelectedItem as DomainModel.Models.Station);
                
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
            _ok.Visible =_listOfStations.Visible= true;
        }

        private void SelectStationDepartureClick(object sender, EventArgs e)
        {
            _ok.Visible = _listOfStations.Visible= true;
            _departure = true;
            Background.Visible = false;
        }

        private int _price;
        private void TextChanged(object sender, EventArgs e)
        {


            if (!int.TryParse(_priceBox.Text, out _price))
            {
              
                if (_priceBox.Text.Length != 0)
                    _priceBox.Text = _priceBox.Text.Remove(_priceBox.Text.Length - 1);
            }
           

        }

        private SearchResult _searchResult;
        protected override void SaveClick(object sender, EventArgs e)
        {
            
            _searchResult.NewSearch(_departureCheckbox.Checked ? _departureStation : null,
                _arrivalCheckbox.Checked ? _arrivalStation : null,
                _priceCheckBox.Checked ? _price : -1, _time.Checked ? _hourTimePicker.Value.Hour : -1);
            _searchResult.Visible = true;
            Background.Visible = false;
            _listOfStations.Visible = false;
          
            base.SaveClick(sender, e);
        }
    }
}

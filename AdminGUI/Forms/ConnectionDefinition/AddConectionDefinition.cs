using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace AdminGUI.Forms
{
    public partial class AddConectionDefinition : ControlTemplete
    {
        public AddConectionDefinition()
        {
            InitializeComponent();
        }

        private StationManagment sm;
        private Button SelectStationDeparture;
        private Button SelectStationArrival;
        private List<DomainModel.Models.Station> Stations;
        private ListBox ListOfStations;
        private Button OK;
        private DateTimePicker hourTimePicker;
        private DateTimePicker minutesTimePicker;
        private TextBox PriceBox;
        public AddConectionDefinition(Size s, Panel returnP) : base(s,returnP)
        {
            
           
            SaveButton.Text = "Dodaj";
            SelectStationDeparture = Program.MakeStylishButton(new Size(Background.Width - Program.padding * 2, SaveButton.Height), 
                new Point(Program.padding, SaveButton.Location.Y+SaveButton.Size.Height+Program.padding),
                "Wybierz stacje początkową");
            SelectStationDeparture.Click+=new System.EventHandler(SelectStationDepartureClick);
            Background.Controls.Add(SelectStationDeparture);

            SelectStationArrival = Program.MakeStylishButton(new Size(Background.Width-Program.padding*2 , SaveButton.Height),
               new Point(Program.padding, SelectStationDeparture.Location.Y + SaveButton.Size.Height + Program.padding),
               "Wybierz stacje końcową");
            SelectStationArrival.Click += new System.EventHandler(SelectStationArrivalClick);
            Background.Controls.Add(SelectStationArrival);
            SelectStationArrival.Enabled = false;

            Label TravelTime;
            TravelTime = new Label();
            TravelTime.Location = new Point(Program.padding, SaveButton.Location.Y +  4*SaveButton.Height);
            TravelTime.Font = Program.DefaultFont;
            TravelTime.Size = SaveButton.Size;
            TravelTime.Text = "Podaj długość przejazdu hh:mm";
             Background.Controls.Add(TravelTime);
            hourTimePicker=new DateTimePicker();
            hourTimePicker.Format=DateTimePickerFormat.Custom;
            hourTimePicker.ShowUpDown = true;
            hourTimePicker.CustomFormat = "HH";
            hourTimePicker.Location=new Point(TravelTime.Location.X+TravelTime.Size.Width,TravelTime.Location.Y);
            hourTimePicker.Font = Program.DefaultFont;
            hourTimePicker.Size=new Size(55,20);
            Background.Controls.Add(hourTimePicker);


            minutesTimePicker = new DateTimePicker();
            minutesTimePicker.Format = DateTimePickerFormat.Custom;
            minutesTimePicker.ShowUpDown = true;
            minutesTimePicker.CustomFormat = "mm";
            minutesTimePicker.Location = new Point(hourTimePicker.Location.X + hourTimePicker.Size.Width, TravelTime.Location.Y);
            minutesTimePicker.Font = Program.DefaultFont;
            minutesTimePicker.Size = new Size(55, 20);
            Background.Controls.Add(minutesTimePicker);

            Label Price;
            Price = new Label();
            Price.Location = new Point(Background.Width-3*SaveButton.Width/2, SaveButton.Location.Y + 4 * SaveButton.Height);
            Price.Font = Program.DefaultFont;
            Price.Size = new Size(150, 40);
            Price.Text = "Podaj cenę";
            Background.Controls.Add(Price);

            PriceBox = new TextBox();
            PriceBox.Font = Program.DefaultFont;
            PriceBox.TextChanged += new System.EventHandler(TextChanged);
            PriceBox.Location=new Point(Price.Location.X+Price.Width,Price.Location.Y);
            PriceBox.Size = Price.Size;
            Background.Controls.Add(PriceBox);
            OK = new Button()
            {
                Size = new Size(100, 25),
                Text = "Wybierz stacje",
                Location = new Point(Width/2 - 50, Height-30),

            };
            Controls.Add(OK);
            OK.Click+=new System.EventHandler(AcceptStationClick);
            OK.Visible = false;
            returnButton.Width *= 2;
            ListOfStations=new ListBox();
            ListOfStations.Location = Background.Location;
            ListOfStations.Size = Background.Size;
        this.Controls.Add(ListOfStations);
         

             sm=new StationManagment();
        ListOfStations.DataSource = sm.AllStations();
            ListOfStations.DisplayMember = "Name";

            DoubleBuffered = true;
            this.VisibleChanged += new EventHandler(Loading);
        }

        private void Loading(object sender, EventArgs e)
        {
            SelectStationArrival.Text = "Wybierz stacje końcową";
                SelectStationDeparture.Text= "Wybierz stacje początkową";
            departureStation = arrivalStation = null;
            SaveButton.Enabled = false;
            ListOfStations.DataSource = sm.AllStations();
        }
        private bool departure = false;
        private bool arrival = false;
        private DomainModel.Models.Station departureStation;
        private DomainModel.Models.Station arrivalStation;
        private void AcceptStationClick(object sender, EventArgs e)
        {
            if (ListOfStations.SelectedItem == null) return;
            Background.Visible = true;

            if (departure)
            {
                departure = false;
                departureStation= (ListOfStations.SelectedItem as DomainModel.Models.Station);
                SelectStationArrival.Enabled = true;
                SelectStationDeparture.Text = "Stacja początkowa: " + departureStation.Name;
            }
            else if (arrival)
            {
                departure = false;
                arrivalStation = (ListOfStations.SelectedItem as DomainModel.Models.Station);
                SelectStationArrival.Text = "Stacja końcowa: " + arrivalStation.Name;
            }
            OK.Visible = false;

        }

        private void SelectStationArrivalClick(object sender, EventArgs e)
        {
            arrival = true;
            Background.Visible = false;
            OK.Visible = true;
        }

        private void SelectStationDepartureClick(object sender, EventArgs e)
        {
            OK.Visible = true;
            departure = true;
            Background.Visible = false;
        }

        private int price;
        private void TextChanged(object sender, EventArgs e)
        {

           
            if (!int.TryParse(PriceBox.Text, out price))
            {
                SaveButton.Enabled = false;
                if (PriceBox.Text.Length != 0)
                    PriceBox.Text = PriceBox.Text.Remove(PriceBox.Text.Length - 1);
            }
            else
            {
                if (arrival != null && departure != null)
                    SaveButton.Enabled = true;
            }

        }

        protected override void SaveClick(object sender, EventArgs e)
        {
            ConnectionManagment m=new ConnectionManagment();
            if (m.AddNewConnection(departureStation, arrivalStation, hourTimePicker.Value.Hour,
                minutesTimePicker.Value.Minute, price,departureStation.Name+" "+arrivalStation.Name))
            {
                 base.SaveClick(sender, e);
                base.returnButton.PerformClick();
            }
           
        }
    }
}

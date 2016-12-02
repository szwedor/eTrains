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

        private Button SelectStation;
        private ListBox ListOfStations;
        private TextBox NewNameStation;
      //  private StationManagment sm;
        public EditStation(Size s, Panel returnP) : base(s, returnP)
        {
            SelectStation = Program.MakeStylishButton(SaveButton.Size,
                new Point(SaveButton.Location.X , SaveButton.Location.Y+SaveButton.Size.Height+Program.padding),
                "Wybierz stacje");
            SelectStation.Click+=new System.EventHandler(SelectStationClick);
            Background.Controls.Add(SelectStation);
            returnButton.Width *= 2;
            ListOfStations=new ListBox();
            ListOfStations.Location=new Point(returnButton.Location.X,returnButton.Location.Y+returnButton.Height+Program.padding);
            ListOfStations.Size=new Size(returnButton.Width, Background.Height-ListOfStations.Height+2*Program.padding);
            Background.Controls.Add(ListOfStations);

            NewNameStation = new TextBox();
            NewNameStation.Font = Program.DefaultFont;
            NewNameStation.Size = SaveButton.Size;
            NewNameStation.Location = new Point(SaveButton.Location.X,SelectStation.Location.Y+SelectStation.Height+Program.padding);
            Background.Controls.Add(NewNameStation);
        //    sm=new StationManagment();
        //    ListOfStations.DataSource = sm.AllStations();
            ListOfStations.DisplayMember = "Name";
            DoubleBuffered = true;
            this.VisibleChanged+=new EventHandler(Loading);
        }

        private void Loading(object sender, EventArgs e)
        {
            ListOfStations.Enabled = true;
            locked = false;
            SelectStation.Text = "Wybierz stacje";
            SaveButton.Enabled = false;
            NewNameStation.Text = "";
        //    ListOfStations.DataSource = sm.AllStations();
        }

        private bool locked = false;
        private void SelectStationClick(object sender, EventArgs e)
        {
            if(ListOfStations.SelectedItem==null) return;
            if (locked)
            {
                ListOfStations.Enabled=true;
                locked = false;
                SelectStation.Text = "Wybierz stacje";
                SaveButton.Enabled = false;
                NewNameStation.Text = "";
                return;
            }
            SelectStation.Text = "Wybrano stacje";
            ListOfStations.Enabled = false;
            SaveButton.Enabled = true;
            locked = true;
            NewNameStation.Text = (ListOfStations.SelectedItem as DomainModel.Models.Station).Name;
        }

        protected override void SaveClick(object sender, EventArgs e)
        {
            ListOfStations.Enabled = true;
            locked = false;
            SelectStation.Text = "Wybierz stacje";
        //    if (sm.ChangeStation(ListOfStations.SelectedItem as DomainModel.Models.Station, NewNameStation.Text))
            {
                ListOfStations.DisplayMember = "";
                ListOfStations.DisplayMember = "Name";
                base.SaveClick(sender, e);
            }
            
        }
    }
}

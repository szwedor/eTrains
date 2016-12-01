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

namespace AdminGUI.Forms.Station
{
    public partial class ArchiveStation : ControlTemplete
    {
        public ArchiveStation()
        {
            InitializeComponent();
        }

        private List<DomainModel.Models.Station> stationsList;
        public ArchiveStation(Size s, Panel returnP) : base(s, returnP)
        {
            SaveButton.Text = "Archiwizuj";
            
            SelectStation = Program.MakeStylishButton(SaveButton.Size,
             new Point(SaveButton.Location.X, SaveButton.Location.Y + SaveButton.Size.Height + Program.padding),
             "Wybierz stacje");
            SelectStation.Click+=new System.EventHandler(SelectStationClick);
            Background.Controls.Add(SelectStation);
            returnButton.Width *= 2;
            ListOfStations = new ListBox();
            ListOfStations.Location = new Point(returnButton.Location.X, returnButton.Location.Y + returnButton.Height + Program.padding);
            ListOfStations.Size = new Size(returnButton.Width, Background.Height - ListOfStations.Height + 2 * Program.padding);
            Background.Controls.Add(ListOfStations);

            Archival = new CheckBox();
            Archival.Checked = false;
          
            Archival.Size = SaveButton.Size;
            Archival.Text = "Stacja archiwalna";
            Archival.Font = Program.DefaultFont;
            Archival.Location = new Point(SaveButton.Location.X, SelectStation.Location.Y + SelectStation.Height + Program.padding);
            Background.Controls.Add(Archival);

            sm = new StationManagment();
            stationsList = sm.AllStations();
            ListOfStations.DataSource = stationsList;
            ListOfStations.DisplayMember = "Name";
            this.VisibleChanged += new EventHandler(Loading);
        }

        private void Loading(object sender, EventArgs e)
        {
            ListOfStations.Enabled = true;
            locked = false;
            SelectStation.Text = "Wybierz stacje";
            SaveButton.Enabled = false;
            ListOfStations.DataSource = sm.AllStations();
        }
        public CheckBox Archival;
        public ListBox ListOfStations;
        private StationManagment sm;
        public Button SelectStation;
        private bool locked = false;
        private void SelectStationClick(object sender, EventArgs e)
        {
            if (ListOfStations.SelectedItem == null) return;
            if (locked)
            {
                ListOfStations.Enabled = true;
                locked = false;
                SelectStation.Text = "Wybierz stacje";
                SaveButton.Enabled = false;
                return;
            }
           
            ListOfStations.Enabled = false;
            locked = true;
            SelectStation.Text = (ListOfStations.SelectedItem as DomainModel.Models.Station).Name;
            Archival.Checked = (ListOfStations.SelectedItem as DomainModel.Models.Station).IsArchival;
            SaveButton.Enabled = true;
        }

        protected override void SaveClick(object sender, EventArgs e)
        {
            ListOfStations.Enabled = true;
            locked = false;
            SelectStation.Text = "Wybierz stacje";
            if (sm.ChangeStation(ListOfStations.SelectedItem as DomainModel.Models.Station, Archival.Checked))
            {
                stationsList.Remove(ListOfStations.SelectedItem as DomainModel.Models.Station);
                base.SaveClick(sender, e);
                this.returnButton.PerformClick();
            }
           
        }
    }
}

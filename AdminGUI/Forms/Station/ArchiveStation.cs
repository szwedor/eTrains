using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI.Forms.Station
{
    public partial class ArchiveStation : ControlTemplete
    {
        public ArchiveStation()
        {
            InitializeComponent();
        }

        private List<DomainModel.Models.Station> _listOfStations;
        public ArchiveStation(Size s, Panel returnP, Admin.AdminClient ac, Task<List<DomainModel.Models.Station>> l) : base(s, returnP,ac,l)
        {
            SaveButton.Text = "Archiwizuj";
            
            SelectStation = Program.MakeStylishButton(SaveButton.Size,
             new Point(SaveButton.Location.X, SaveButton.Location.Y + SaveButton.Size.Height + Program.Padding),
             "Wybierz stacje");
            SelectStation.Click+=new System.EventHandler(SelectStationClick);
            Background.Controls.Add(SelectStation);
            ReturnButton.Width *= 2;
            ListOfStations = new ListBox();
            ListOfStations.Location = new Point(ReturnButton.Location.X, ReturnButton.Location.Y + ReturnButton.Height + Program.Padding);
            ListOfStations.Size = new Size(ReturnButton.Width, Background.Height - 4 * Program.Padding - ReturnButton.Height);
            Background.Controls.Add(ListOfStations);

            Archival = new CheckBox();
            Archival.Checked = false;
          
            Archival.Size = SaveButton.Size;
            Archival.Text = "Stacja archiwalna";
            Archival.Font = Program.DefaultFont;
            Archival.Location = new Point(SaveButton.Location.X, SelectStation.Location.Y + SelectStation.Height + Program.Padding);
            Background.Controls.Add(Archival);

        //    sm = new StationManagment();
      //      stationsList = sm.AllStations();=
            this.VisibleChanged += new EventHandler(Loading);
        }

        private void Loading(object sender, EventArgs e)
        {
            ListOfStations.Enabled = true;
            _locked = false;
            SelectStation.Text = "Wybierz stacje";
            SaveButton.Enabled = false;
            //       ListOfStations.DataSource = sm.AllStations();

            ListOfStations.DataSource = _stationList.Result;

            ListOfStations.DisplayMember = "";
            ListOfStations.DisplayMember = "Name";
        }
        public CheckBox Archival;
        public ListBox ListOfStations;
     //   private StationManagment sm;
        public Button SelectStation;
        private bool _locked = false;
        private void SelectStationClick(object sender, EventArgs e)
        {
            if (ListOfStations.SelectedItem == null) return;
            if (_locked)
            {
                ListOfStations.Enabled = true;
                _locked = false;
                SelectStation.Text = "Wybierz stacje";
                SaveButton.Enabled = false;
                return;
            }
           
            ListOfStations.Enabled = false;
            _locked = true;
            SelectStation.Text = (ListOfStations.SelectedItem as DomainModel.Models.Station).Name;
            Archival.Checked = (ListOfStations.SelectedItem as DomainModel.Models.Station).IsArchival;
            SaveButton.Enabled = true;
        }

        protected override void SaveClick(object sender, EventArgs e)
        {
            ListOfStations.Enabled = true;
            _locked = false;
            SelectStation.Text = "Wybierz stacje";
            if (AC.ChangeStation2(ListOfStations.SelectedItem as DomainModel.Models.Station, Archival.Checked))
            {
                _stationList.Result.Remove(ListOfStations.SelectedItem as DomainModel.Models.Station);
                base.SaveClick(sender, e);
                this.ReturnButton.PerformClick();
            }
           
        }
    }
}

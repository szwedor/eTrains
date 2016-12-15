using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdminGUI.Forms.ConnectionDefinition
{
    public partial class SearchResult : ControlTemplete
    {
        private List<DomainModel.Models.ConnectionDefinition> _l;

        public SearchResult()
        {
            InitializeComponent();
        }

        private DataGridView _result;
       
        public SearchResult(Size s, Panel returnP,Mode mode=Mode.Edit) : base(s, returnP)
        {
            InitializeComponent();

            SaveButton.Text = "Wybierz";
            _result=new DataGridView();
            _result.Size = new Size(Background.Width,Background.Height-SaveButton.Height-2*Program.Padding);
            _result.Location = new Point(0,SaveButton.Height+2*Program.Padding);
            DataGridViewColumn c1 = new DataGridViewColumn();
            c1.Name = "name";
            c1.HeaderText = "Nazwa";
            c1.CellTemplate = new DataGridViewTextBoxCell();
            
            DataGridViewColumn c2 = new DataGridViewColumn();
            c2.Name = "stationdeparture";
            c2.HeaderText = "Stacja odjazdu";
            c2.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewColumn c3 = new DataGridViewColumn();
            c3.Name = "stationArrival";
            c3.HeaderText = "Stacja przyjazdu";
            c3.CellTemplate=new DataGridViewTextBoxCell();

            DataGridViewColumn c4 = new DataGridViewColumn();
            c4.Name = "price";
            c4.HeaderText = "Cena";
            c4.CellTemplate = new DataGridViewTextBoxCell();
            DataGridViewColumn c5= new DataGridViewColumn();
            c5.Name = "TravelSpan";
            c5.HeaderText = "Czas przejazdu";
            c5.CellTemplate = new DataGridViewTextBoxCell();
            _result.Columns.Add(c1);
            _result.Columns.Add(c2);
            _result.Columns.Add(c3);
            _result.Columns.Add(c4);
            _result.Columns.Add(c5);
            _result.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            _result.AllowUserToAddRows =
                _result.AllowUserToDeleteRows = _result.AllowUserToResizeColumns = _result.AllowUserToResizeRows = false;
            _result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _result.EditMode= DataGridViewEditMode.EditProgrammatically;
            _result.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            _result.MultiSelect = false;
            //l = m.Find(departureStation, arivalStation, price, hour);
            //for (int i=0;i<l.Count;i++)
            //{
            //    result.Rows.Add(l[i].Name, l[i].Departure.Name, l[i].Arrival.Name, l[i].Price, l[i].TravelTime);
               
            //}
            SaveButton.Enabled = true;
            Background.Controls.Add(_result);
            Background.Visible = false;
            Background.VisibleChanged += new EventHandler(Loading);
            this._mode = mode;

        }

        private Mode _mode;
        public enum Mode
        {
            Edit,Remove,NewConnection
        }

       



        private void Loading(object sender, EventArgs e)
        {
            
        //    l = m.Find(departureStation, arivalStation, price, hour);
            _result.Rows.Clear();
            for (int i = 0; i < _l.Count; i++)
            {
                _result.Rows.Add(_l[i].Name, _l[i].Departure.Name, _l[i].Arrival.Name, _l[i].Price, _l[i].TravelTime);

            }
        }
        protected override void SaveClick(object sender, EventArgs e)
        {
            switch (_mode)
            {
                   case Mode.Edit:
                    ModifyResult mr = new ModifyResult(Size, Background, _l[(int)_result.SelectedRows[0].Index]);
                    this.Controls.Add(mr);
                    break;
                   
                case Mode.NewConnection:
                    AddNewConnection add=new AddNewConnection(Size, Background, _l[(int)_result.SelectedRows[0].Index]);
                    this.Controls.Add(add);
                    break;
            }
           
            Background.Visible = false;
            base.SaveClick(sender, e);
        }

       

        private DomainModel.Models.Station _arivalStation;
        private DomainModel.Models.Station _departureStation;
        private int _price;
        private int _hour;
        //ConnectionManagment m = new ConnectionManagment();
        public void NewSearch(DomainModel.Models.Station departure, DomainModel.Models.Station arrival, int price, int hour)
        {
          
            _departureStation = departure;
            _arivalStation = arrival;
            this._price = price;
            this._hour = hour;
        //    l = m.Find(departureStation, arivalStation, price, hour);
            Background.Visible = true;
        }
    }
}

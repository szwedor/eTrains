using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DomainModel.Models;
using Services;

namespace AdminGUI.Forms.ConnectionDefinition
{
    public partial class SearchResult : ControlTemplete
    {
        private List<DomainModel.Models.ConnectionDefinition> l;

        public SearchResult()
        {
            InitializeComponent();
        }

        private DataGridView result;
       
        public SearchResult(Size s, Panel returnP,Mode mode=Mode.Edit) : base(s, returnP)
        {
            InitializeComponent();

            SaveButton.Text = "Wybierz";
            result=new DataGridView();
            result.Size = new Size(Background.Width,Background.Height-SaveButton.Height-2*Program.padding);
            result.Location = new Point(0,SaveButton.Height+2*Program.padding);
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
            result.Columns.Add(c1);
            result.Columns.Add(c2);
            result.Columns.Add(c3);
            result.Columns.Add(c4);
            result.Columns.Add(c5);
            result.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            result.AllowUserToAddRows =
                result.AllowUserToDeleteRows = result.AllowUserToResizeColumns = result.AllowUserToResizeRows = false;
            result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            result.EditMode= DataGridViewEditMode.EditProgrammatically;
            result.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            result.MultiSelect = false;
            //l = m.Find(departureStation, arivalStation, price, hour);
            //for (int i=0;i<l.Count;i++)
            //{
            //    result.Rows.Add(l[i].Name, l[i].Departure.Name, l[i].Arrival.Name, l[i].Price, l[i].TravelTime);
               
            //}
            SaveButton.Enabled = true;
            Background.Controls.Add(result);
            Background.Visible = false;
            Background.VisibleChanged += new EventHandler(Loading);
            this.mode = mode;

        }

        private Mode mode;
        public enum Mode
        {
            Edit,Remove,NewConnection
        }

       



        private void Loading(object sender, EventArgs e)
        {
            
            l = m.Find(departureStation, arivalStation, price, hour);
            result.Rows.Clear();
            for (int i = 0; i < l.Count; i++)
            {
                result.Rows.Add(l[i].Name, l[i].Departure.Name, l[i].Arrival.Name, l[i].Price, l[i].TravelTime);

            }
        }
        protected override void SaveClick(object sender, EventArgs e)
        {
            switch (mode)
            {
                   case Mode.Edit:
                    ModifyResult mr = new ModifyResult(Size, Background, l[(int)result.SelectedRows[0].Index]);
                    this.Controls.Add(mr);
                    break;
                   
                case Mode.NewConnection:
                    AddNewConnection add=new AddNewConnection(Size, Background, l[(int)result.SelectedRows[0].Index]);
                    this.Controls.Add(add);
                    break;
            }
           
            Background.Visible = false;
            base.SaveClick(sender, e);
        }

       

        private DomainModel.Models.Station arivalStation;
        private DomainModel.Models.Station departureStation;
        private int price;
        private int hour;
        ConnectionManagment m = new ConnectionManagment();
        public void NewSearch(DomainModel.Models.Station Departure, DomainModel.Models.Station Arrival, int price, int hour)
        {
          
            departureStation = Departure;
            arivalStation = Arrival;
            this.price = price;
            this.hour = hour;
            l = m.Find(departureStation, arivalStation, price, hour);
            Background.Visible = true;
        }
    }
}

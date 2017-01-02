using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using DomainModel.Models;
using GUI.ServiceReference2;
using System.Globalization;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GUI
{
    public partial class Form1 : Form
    {
        public User newUser = new User();
        public DateTime dt=new DateTime();
        //  public Reservation r;
        public ImageList IlLarge = new ImageList();
        public ImageList IlSmall = new ImageList();
        ReservationManagmentClient reservationManagment=new ReservationManagmentClient();
        ReservationManagmentUnsecureClient reservationManagmentUnsecureClient=new ReservationManagmentUnsecureClient();
        List<List<Connection>> myconnections = new List<List<Connection>>();
        UserAccount ua;
        public List<Connection> choosedCon;
        public List<Connection> connectiontodetails;

        public bool log = false;
        public Form1()
        {
            if (Debugger.IsAttached)
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            ua = new UserAccount(this);
            try
            {
                XmlReader reader = XmlReader.Create("http://wiadomosci.wp.pl/ver,rss,rss.xml");
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                StringBuilder ss = new StringBuilder();
                foreach (SyndicationItem item in feed.Items)
                {

                    ss.Append("<div style=\"background-color:#008080;color:#FFFFFF;font-family:Century Gothic\">");
                    ss.Append("<h3>");
                    ss.AppendLine(item.Title.Text);
                    ss.Append("</h3>");
                    ss.Append("<p  >");
                    ss.AppendLine(item.Summary.Text);
                    ss.Append("</p>");
                    ss.Append("</div>");
                    ss.AppendLine();
                }
                webBrowser1.DocumentText = ss.ToString();


            }
            catch (System.Net.WebException)
            {
                webBrowser1.DocumentText = "<h1 style=\"color:red\"> Brak połączenia z Internetem</h1>";
            }
            dateTimePicker.MinDate=DateTime.Today;


            //    r=new Reservation();
            //    listBoxFrom.DataSource= r.DepartureStations();
            listBoxTo.DataSource = reservationManagmentUnsecureClient.AllStations();
            listBoxTo.DisplayMember = "Name";
            listBoxFrom.DataSource = reservationManagmentUnsecureClient.AllStations();
            listBoxFrom.DisplayMember = "Name";
            DoubleBuffered = true;
            
        }
        private void FROM_Click(object sender, EventArgs e)
        {
            listBoxFrom.Visible = !listBoxFrom.Visible;
        }
        private void listBoxFrom_MouseDown(object sender, MouseEventArgs e)
        {
            FROM.Text = "Z: "+listBoxFrom.Text;
            listBoxFrom.Visible = false;
        }
        private void TO_Click(object sender, EventArgs e)
        {
            listBoxTo.Visible = !listBoxTo.Visible;
        }
        private void listBoxTo_MouseDown(object sender, MouseEventArgs e)
        {
            TO.Text = "Do: " + listBoxTo.Text;
            listBoxTo.Visible = false;
        }
        private async void Find_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            webBrowser1.Visible = true;
            dt = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day,
             hoursTimePicker.Value.Hour, MinutesTimePicer.Value.Minute, 0);
            
            SearchPanel.Visible = false;
            Error.Visible = false;
            myconnections = null;


            //myconnections = reservationManagmentUnsecureClient.FindConnection(listBoxFrom.SelectedItem as Station, listBoxTo.SelectedItem as Station, dt);

            myconnections= await reservationManagmentUnsecureClient.FindConnectionAsync(listBoxFrom.SelectedItem as Station, listBoxTo.SelectedItem as Station, dt);
            
            if (myconnections ==null || myconnections.Count == 0)
            {
                MessageBox.Show("Nie mamy dostępnych przejazdów w wybranym terminie");
            }
            else
            {
                RezervationButton.Visible = true;
                webBrowser1.Visible = false;
                pictureBox3.Visible = false;
                SearchPanel.Location = new Point(502, 106);
                SearchPanel.Visible = true;
                dataGridView1.Rows.Clear();
                int i = 0;
                foreach (var elem in myconnections)
                {

                    var x = new DataGridViewRow();
                    x.Tag = elem;
                    dataGridView1.Rows.Add(x);
                    dataGridView1.Rows[i].Cells[0].Value = elem.Last().ConnectionDefinition.Departure.Name;
                    dataGridView1.Rows[i].Cells[1].Value = elem.First().ConnectionDefinition.Arrival.Name;
                    dataGridView1.Rows[i].Cells[2].Value = elem.Last().DepartureTime;
                    int h = 0;
                    int m = 0;
                    int s = 0;
                    int totalPrice = 0;
                    foreach (var con in elem)
                    {
                        //h += con.ConnectionDefinition.TravelTime.Hours;
                        //m += con.ConnectionDefinition.TravelTime.Minutes;
                        //s += con.ConnectionDefinition.TravelTime.Seconds;

                        totalPrice += con.ConnectionDefinition.Price;
                    }


                    TimeSpan totalTime = elem.First().ArrivalTime - elem.Last().DepartureTime;
                    totalTime=new TimeSpan(totalTime.Hours,totalTime.Minutes,totalTime.Seconds);
                    dataGridView1.Rows[i].Cells[3].Value = totalTime;
                    dataGridView1.Rows[i].Cells[5].Value = totalPrice;
                    dataGridView1.Rows[i].Cells[4].Value = elem.Count() - 1;
                    i++;
                }
                
            }
        }
        private void RezervationButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Najpierw wybierz połączenie");
                return;
            }
            dt = (dataGridView1.SelectedRows[0].Tag as List<Connection>).First().DepartureTime;
            if (dt < DateTime.Now)
            {
                MessageBox.Show("Pociąg już odjechał");
                return;
            }
            choosedCon = dataGridView1.SelectedRows[0].Tag as List<Connection>;
            if (!log)
            {
                ua = new UserAccount(this);
            }
            else
            {
                ua.ReservationView(choosedCon);
            }

            this.Hide();
            ua.Show();
        }
        FormToDetails ftd;
        private void ConnectionDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Najpierw wybierz połączenie");
                return;
            }
            connectiontodetails = dataGridView1.SelectedRows[0].Tag as List<Connection>;
           ftd= new FormToDetails(this);
            ftd.Show();
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ftd != null) ftd.Dispose();
        }
        private void UserAccount_Click(object sender, EventArgs e)
        {
            if (!log)
            {
                ua = new UserAccount(this);
            }
            this.Hide();
            ua.Show();
        }
    }
}

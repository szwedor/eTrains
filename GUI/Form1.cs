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

namespace GUI
{
    public partial class Form1 : Form
    {
        
        public User newUser = new User();
        public DateTime dt=new DateTime();
<<<<<<< HEAD
        //  public Reservation r;
        public ImageList IlLarge = new ImageList();
        public ImageList IlSmall = new ImageList();
        ReservationManagmentClient reservationManagment=new ReservationManagmentClient();
        ReservationManagmentUnsecureClient reservationManagmentUnsecureClient=new ReservationManagmentUnsecureClient();
        List<List<Connection>> myconnections = new List<List<Connection>>();
        UserAccount ua;
        public List<Connection> choosedCon;

=======
        public ImageList ilLarge = new ImageList();
        public ImageList ilSmall = new ImageList();
        ReservationManagmentClient reservationManagment=new ReservationManagmentClient();
        ReservationManagmentUnsecureClient reservationManagmentUnsecureClient=new ReservationManagmentUnsecureClient();
        List<Connection> myconnections = new List<Connection>();
        UserAccount ua;
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
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
       
      
        private void Find_Click(object sender, EventArgs e)
        {
            dt = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day,
             hoursTimePicker.Value.Hour, MinutesTimePicer.Value.Minute, 0);

            Gratulation.Visible = false;
            SearchPanel.Visible = false;
            Error.Visible = false;
            myconnections = null;
<<<<<<< HEAD


             myconnections = reservationManagmentUnsecureClient.FindConnection(listBoxFrom.SelectedItem as Station, listBoxTo.SelectedItem as Station, dt);


=======

             myconnections = reservationManagmentUnsecureClient.FindConnection(listBoxFrom.SelectedItem as Station, listBoxTo.SelectedItem as Station, dt);

          //  myconnections = reservationManagmentUnsecureClient.F(listBoxFrom.SelectedItem as Station, listBoxTo.SelectedItem as Station, -1, dt.Hour).ToList();
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
            if (myconnections.Count == 0)
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
<<<<<<< HEAD


                for (int i = 0; i < myconnections.Count; i++)
                {
                    var x = new DataGridViewRow();
                    x.Tag = myconnections[i];
                    dataGridView1.Rows.Add(x);
                    dataGridView1.Rows[i].Cells[0].Value = myconnections[i].First().ConnectionDefinition.Departure.Name;
                    dataGridView1.Rows[i].Cells[1].Value = myconnections[i].Last().ConnectionDefinition.Arrival.Name;


                    int h = 0;
                    int m = 0;
                    int s = 0;
                    int totalPrice = 0;
                    foreach (var elem in myconnections)
                    {
                        for (int j = 0; j < elem.Count; j++)
                        {
                            h += elem[j].ConnectionDefinition.TravelTime.Hours;
                            m += elem[j].ConnectionDefinition.TravelTime.Minutes;
                            s += elem[j].ConnectionDefinition.TravelTime.Seconds;
=======
               
                
                    for(int i=0;i<myconnections.Count;i++)
                    {
                        var x = new DataGridViewRow();
                        x.Tag = myconnections[i];
                        dataGridView1.Rows.Add(x);
                        dataGridView1.Rows[i].Cells[0].Value = myconnections[i].ConnectionDefinition.Departure.Name;
                        dataGridView1.Rows[i].Cells[1].Value = myconnections[i].ConnectionDefinition.Arrival.Name;
                        dataGridView1.Rows[i].Cells[2].Value = myconnections[i].DepartureTime;
                        dataGridView1.Rows[i].Cells[3].Value = myconnections[i].ConnectionDefinition.Price;
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713

                            totalPrice += elem[j].ConnectionDefinition.Price;
                        }
                    }
                    TimeSpan totalTime = new TimeSpan(h, m, s);
                    dataGridView1.Rows[i].Cells[2].Value = myconnections[i].First().DepartureTime;
                    dataGridView1.Rows[i].Cells[3].Value = totalTime;
                    dataGridView1.Rows[i].Cells[5].Value = totalPrice;
                    dataGridView1.Rows[i].Cells[4].Value = myconnections.Count() - 1;
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
<<<<<<< HEAD
            dt = (dataGridView1.SelectedRows[0].Tag as List<Connection>).First().DepartureTime;
            if (dt < DateTime.Now)
            {
                MessageBox.Show("Pociąg już odjechał");
                return;
            }
            choosedCon = dataGridView1.SelectedRows[0].Tag as List<Connection>;
            if (!log)
=======
            Gratulation.Visible = false;
            if ( log== false)
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
            {
                ua = new UserAccount(this);
            }
            else
            {
<<<<<<< HEAD
                ua.ReservationView(choosedCon);
=======
                dt = (dataGridView1.SelectedRows[0].Tag as Connection).DepartureTime;
                if (dt < DateTime.Now)
                {
                    MessageBox.Show("Pociąg już odjechał" );
                    return;


                }
                
                int seat;
                
              //  if (-1==(seat=r.MakeReservation(dataGridView1.SelectedRows[0].Tag as Connection)))
                {
                    Gratulation.Text = "Niestety wszystkie miejsca zostały już zajęte";
                    Gratulation.BackColor = Color.MistyRose;
                    
                }
               // else
                {

                 //   string place = seat.ToString();
                    StringBuilder str = new StringBuilder();
                    str.Append("Udało Ci się zarezerwować bilet. Twój numer miejsca to:  ");
                    str.Append(Environment.NewLine);
                //    str.Append(place.ToString());
                
                    Gratulation.Text = str.ToString();
                
                }
             //   RezervationButton.Visible = false;
                Gratulation.Visible = true;
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
            }

            this.Hide();
            ua.Show();
        }
        private void ConnectionDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Najpierw wybierz połączenie");
                return;
            }
            //dataGridView1.SelectedRows[0].Tag as Connection
<<<<<<< HEAD
            ConnectionDefinitionWindow  connectionDefinitionWindow = new ConnectionDefinitionWindow(ua);
            connectionDefinitionWindow.Show();
=======
            Form ConnectionDefinitionWindow = new ConnectionDefinitionWindow();
            ConnectionDefinitionWindow.Show();
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
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

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
using GUI.StationService;
using GUI.ConnectionService;


namespace GUI
{
    public partial class Form1 : Form
    {
        
        public User newUser = new User();
        public DateTime dt=new DateTime();
        Button myaccount = new Button();
        //  public Reservation r;
        public ImageList ilLarge = new ImageList();
        public ImageList ilSmall = new ImageList();
        StationManagmentClient StationClient = new StationManagmentClient();
        ConnectionManagmentClient ConnectionClient = new ConnectionManagmentClient();
        List<ConnectionDefinition> myconnections = new List<ConnectionDefinition>();
        UserAccount ua = new UserAccount();
        public Form1()
        {
            
            InitializeComponent();

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

            listBoxTo.DataSource = StationClient.AllStations();
            listBoxTo.DisplayMember = "Name";
            listBoxFrom.DataSource = StationClient.AllStations();
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
         
            //newli.Location = SearchListView.Location;
            //newli.Size = SearchListView.Size;
            //SearchListView = new ListView();
            //SearchListView = newli;

            Gratulation.Visible = false;
            SearchPanel.Visible = false;
            Error.Visible = false;
            myconnections = null;

            //  myconnections = r.FindConnection(listBoxFrom.SelectedItem as Station, listBoxTo.SelectedItem as Station, dt);

            myconnections = ConnectionClient.Find(listBoxFrom.SelectedItem as Station, listBoxTo.SelectedItem as Station, -1, dt.Hour).ToList();
            if (myconnections.Count == 0)
            {
                webBrowser1.Visible = false;
                StringBuilder mystb = new StringBuilder();
                mystb.Append("Przepraszamy,");
                mystb.Append(Environment.NewLine);
                mystb.Append("nie mamy dostępnych połączeń w wybranym terminie :(");
                Error.Text = mystb.ToString();
                Error.ForeColor = Color.Red;
                Error.Visible = true;
            }
            else
            {
                RezervationButton.Visible = true;
                webBrowser1.Visible = false;
                pictureBox3.Visible = false;
                SearchPanel.Location = new Point(502, 106);
                SearchPanel.Visible = true;
                dataGridView1.Rows.Clear();
               
                
                    for(int i=0;i<myconnections.Count;i++)
                    {
                        var x = new DataGridViewRow();
                        x.Tag = myconnections[i];
                        dataGridView1.Rows.Add(x);
                        dataGridView1.Rows[i].Cells[0].Value = myconnections[i].Departure.Name;
                        dataGridView1.Rows[i].Cells[1].Value = myconnections[i].Arrival.Name;
                        dataGridView1.Rows[i].Cells[2].Value = myconnections[i].TravelTime;
                        dataGridView1.Rows[i].Cells[3].Value = myconnections[i].Price;

                    }
                
            }
        }
        private void RezervationButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("Najpierw wybierz połączenie");
                return;
            }
            Gratulation.Visible = false;
            if ( ua.log== false)
            {
                Gratulation.Text = "Aby zarezerwowac bilet musisz być zalogowany !";
                Gratulation.BackColor = Color.MistyRose;
            }
            else
            {
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
            }
            Gratulation.Visible = true;
        }
        private void ConnectionDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Najpierw wybierz połączenie");
                return;
            }
            //dataGridView1.SelectedRows[0].Tag as Connection
            Form ConnectionDefinitionWindow = new ConnectionDefinitionWindow();
            ConnectionDefinitionWindow.Show();
        }
        private void myaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            //UserAccount ua = new UserAccount();
            ua.Show();
        }
    }
}

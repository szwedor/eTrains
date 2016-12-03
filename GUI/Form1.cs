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
      //  public Reservation r;
        public ImageList ilLarge = new ImageList();
        public ImageList ilSmall = new ImageList();
        StationManagmentClient StationClient = new StationManagmentClient();
        ConnectionManagmentClient ConnectionClient = new ConnectionManagmentClient();
        List<ConnectionDefinition> myconnections = new List<ConnectionDefinition>();

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
            boxPass.PasswordChar = '*';
           
        //    r=new Reservation();
            listBoxTo.DataSource = StationClient.AllStations();
            listBoxTo.DisplayMember = "Name";
            //    listBoxFrom.DataSource= r.DepartureStations();
            listBoxFrom.DataSource = StationClient.AllStations();
                listBoxFrom.DisplayMember = "Name";
            DoubleBuffered = true;
            textBox3.PasswordChar = '*';
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
       
        private void LogIn_Click(object sender, EventArgs e)
        {
            textValidation.Visible = false;
        //    newUser = r.FindUser(boxLogin.Text.ToString());
            if (newUser == null)
            {
                textValidation.Visible = true;
                return;
            }
         //   if (r.ValidateUser(newUser,boxPass.Text.ToString()))
            {
                textLogin.Visible = false;
                boxLogin.Visible = false;
                textPass.Visible = false;
                boxPass.Visible = false;
                LogIn.Visible = false;
                Rejestration.Visible = false;
                textRejestr.Visible = false;
                pictureBox1.Visible = false;
                TextBox welcome = new TextBox();
                welcome.BackColor = Color.Teal;
                welcome.Text = "Witaj  " + boxLogin.Text.ToString();
                welcome.ForeColor = Color.White;
                welcome.Font = new Font("Century Gothic", 14);
                welcome.Location = new Point(502, 12);
                welcome.Size = new Size(478, 70);
                welcome.TextAlign = HorizontalAlignment.Center;
                welcome.ReadOnly = true;
                
                this.Controls.AddRange(new Control[] { welcome });
            }
        //    else
            {
        //        textValidation.Visible = true;
            }
        }

        private void Rejestration_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = false;
            pictureBox3.Visible = false;
            webBrowser1.Visible = false;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button1.Visible = true;          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = true;
            pictureBox3.Visible = true;
            webBrowser1.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;


            textLogin.Visible = false;
            boxLogin.Visible = false;
            textPass.Visible = false;
            boxPass.Visible = false;
            LogIn.Visible = false;
            Rejestration.Visible = false;
            textRejestr.Visible = false;
            pictureBox1.Visible = false;
            TextBox welcome = new TextBox();
            welcome.BackColor = Color.Teal;
            string name = textBox1.Text.ToString();
            if(textBox5.Text.Any(x => char.IsLetter(x)))
                {
                    MessageBox.Show("Zły format tefonu! ");
                SearchPanel.Visible = false;
                pictureBox3.Visible = false;
                webBrowser1.Visible = false;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                button1.Visible = true;
            }
            else if (!emailIsValid(textBox2.Text.ToString()) || textBox2.Text.Length==0)
            {
                MessageBox.Show("Zły format mail! ");
                SearchPanel.Visible = false;
                pictureBox3.Visible = false;
                webBrowser1.Visible = false;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                button1.Visible = true;
            }
            else if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Brak hasła! ");
                SearchPanel.Visible = false;
                pictureBox3.Visible = false;
                webBrowser1.Visible = false;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                button1.Visible = true;
            }
           // else if(!r.FindEmail(textBox2.Text.ToString()))
            {
                MessageBox.Show("Podany mail już istnieje ");
                SearchPanel.Visible = false;
                pictureBox3.Visible = false;
                webBrowser1.Visible = false;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                button1.Visible = true;
            }
           // else
            {
                welcome.Text = "Witaj  " + name;
                welcome.ForeColor = Color.White;
                welcome.Font = new Font("Century Gothic", 24);
                welcome.Location = new Point(502, 12);
                welcome.Size = new Size(478, 70);
                welcome.Multiline = true;
                welcome.TextAlign = HorizontalAlignment.Center;
                welcome.ReadOnly = true;
                this.Controls.AddRange(new Control[] { welcome });


                newUser = new User();
                newUser.FirstName = textBox1.Text.ToString();
                newUser.LastName = textBox4.Text.ToString();
                string hashpass;
                using (var sha = new System.Security.Cryptography.SHA256Managed())
                {
                    byte[] textData = System.Text.Encoding.UTF8.GetBytes(textBox3.Text.ToString());
                    byte[] hash = sha.ComputeHash(textData);
                    hashpass = BitConverter.ToString(hash).Replace("-", String.Empty);
                }
                newUser.PassWord = hashpass;
                newUser.Email = textBox2.Text.ToString();
                newUser.PhoneNo = textBox5.Text.ToString();
            //    r.AddUser(newUser);
            }

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
            if (LogIn.Visible == true)
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
        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

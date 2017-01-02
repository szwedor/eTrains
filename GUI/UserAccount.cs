using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.ServiceReference1;
using System.IdentityModel.Selectors;
using DomainModel.Models;
using GUI.ServiceReference2;

namespace GUI
{
    public partial class UserAccount : Form
    {
        public Form1 oldform;
        public string loginUser;
        UserManagmentClient userManagment = new UserManagmentClient();
        public ReservationManagmentClient reservationManagment = new ReservationManagmentClient();
        public List<Connection> choosedtodetails;
        public List<Ticket> listofticekets=new List<Ticket>();
        public bool todelete = false;
        public UserAccount(Form1 f)
        {

            InitializeComponent();
            oldform = f;
            if (oldform.log)
            {
                LoginPanel.Visible = false;
                MyticketsPanel.Visible = true;
                ButtonsPanel.Visible = true;
            }
            if (!oldform.log)
            {

                LoginPanel.Visible = true;
                ButtonsPanel.Visible = false;
                MyticketsPanel.Visible = false;
                RejestrationPanel.Visible = false;
                PassPanel.Visible = false;
            }
            boxPass.PasswordChar = '*';
            textBox3.PasswordChar = '*';

        }

        private void Mytickets_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            MyticketsPanel.Location = new Point(240, 188);
            MyticketsPanel.Visible = true;
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            MyticketsPanel.Visible = false;
            PassPanel.Location = new Point(240, 188);
            PassPanel.Visible = true;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldform.Show();
        }

        private async void LogIn_Click(object sender, EventArgs e)
        {
            textValidation.Visible = false;
            if (boxLogin.Text.Length == 0)
            {
                MessageBox.Show("Brak loginu! ");
                return;
            }
            if (boxPass.Text.Length == 0)
            {
                MessageBox.Show("Brak hasła! ");
                return;
            }

            try
            {
                userManagment = new UserManagmentClient();
                userManagment.ClientCredentials.UserName.UserName = boxLogin.Text.ToString();
                userManagment.ClientCredentials.UserName.Password = boxPass.Text.ToString();

                userManagment.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                System.ServiceModel.Security.X509CertificateValidationMode.None;

                //userManagment.Login();
                await userManagment.LoginAsync();
            }
            catch (Exception ex)
            {
                textValidation.Visible = true;
                oldform.log = false;
                return;
            }

            LoginPanel.Visible = false;
            MyticketsPanel.Location = new Point(240, 188);
            MyticketsPanel.Visible = true;
            ButtonsPanel.Visible = true;
            oldform.log = true;
            loginUser = boxLogin.Text.ToString();
            TicketsView();
        }

        private void Rejestration_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            RejestrationPanel.Location = new Point(240, 188);
            RejestrationPanel.Visible = true;
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

        private async void AddAccount_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Zły format tefonu! ");
                return;
            }
            else if (!emailIsValid(textBox2.Text.ToString()) || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Zły format mail! ");
                return;
            }
            else if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Brak hasła! ");
                return;
            }
            User newUser = new User();

            newUser.Email = textBox2.Text.ToString();
            newUser.FirstName = textBox1.Text.ToString();
            newUser.LastName = textBox4.Text.ToString();
            newUser.PassWord = textBox3.Text.ToString();
            newUser.PhoneNo = textBox5.Text.ToString();


            UserManagmentUnsecureClient userManagmentUnsecureClient = new UserManagmentUnsecureClient();
            try {
                if (!userManagmentUnsecureClient.IsEmailInDB(newUser.Email))
                {
                    await userManagmentUnsecureClient.AddUserAsync(newUser);
                }
                else
                {
                    MessageBox.Show("Podany mail już istnieje ");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Boom ");
                return;
            }
            

            RejestrationPanel.Visible = false;
            LoginPanel.Visible = true;
        }

        
        private async void DeleteReservation_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Najpierw wybierz bilet");
                return;
            }
            DateTime dt = (dataGridView1.SelectedRows[0].Tag as Ticket).Connection.DepartureTime;
            if (dt < DateTime.Now)
            {
                MessageBox.Show("Przejazd już się odbył. Nie możesz zwrocić tego biletu.");
                return;
            }
            

            if (MessageBox.Show("Czy na pewno chcesz odwołać rezerwację?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                try
                {
                    reservationManagment.ClientCredentials.UserName.UserName = userManagment.ClientCredentials.UserName.UserName;
                    reservationManagment.ClientCredentials.UserName.Password = userManagment.ClientCredentials.UserName.Password;
                    reservationManagment.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                        System.ServiceModel.Security.X509CertificateValidationMode.None;
                    System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                    var choosedtic = dataGridView1.SelectedRows[0].Tag as Ticket;
                    await reservationManagment.DeleteReservationAsync(loginUser, choosedtic);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie można odwołać biletu");
                }
                TicketsView();
                todelete = false;
            }
            else return;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            oldform.log = false;
            this.Close();
            oldform.Show();

        }

        private void AddNewPass_Click(object sender, EventArgs e)
        {

            UserManagmentClient userManagment = new UserManagmentClient();
            UserManagmentUnsecureClient userManagmentUnsecureClient = new UserManagmentUnsecureClient();
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                userManagment.ClientCredentials.UserName.UserName = loginUser;
                userManagment.ClientCredentials.UserName.Password = OldPassBox.Text.ToString();

                userManagment.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                System.ServiceModel.Security.X509CertificateValidationMode.None;
                userManagment.Login();

                userManagment.ChangePass(loginUser, NewPassBox.Text.ToString());

                UserManagmentClient userManagment2 = new UserManagmentClient();
                userManagment2.ClientCredentials.UserName.UserName = loginUser;
                userManagment2.ClientCredentials.UserName.Password = NewPassBox.Text.ToString();

                userManagment2.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                System.ServiceModel.Security.X509CertificateValidationMode.None;
                userManagment2.LoginAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wprowadziłeś złe hasło");
                oldform.log = false;
                return;
            }

            LoginPanel.Visible = false;
            MyticketsPanel.Location = new Point(240, 188);
            MyticketsPanel.Visible = true;
            ButtonsPanel.Visible = true;
            oldform.log = true;
        }

        private void button1_Click(object sender, EventArgs e) //?
        {
            PassPanel.Visible = false;
            MyticketsPanel.Visible = true;
        }//powrot

        public async void ReservationView(List<Connection> res)
        {
            foreach (var elem in res)
            {
                int seat = -1;
                try
                {
                    ReservationManagmentClient rm = new ReservationManagmentClient();
                    rm.ClientCredentials.UserName.UserName = loginUser;
                    rm.ClientCredentials.UserName.Password = userManagment.ClientCredentials.UserName.Password;
                    rm.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                        System.ServiceModel.Security.X509CertificateValidationMode.None;
                    seat= await rm.MakeReservationAsync(elem, loginUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem with security");
                    return;
                }

                TicketsView();
                //dataGridView1.Rows.Clear();
                //var x = new DataGridViewRow();
                //x.Tag = res;

                //dataGridView1.Rows.Add(x);
                //dataGridView1.Rows[0].Cells[0].Value = elem.ConnectionDefinition.Departure.Name;
                //dataGridView1.Rows[0].Cells[1].Value = elem.ConnectionDefinition.Arrival.Name;
                //dataGridView1.Rows[0].Cells[2].Value = elem.DepartureTime;
                //dataGridView1.Rows[0].Cells[3].Value = elem.ArrivalTime;

                //dataGridView1.Rows[0].Cells[5].Value = elem.ConnectionDefinition.Price;
                //if (seat == -1)
                //{
                //    dataGridView1.Rows[0].Cells[4].Value = "Stojące";
                //}
                //else dataGridView1.Rows[0].Cells[4].Value = seat;
            }
        }
        public async void TicketsView()
        {
            try
            {
                ReservationManagmentClient rm = new ReservationManagmentClient();
                rm.ClientCredentials.UserName.UserName = loginUser;
                rm.ClientCredentials.UserName.Password = userManagment.ClientCredentials.UserName.Password;
                rm.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                    System.ServiceModel.Security.X509CertificateValidationMode.None;
                listofticekets =  await rm.AllUserReservationsAsync(loginUser);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie możemy wyświetlić twoich biletów. Klops :( ");
                return;
            }
            
            dataGridView1.Rows.Clear();
            
            int i = 0;
            foreach (var ticket in listofticekets)
            {
                var x = new DataGridViewRow();
                x.Tag = ticket;

                dataGridView1.Rows.Add(x);
                dataGridView1.Rows[i].Cells[0].Value = ticket.Connection.ConnectionDefinition.Departure.Name;
                dataGridView1.Rows[i].Cells[1].Value = ticket.Connection.ConnectionDefinition.Arrival.Name;
                dataGridView1.Rows[i].Cells[2].Value = ticket.Connection.DepartureTime;
                dataGridView1.Rows[i].Cells[3].Value = ticket.Connection.ArrivalTime;
                dataGridView1.Rows[i].Cells[4].Value = ticket.Seat;
                dataGridView1.Rows[i].Cells[5].Value = ticket.Connection.ConnectionDefinition.Price; ;

                i++;
            }
            
            
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldform.Show();
        }
    }
}

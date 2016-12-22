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
<<<<<<< HEAD
        public string loginUser;
        UserManagmentClient userManagment = new UserManagmentClient();
        public ReservationManagmentClient reservationManagment = new ReservationManagmentClient();
        public List<Connection> choosedtodetails;
        public List<Ticket> listofticekets=new List<Ticket>();
        public UserAccount(Form1 f)
        {

            InitializeComponent();
=======
        public UserAccount(Form1 f)
        {
            
            InitializeComponent();
            
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
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
<<<<<<< HEAD
            this.Hide();
            oldform.Show();
=======
            Form1 form = new Form1();
            this.Hide();
            form.Show();
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (boxLogin.Text.Length == 0)
            {
                MessageBox.Show("Brak loginu! ");
                return;
            }
            if (boxPass.Text.Length == 0)
            {
<<<<<<< HEAD
                MessageBox.Show("Brak hasła! ");
                return;
            }

            try
            {
                userManagment.ClientCredentials.UserName.UserName = boxLogin.Text.ToString();
                userManagment.ClientCredentials.UserName.Password = boxPass.Text.ToString();

=======
                userManagment.ClientCredentials.UserName.UserName = boxLogin.Text.ToString();
                userManagment.ClientCredentials.UserName.Password = boxPass.Text.ToString();
                
                
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
                userManagment.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                System.ServiceModel.Security.X509CertificateValidationMode.None;

                userManagment.Login();
            }
            catch (Exception ex)
            {
                textValidation.Visible = true;
                oldform.log = false;
<<<<<<< HEAD
                return;
            }

=======
            }
           
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
            LoginPanel.Visible = false;
            MyticketsPanel.Location = new Point(240, 188);
            MyticketsPanel.Visible = true;
            ButtonsPanel.Visible = true;
            oldform.log = true;
<<<<<<< HEAD
            loginUser = boxLogin.Text.ToString();
            TicketsView();
=======
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
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

        private void AddAccount_Click(object sender, EventArgs e)
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
            if (userManagmentUnsecureClient.IsEmailInDB(newUser.Email))
            {
                userManagmentUnsecureClient.AddUser(newUser);
            }
            else
            {
                MessageBox.Show("Podany mail już istnieje ");
                return;
            }

            RejestrationPanel.Visible = false;
            LoginPanel.Visible = true;
        }

        private void Information_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Najpierw wybierz połączenie");
                return;
            }
<<<<<<< HEAD
            choosedtodetails= dataGridView1.SelectedRows[0].Tag as List<Connection>;
            Form ConnectionDefinitionWindow = new ConnectionDefinitionWindow(this);
            ConnectionDefinitionWindow.Show();
            
=======
            //dataGridView1.SelectedRows[0].Tag as Connection
            Form ConnectionDefinitionWindow = new ConnectionDefinitionWindow();
            ConnectionDefinitionWindow.Show();
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713
        }

        private void DeleteReservation_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Najpierw wybierz bilet");
                return;
            }
            try {
                ReservationManagmentClient rm = new ReservationManagmentClient();
                rm.ClientCredentials.UserName.UserName = loginUser;
                rm.ClientCredentials.UserName.Password = userManagment.ClientCredentials.UserName.Password;
                rm.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                    System.ServiceModel.Security.X509CertificateValidationMode.None;
                //userManagment.Login();
                var choosedCon = dataGridView1.SelectedRows[0].Tag as List<Connection>;
                rm.DeleteReservation(loginUser, choosedCon);
            }
            catch(Exception ex)
            {
                MessageBox.Show("problem with security");
            }
            TicketsView();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            oldform.log = false;
            this.Hide();
            oldform.Show();
=======

            Form1 form = new Form1();
            oldform.log = false;
            this.Hide();
            form.Show();
>>>>>>> b6abe6c0a1d898fa9fa4a06de042813d4e507713

        }

        private void AddNewPass_Click(object sender, EventArgs e)
        {

            UserManagmentClient userManagment = new UserManagmentClient();
            UserManagmentUnsecureClient userManagmentUnsecureClient = new UserManagmentUnsecureClient();
            try
            {
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
                userManagment2.Login();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldform.Show();
        }//powrot

        public void ReservationView(List<Connection> res)
        {
            try { 
            ReservationManagmentClient rm = new ReservationManagmentClient();
            rm.ClientCredentials.UserName.UserName = loginUser;
            rm.ClientCredentials.UserName.Password = userManagment.ClientCredentials.UserName.Password;
            rm.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                System.ServiceModel.Security.X509CertificateValidationMode.None;
            rm.MakeReservation(res, loginUser);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem with security");
                return;
            }
    

            

            int seat = -1;
            dataGridView1.Rows.Clear();
            var x = new DataGridViewRow();
            x.Tag = res;

            dataGridView1.Rows.Add(x);
            dataGridView1.Rows[0].Cells[0].Value = res.First().ConnectionDefinition.Departure.Name;
            dataGridView1.Rows[0].Cells[1].Value = res.Last().ConnectionDefinition.Arrival.Name;
            dataGridView1.Rows[0].Cells[2].Value = res.First().DepartureTime;
            int totalPrice = 0;
            foreach (var elem in res)
            {
                totalPrice += elem.ConnectionDefinition.Price;
            }
            dataGridView1.Rows[0].Cells[3].Value = totalPrice;
            if (seat == -1)
            {
                dataGridView1.Rows[0].Cells[4].Value = "Stojące";
            }
            else dataGridView1.Rows[0].Cells[4].Value = seat;

        }
        public void TicketsView()
        {
            try
            {
                ReservationManagmentClient rm = new ReservationManagmentClient();
                rm.ClientCredentials.UserName.UserName = loginUser;
                rm.ClientCredentials.UserName.Password = userManagment.ClientCredentials.UserName.Password;
                rm.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                    System.ServiceModel.Security.X509CertificateValidationMode.None;
                listofticekets = rm.AllUserReservations(loginUser);
            }
            catch(Exception ex)
            {
                MessageBox.Show("NIe możemy wyświetlić twoich biletów. Klops :( ");
                return;
            }
            
            dataGridView1.Rows.Clear();
            var x = new DataGridViewRow();
            int i = 0;
            foreach (var ticket in listofticekets)
            {
                x.Tag = ticket;

                dataGridView1.Rows.Add(x);
                dataGridView1.Rows[i].Cells[0].Value = ticket.Connection.First().ConnectionDefinition.Departure.Name;
                dataGridView1.Rows[i].Cells[1].Value = ticket.Connection.Last().ConnectionDefinition.Arrival.Name;
                dataGridView1.Rows[i].Cells[2].Value = ticket.Connection.First().DepartureTime;
                dataGridView1.Rows[i].Cells[3].Value = ticket.Connection.Count()-1;
                int totalPrice = 0;
                foreach (var elem in ticket.Connection)
                {
                    totalPrice += elem.ConnectionDefinition.Price;
                }
                dataGridView1.Rows[i].Cells[4].Value = totalPrice;

                i++;
            }
            
            
        }
        
    }
}

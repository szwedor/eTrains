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

namespace GUI
{
    public partial class UserAccount : Form
    {
        public bool log = false;
        public UserAccount()
        {
            InitializeComponent();
            ButtonsPanel.Visible = false;
            MyticketsPanel.Visible = false;
            RejestrationPanel.Visible = false;
            boxPass.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            
        }

        private void Mytickets_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            textValidation.Visible = false;
            //newUser = r.FindUser(boxLogin.Text.ToString());
            //if (newUser == null)
            //{
            //    textValidation.Visible = true;
            //    return;
            //}
            if (true/*r.ValidateUser(newUser, boxPass.Text.ToString())*/)
            {
                LoginPanel.Visible = false;
                MyticketsPanel.Visible = true;
                log = true;
            }
            else
            {
                textValidation.Visible = true;
                log = false;
            }
        }

        private void Rejestration_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
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
            //// else if(!r.FindEmail(textBox2.Text.ToString()))
            //{
            //    MessageBox.Show("Podany mail już istnieje ");
            //}
            // else
            //{
            //    welcome.Text = "Witaj  " + name;
            //    welcome.ForeColor = Color.White;
            //    welcome.Font = new Font("Century Gothic", 24);
            //    welcome.Location = new Point(502, 12);
            //    welcome.Size = new Size(478, 70);
            //    welcome.Multiline = true;
            //    welcome.TextAlign = HorizontalAlignment.Center;
            //    welcome.ReadOnly = true;
            //    this.Controls.AddRange(new Control[] { welcome });


            //    newUser = new User();
            //    newUser.FirstName = textBox1.Text.ToString();
            //    newUser.LastName = textBox4.Text.ToString();
            //    string hashpass;
            //    using (var sha = new System.Security.Cryptography.SHA256Managed())
            //    {
            //        byte[] textData = System.Text.Encoding.UTF8.GetBytes(textBox3.Text.ToString());
            //        byte[] hash = sha.ComputeHash(textData);
            //        hashpass = BitConverter.ToString(hash).Replace("-", String.Empty);
            //    }
            //    newUser.PassWord = hashpass;
            //    newUser.Email = textBox2.Text.ToString();
            //    newUser.PhoneNo = textBox5.Text.ToString();
            //    //    r.AddUser(newUser);
            //}
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
            //dataGridView1.SelectedRows[0].Tag as Connection
            Form ConnectionDefinitionWindow = new ConnectionDefinitionWindow();
            ConnectionDefinitionWindow.Show();
        }

        private void DeleteReservation_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            log = false;
            Form1 form = new Form1();
            this.Hide();
            form.Show();

        }
    }
}

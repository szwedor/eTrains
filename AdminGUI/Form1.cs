using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AdminGUI.Forms;
using AdminGUI.Forms.ConnectionDefinition;
using AdminGUI.Forms.Station;
using DomainModel.Models;
using System.Threading.Tasks;

namespace AdminGUI
{
    public partial class Form1 : Form
    {

        private Panel Background;
        private Button AddConectionDefinitionButton;
        private Button EditConnectionDefinitionButton;
        private Button ArchiveConnectionDefiniton;

        private Button AddStationButton;
        private Button EditStationButton;
        private Button ArchiveStationButton;

        private Button AddNewConnectionButton;
        private Button LoginButton;

        private Button Search;
        private TextBox Email;
        private TextBox Password;
        private List<Button> Buttons;
        private Label EmailLabel;
        private Label PasswordLabel;

        private AddStation addStation;
        private EditStation editStation;
        private ArchiveStation archiveStation;

        private EditConnectionDefinition addNewConnection;

        private AddConectionDefinition addConectionDefinition;
        private EditConnectionDefinition editConnectionDefinition;
        private ArchiveConnectionDefiniton archiveConnectionDefiniton;
        private Task<List<Station>> _stationsList;
        private Admin.AdminClient AC;
        public Form1()
        {
            InitializeComponent();
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            this.Height = 815 + titleHeight;
            this.Width = 800;
            this.MaximumSize = this.MinimumSize = this.Size;
            Buttons = new List<Button>()
            {
                (AddConectionDefinitionButton = new Button()),
                (EditConnectionDefinitionButton= new Button()),
                (ArchiveConnectionDefiniton = new Button()),
                (AddStationButton = new Button()),
                (EditStationButton = new Button()),
                (ArchiveStationButton = new Button()),
                (AddNewConnectionButton = new Button())
            };
            List<string> Names = new List<string>()
            {
                "Dodaj połączenie",
                "Edytuj połączenie",
                "Usuń Połczenie",
                "Dodaj Stacje",
                "Edytuj Stacje",
                "Usuń Stacje",
                "Dodaj nowy przejazd"

            };
            this.Controls.Add(Background = new Panel());
            Background.BackColor = Program.BackGroundColor;
            int Margin = 60;
            Background.Size = new Size(ClientSize.Width - Margin, ClientSize.Height - Margin);
            Background.Top = (this.ClientSize.Height - Background.Height) / 2;
            Background.Left = (this.ClientSize.Width - Background.Width) / 2;
            int padding = 10;
            int heightbutton = 200;
            for (int i = 0; i < Buttons.Count; i++)
            {

                Buttons[i].BackColor = System.Drawing.Color.Gray;
                Buttons[i].Font = new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Buttons[i].ForeColor = System.Drawing.Color.White;
                Buttons[i].Location = new System.Drawing.Point(i % 3 * (Background.Width - padding) / 3 + padding, heightbutton * (i / 3) + padding);
                Buttons[i].Size = new System.Drawing.Size(Background.Width / 3 - padding, heightbutton - padding);
                Buttons[i].TabIndex = i;
                Buttons[i].Text = Names[i];
                Buttons[i].UseVisualStyleBackColor = false;
                Background.Controls.Add(Buttons[i]);
                Buttons[i].Enabled = false;
            }
            AddNewConnectionButton.Size = new System.Drawing.Size(Background.Width - 2 * padding, 2 * heightbutton / 3 - padding);


            LoginButton=Program.MakeStylishButton(
            new System.Drawing.Size(Background.Width / 3 - padding, heightbutton - padding), 
            new System.Drawing.Point(2 * (Background.Width - padding) / 3 + padding, AddNewConnectionButton.Location.Y + padding + AddNewConnectionButton.Height),
            "Zaloguj")
            ;
            Background.Controls.Add(LoginButton);

            Email = new TextBox();
            Email.Location = new System.Drawing.Point(padding, LoginButton.Location.Y);
            Email.Size = LoginButton.Size;
            Email.Font = new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Background.Controls.Add(Email);

            EmailLabel = new Label()
            {
                Location = new System.Drawing.Point(padding, Email.Location.Y + Email.Size.Height),
                Font =
                   new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold,
                       System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Size = LoginButton.Size,
                ForeColor = System.Drawing.Color.White,
                Text = "Email"
            };
            Background.Controls.Add(EmailLabel);

            Password = new TextBox();
            Password.Location = new System.Drawing.Point((Background.Width - padding) / 3 + padding, LoginButton.Location.Y);
            Password.Size = LoginButton.Size;
            Password.Font = new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Background.Controls.Add(Password);

            PasswordLabel = new Label()
            {
                Location = new System.Drawing.Point((Background.Width - padding) / 3 + padding, Email.Location.Y + Email.Size.Height),
                Font =
                  new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold,
                      System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Size = LoginButton.Size,
                ForeColor = System.Drawing.Color.White,
                Text = "Hasło"
            };
            Background.Controls.Add(PasswordLabel);

            LoginButton.Click += new System.EventHandler(LoginClick);
            AddNewConnectionButton.Click += new System.EventHandler(AddNewConnectionClick);
            AddConectionDefinitionButton.Click += new System.EventHandler(AddConectionDefinitionButtonClick);
            EditConnectionDefinitionButton.Click += new System.EventHandler(EditConnectionDefinitionButtonClick);
            ArchiveConnectionDefiniton.Click += new System.EventHandler(EditConnectionDefinitionButtonClick);
            AddStationButton.Click += new System.EventHandler(AddStationButtonClick);
            EditStationButton.Click += new System.EventHandler(EditStationButtonClick);
            ArchiveStationButton.Click += new System.EventHandler(ArchiveStationButtonClick);

            Size s= new Size(ClientSize.Width, ClientSize.Height - 200);
            //this.Controls.Add(addConectionDefinition = new AddConectionDefinition(s, Background));
            //this.Controls.Add(editConnectionDefinition = new EditConnectionDefinition(s, Background));
            //this.Controls.Add(archiveConnectionDefiniton = new ArchiveConnectionDefiniton(s, Background));
            //this.Controls.Add(addNewConnection = new EditConnectionDefinition(s, Background, SearchResult.Mode.NewConnection));
            //this.Controls.Add(addStation = new AddStation(s, Background));
            //this.Controls.Add(editStation = new EditStation(s, Background));
            //this.Controls.Add(archiveStation = new ArchiveStation(s, Background));
            //addConectionDefinition.Visible =
            //    editConnectionDefinition.Visible =
            //        archiveConnectionDefiniton.Visible =
            //            addNewConnection.Visible =
            //                addStation.Visible =
            //                    editStation.Visible =
            //                        archiveStation.Visible = false;
           
            Password.PasswordChar = '*';
        }

        private void LoginClick(object sender, EventArgs e)
        {
            AC = new Admin.AdminClient();
            {
               // Email.Text = "admin@admin.pl";
                if (Email.Text.Length == 0)
                {
                    MessageBox.Show("Brak loginu! ");
                    return;
                }
              //  Password.Text = "Admin1";
                if (Password.Text.Length == 0)
                {
                    MessageBox.Show("Brak hasła! ");
                    return;
                }

                try
                {
                    AC.ClientCredentials.UserName.UserName = Email.Text.ToString();
                    AC.ClientCredentials.UserName.Password = Password.Text.ToString();

                    AC.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                    System.ServiceModel.Security.X509CertificateValidationMode.None;
                    System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                    AC.Login();
                    _stationsList = AC.AllStationsAsync();
                }
                catch (Exception ex)
                {

                    Password.BackColor = Color.Red;
                    Email.BackColor = Color.Red;
                    MessageBox.Show("Zły login/hasło");
                    return;
                }












                
                
                foreach (var b in Buttons)
                {
                    b.Enabled = true;
                    b.BackColor = Program.BackColor;

                }
                LoginButton.Visible =
                    Email.Visible =
                        Password.Visible =
                            EmailLabel.Visible =
                                PasswordLabel.Visible =
                                    false;
                Background.Height -= 200;
                this.MaximumSize = this.MinimumSize = this.Size = new Size(Width, Height - 200);


                
                
                
              
                
                
                
           
            }
        }

   
        

        private void AddConectionDefinitionButtonClick(object sender, EventArgs e)
        {
            if (addConectionDefinition == null)
            {
                this.Controls.Add(addConectionDefinition = new AddConectionDefinition(ClientSize, Background, AC, _stationsList));
                addConectionDefinition.Visible = false;
            }

            if (addStation != null)
                addStation.sync();
            Background.Visible = false;
            addConectionDefinition.Visible = true;


        }
        private void EditConnectionDefinitionButtonClick(object sender, EventArgs e)
        {
            if (editConnectionDefinition == null)
            {
                this.Controls.Add(editConnectionDefinition = new EditConnectionDefinition(ClientSize, Background, AC, _stationsList));
                editConnectionDefinition.Visible = false;
            }

            if (addStation != null)
                addStation.sync();
            Background.Visible = false;
            editConnectionDefinition.Visible = true;
        }
        private void ArchiveConnectionDefinitonClick(object sender, EventArgs e)
        {
            if (archiveConnectionDefiniton == null)
            {
                this.Controls.Add(archiveConnectionDefiniton = new ArchiveConnectionDefiniton(ClientSize, Background, AC, _stationsList));
                archiveConnectionDefiniton.Visible = false;
            }

            if (addStation != null)
                addStation.sync();
            Background.Visible = false;
            archiveConnectionDefiniton.Visible = true;
        }
        private void AddStationButtonClick(object sender, EventArgs e)
        {
            if (addStation == null)
            {
                this.Controls.Add(addStation = new AddStation(ClientSize, Background, AC, _stationsList, this));
                addStation.Visible = false;
            }
            else
                addStation.sync();
            Background.Visible = false;
            addStation.Visible = true;
        }
        private void EditStationButtonClick(object sender, EventArgs e)
        {
            if (editStation == null)
            {
                this.Controls.Add(editStation = new EditStation(ClientSize, Background, AC, _stationsList));
                editStation.Visible = false;
            }
            if(addStation!=null)
            addStation.sync();

            Background.Visible = false;
            editStation.Visible = true;
        }
        private void ArchiveStationButtonClick(object sender, EventArgs e)
        {
            if (archiveStation == null)
            {
                this.Controls.Add(archiveStation = new ArchiveStation(ClientSize, Background, AC, _stationsList));
                archiveStation.Visible = false;
            }

            if (addStation != null)
                addStation.sync();
            Background.Visible = false;
            archiveStation.Visible = true;
        }
        private void AddNewConnectionClick(object sender, EventArgs e)
        {
            if (addNewConnection == null)
            {
                this.Controls.Add(addNewConnection = new EditConnectionDefinition(ClientSize, Background, AC, _stationsList, SearchResult.Mode.NewConnection));
                addNewConnection.Visible = false;

            }

            if (addStation != null)
                addStation.sync();
            Background.Visible = false;
            addNewConnection.Visible = true;
        }
    }
}

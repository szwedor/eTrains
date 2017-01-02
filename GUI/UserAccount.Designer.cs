namespace GUI
{
    partial class UserAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Return = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textValidation = new System.Windows.Forms.TextBox();
            this.Rejestration = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textRejestr = new System.Windows.Forms.TextBox();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.ChangePass = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Mytickets = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MyticketsPanel = new System.Windows.Forms.Panel();
            this.DeleteReservation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Odjazd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przyjazd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czasodjazdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzasPrzyjazdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miejsce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RejestrationPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.AddAccount = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PassPanel = new System.Windows.Forms.Panel();
            this.AddNewPass = new System.Windows.Forms.Button();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.OldPassBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MyticketsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RejestrationPanel.SuspendLayout();
            this.PassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.Return);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.textValidation);
            this.LoginPanel.Controls.Add(this.Rejestration);
            this.LoginPanel.Controls.Add(this.textLogin);
            this.LoginPanel.Controls.Add(this.textRejestr);
            this.LoginPanel.Controls.Add(this.boxPass);
            this.LoginPanel.Controls.Add(this.LogIn);
            this.LoginPanel.Controls.Add(this.boxLogin);
            this.LoginPanel.Location = new System.Drawing.Point(240, 188);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(697, 202);
            this.LoginPanel.TabIndex = 48;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Return.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Return.Location = new System.Drawing.Point(557, -1);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(123, 31);
            this.Return.TabIndex = 4;
            this.Return.Text = "Strona główna";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(311, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Hasło";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Logowanie";
            // 
            // textValidation
            // 
            this.textValidation.BackColor = System.Drawing.Color.White;
            this.textValidation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textValidation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValidation.ForeColor = System.Drawing.Color.OrangeRed;
            this.textValidation.Location = new System.Drawing.Point(174, 102);
            this.textValidation.Multiline = true;
            this.textValidation.Name = "textValidation";
            this.textValidation.ReadOnly = true;
            this.textValidation.Size = new System.Drawing.Size(224, 31);
            this.textValidation.TabIndex = 57;
            this.textValidation.TabStop = false;
            this.textValidation.Text = "Błąd w loginie lub haśle";
            this.textValidation.Visible = false;
            this.textValidation.WordWrap = false;
            // 
            // Rejestration
            // 
            this.Rejestration.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Rejestration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rejestration.ForeColor = System.Drawing.Color.White;
            this.Rejestration.Location = new System.Drawing.Point(8, 158);
            this.Rejestration.Name = "Rejestration";
            this.Rejestration.Size = new System.Drawing.Size(123, 29);
            this.Rejestration.TabIndex = 55;
            this.Rejestration.Text = "Zarejestruj się";
            this.Rejestration.UseVisualStyleBackColor = false;
            this.Rejestration.Click += new System.EventHandler(this.Rejestration_Click);
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.White;
            this.textLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textLogin.Location = new System.Drawing.Point(28, 70);
            this.textLogin.Multiline = true;
            this.textLogin.Name = "textLogin";
            this.textLogin.ReadOnly = true;
            this.textLogin.Size = new System.Drawing.Size(38, 54);
            this.textLogin.TabIndex = 50;
            this.textLogin.TabStop = false;
            this.textLogin.Text = "Login";
            this.textLogin.WordWrap = false;
            // 
            // textRejestr
            // 
            this.textRejestr.BackColor = System.Drawing.Color.White;
            this.textRejestr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRejestr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRejestr.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textRejestr.Location = new System.Drawing.Point(8, 133);
            this.textRejestr.Multiline = true;
            this.textRejestr.Name = "textRejestr";
            this.textRejestr.ReadOnly = true;
            this.textRejestr.Size = new System.Drawing.Size(126, 54);
            this.textRejestr.TabIndex = 56;
            this.textRejestr.TabStop = false;
            this.textRejestr.Text = "Nie masz konta?";
            this.textRejestr.WordWrap = false;
            // 
            // boxPass
            // 
            this.boxPass.Location = new System.Drawing.Point(371, 70);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(107, 20);
            this.boxPass.TabIndex = 53;
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.LogIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogIn.ForeColor = System.Drawing.Color.White;
            this.LogIn.Location = new System.Drawing.Point(557, 58);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(123, 39);
            this.LogIn.TabIndex = 54;
            this.LogIn.Text = "Zaloguj się";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // boxLogin
            // 
            this.boxLogin.Location = new System.Drawing.Point(72, 70);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(107, 20);
            this.boxLogin.TabIndex = 52;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.LogOut);
            this.ButtonsPanel.Controls.Add(this.ChangePass);
            this.ButtonsPanel.Controls.Add(this.Search);
            this.ButtonsPanel.Controls.Add(this.Mytickets);
            this.ButtonsPanel.Location = new System.Drawing.Point(17, 188);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(200, 224);
            this.ButtonsPanel.TabIndex = 49;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOut.Location = new System.Drawing.Point(0, 133);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(200, 46);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Wyloguj";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ChangePass
            // 
            this.ChangePass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangePass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangePass.Location = new System.Drawing.Point(0, 44);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(200, 46);
            this.ChangePass.TabIndex = 2;
            this.ChangePass.Text = "Zmień hasło";
            this.ChangePass.UseVisualStyleBackColor = false;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Search.Location = new System.Drawing.Point(0, 88);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(200, 46);
            this.Search.TabIndex = 1;
            this.Search.Text = "Wyszukaj połączenie";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Mytickets
            // 
            this.Mytickets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Mytickets.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mytickets.Location = new System.Drawing.Point(0, -1);
            this.Mytickets.Name = "Mytickets";
            this.Mytickets.Size = new System.Drawing.Size(200, 46);
            this.Mytickets.TabIndex = 0;
            this.Mytickets.Text = "Moje bilety";
            this.Mytickets.UseVisualStyleBackColor = false;
            this.Mytickets.Click += new System.EventHandler(this.Mytickets_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.Bez_tytułu;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 78);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // MyticketsPanel
            // 
            this.MyticketsPanel.Controls.Add(this.DeleteReservation);
            this.MyticketsPanel.Controls.Add(this.dataGridView1);
            this.MyticketsPanel.Location = new System.Drawing.Point(240, 396);
            this.MyticketsPanel.Name = "MyticketsPanel";
            this.MyticketsPanel.Size = new System.Drawing.Size(715, 221);
            this.MyticketsPanel.TabIndex = 50;
            // 
            // DeleteReservation
            // 
            this.DeleteReservation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteReservation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteReservation.Location = new System.Drawing.Point(3, 173);
            this.DeleteReservation.Name = "DeleteReservation";
            this.DeleteReservation.Size = new System.Drawing.Size(200, 26);
            this.DeleteReservation.TabIndex = 5;
            this.DeleteReservation.Text = "Odwołaj rezerwację";
            this.DeleteReservation.UseVisualStyleBackColor = false;
            this.DeleteReservation.Click += new System.EventHandler(this.DeleteReservation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Odjazd,
            this.Przyjazd,
            this.Czasodjazdu,
            this.CzasPrzyjazdu,
            this.Miejsce,
            this.Cena});
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Odjazd
            // 
            this.Odjazd.HeaderText = "Odjazd";
            this.Odjazd.Name = "Odjazd";
            this.Odjazd.Width = 150;
            // 
            // Przyjazd
            // 
            this.Przyjazd.HeaderText = "Przyjazd";
            this.Przyjazd.Name = "Przyjazd";
            this.Przyjazd.Width = 150;
            // 
            // Czasodjazdu
            // 
            this.Czasodjazdu.HeaderText = "Czas odjazdu";
            this.Czasodjazdu.Name = "Czasodjazdu";
            this.Czasodjazdu.Width = 150;
            // 
            // CzasPrzyjazdu
            // 
            this.CzasPrzyjazdu.HeaderText = "Czas przyjazdu";
            this.CzasPrzyjazdu.Name = "CzasPrzyjazdu";
            this.CzasPrzyjazdu.Width = 120;
            // 
            // Miejsce
            // 
            this.Miejsce.HeaderText = "Nr miejsca";
            this.Miejsce.Name = "Miejsce";
            this.Miejsce.Width = 50;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.Width = 70;
            // 
            // RejestrationPanel
            // 
            this.RejestrationPanel.Controls.Add(this.button1);
            this.RejestrationPanel.Controls.Add(this.label3);
            this.RejestrationPanel.Controls.Add(this.textBox1);
            this.RejestrationPanel.Controls.Add(this.textBox10);
            this.RejestrationPanel.Controls.Add(this.textBox9);
            this.RejestrationPanel.Controls.Add(this.textBox4);
            this.RejestrationPanel.Controls.Add(this.textBox8);
            this.RejestrationPanel.Controls.Add(this.AddAccount);
            this.RejestrationPanel.Controls.Add(this.textBox7);
            this.RejestrationPanel.Controls.Add(this.textBox2);
            this.RejestrationPanel.Controls.Add(this.textBox6);
            this.RejestrationPanel.Controls.Add(this.textBox3);
            this.RejestrationPanel.Controls.Add(this.textBox5);
            this.RejestrationPanel.Location = new System.Drawing.Point(240, 623);
            this.RejestrationPanel.Name = "RejestrationPanel";
            this.RejestrationPanel.Size = new System.Drawing.Size(697, 238);
            this.RejestrationPanel.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(554, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 60;
            this.button1.Text = "Strona główna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Return_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 60;
            this.label3.Text = "Rejestracja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 61;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Red;
            this.textBox10.Location = new System.Drawing.Point(52, 58);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 60;
            this.textBox10.Text = "Imię";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Red;
            this.textBox9.Location = new System.Drawing.Point(52, 84);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 59;
            this.textBox9.Text = "Nazwisko";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 20);
            this.textBox4.TabIndex = 58;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Red;
            this.textBox8.Location = new System.Drawing.Point(51, 162);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 57;
            this.textBox8.Text = "Telefon";
            // 
            // AddAccount
            // 
            this.AddAccount.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddAccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAccount.ForeColor = System.Drawing.Color.White;
            this.AddAccount.Location = new System.Drawing.Point(222, 198);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(116, 40);
            this.AddAccount.TabIndex = 14;
            this.AddAccount.Text = "Dołącz";
            this.AddAccount.UseVisualStyleBackColor = false;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(52, 110);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 56;
            this.textBox7.Text = "Hasło";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 53;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Red;
            this.textBox6.Location = new System.Drawing.Point(51, 136);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 55;
            this.textBox6.Text = "Adres e-mail";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 20);
            this.textBox3.TabIndex = 52;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(243, 20);
            this.textBox5.TabIndex = 54;
            // 
            // PassPanel
            // 
            this.PassPanel.Controls.Add(this.AddNewPass);
            this.PassPanel.Controls.Add(this.NewPassBox);
            this.PassPanel.Controls.Add(this.OldPassBox);
            this.PassPanel.Controls.Add(this.label5);
            this.PassPanel.Controls.Add(this.label4);
            this.PassPanel.Location = new System.Drawing.Point(398, 13);
            this.PassPanel.Name = "PassPanel";
            this.PassPanel.Size = new System.Drawing.Size(539, 111);
            this.PassPanel.TabIndex = 52;
            // 
            // AddNewPass
            // 
            this.AddNewPass.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddNewPass.ForeColor = System.Drawing.Color.White;
            this.AddNewPass.Location = new System.Drawing.Point(329, 32);
            this.AddNewPass.Name = "AddNewPass";
            this.AddNewPass.Size = new System.Drawing.Size(123, 29);
            this.AddNewPass.TabIndex = 60;
            this.AddNewPass.Text = "Zmień hasło";
            this.AddNewPass.UseVisualStyleBackColor = false;
            this.AddNewPass.Click += new System.EventHandler(this.AddNewPass_Click);
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(116, 58);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(135, 20);
            this.NewPassBox.TabIndex = 63;
            // 
            // OldPassBox
            // 
            this.OldPassBox.Location = new System.Drawing.Point(116, 21);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.Size = new System.Drawing.Size(135, 20);
            this.OldPassBox.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(40, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Nowe hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(40, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Stare hasło";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DomainModel.Models.User);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 620);
            this.Controls.Add(this.PassPanel);
            this.Controls.Add(this.RejestrationPanel);
            this.Controls.Add(this.MyticketsPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAccount";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MyticketsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RejestrationPanel.ResumeLayout(false);
            this.RejestrationPanel.PerformLayout();
            this.PassPanel.ResumeLayout(false);
            this.PassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox textValidation;
        private System.Windows.Forms.Button Rejestration;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textRejestr;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Mytickets;
        private System.Windows.Forms.Button ChangePass;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Panel MyticketsPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteReservation;
        private System.Windows.Forms.Panel RejestrationPanel;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PassPanel;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.TextBox OldPassBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddNewPass;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odjazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przyjazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czasodjazdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzasPrzyjazdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miejsce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button button1;
    }
}
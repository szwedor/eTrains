namespace GUI
{
    partial class Form1
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
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.FROM = new System.Windows.Forms.Button();
            this.TO = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textRejestr = new System.Windows.Forms.TextBox();
            this.Rejestration = new System.Windows.Forms.Button();
            this.textValidation = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gratulation = new System.Windows.Forms.Label();
            this.RezervationButton = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hoursTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MinutesTimePicer = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lprzesiadek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.Teal;
            this.textLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.ForeColor = System.Drawing.SystemColors.Menu;
            this.textLogin.Location = new System.Drawing.Point(513, 25);
            this.textLogin.Multiline = true;
            this.textLogin.Name = "textLogin";
            this.textLogin.ReadOnly = true;
            this.textLogin.Size = new System.Drawing.Size(38, 16);
            this.textLogin.TabIndex = 3;
            this.textLogin.TabStop = false;
            this.textLogin.Text = "Login";
            this.textLogin.WordWrap = false;
            // 
            // textPass
            // 
            this.textPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textPass.BackColor = System.Drawing.Color.Teal;
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.SystemColors.Menu;
            this.textPass.Location = new System.Drawing.Point(679, 25);
            this.textPass.Multiline = true;
            this.textPass.Name = "textPass";
            this.textPass.ReadOnly = true;
            this.textPass.Size = new System.Drawing.Size(42, 19);
            this.textPass.TabIndex = 5;
            this.textPass.Text = "Hasło";
            // 
            // boxLogin
            // 
            this.boxLogin.Location = new System.Drawing.Point(557, 25);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(100, 20);
            this.boxLogin.TabIndex = 6;
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.LogIn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.Color.White;
            this.LogIn.Location = new System.Drawing.Point(847, 24);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(116, 23);
            this.LogIn.TabIndex = 8;
            this.LogIn.Text = "Zaloguj się";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // FROM
            // 
            this.FROM.BackColor = System.Drawing.Color.White;
            this.FROM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FROM.Location = new System.Drawing.Point(44, 145);
            this.FROM.Name = "FROM";
            this.FROM.Size = new System.Drawing.Size(416, 57);
            this.FROM.TabIndex = 0;
            this.FROM.Text = "Z:";
            this.FROM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FROM.UseVisualStyleBackColor = false;
            this.FROM.Click += new System.EventHandler(this.FROM_Click);
            // 
            // TO
            // 
            this.TO.BackColor = System.Drawing.Color.White;
            this.TO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TO.Location = new System.Drawing.Point(44, 240);
            this.TO.Name = "TO";
            this.TO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TO.Size = new System.Drawing.Size(416, 57);
            this.TO.TabIndex = 1;
            this.TO.Text = "Do:";
            this.TO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TO.UseVisualStyleBackColor = false;
            this.TO.Click += new System.EventHandler(this.TO_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.ForeColor = System.Drawing.Color.White;
            this.Find.Location = new System.Drawing.Point(133, 491);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(228, 56);
            this.Find.TabIndex = 5;
            this.Find.Text = "Szukaj";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 16;
            this.listBoxFrom.Location = new System.Drawing.Point(44, 202);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(416, 68);
            this.listBoxFrom.TabIndex = 30;
            this.listBoxFrom.Visible = false;
            this.listBoxFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxFrom_MouseDown);
            // 
            // listBoxTo
            // 
            this.listBoxTo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.ItemHeight = 16;
            this.listBoxTo.Location = new System.Drawing.Point(44, 300);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(416, 52);
            this.listBoxTo.TabIndex = 31;
            this.listBoxTo.Visible = false;
            this.listBoxTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxTo_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GUI.Properties.Resources.pociag;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(502, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(471, 273);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.Bez_tytułu;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 78);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox4.Location = new System.Drawing.Point(12, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(471, 456);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(502, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textRejestr
            // 
            this.textRejestr.BackColor = System.Drawing.Color.Teal;
            this.textRejestr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRejestr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRejestr.ForeColor = System.Drawing.SystemColors.Menu;
            this.textRejestr.Location = new System.Drawing.Point(754, 57);
            this.textRejestr.Multiline = true;
            this.textRejestr.Name = "textRejestr";
            this.textRejestr.ReadOnly = true;
            this.textRejestr.Size = new System.Drawing.Size(119, 16);
            this.textRejestr.TabIndex = 36;
            this.textRejestr.TabStop = false;
            this.textRejestr.Text = "Nie masz konta?";
            this.textRejestr.WordWrap = false;
            // 
            // Rejestration
            // 
            this.Rejestration.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Rejestration.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejestration.ForeColor = System.Drawing.Color.White;
            this.Rejestration.Location = new System.Drawing.Point(847, 53);
            this.Rejestration.Name = "Rejestration";
            this.Rejestration.Size = new System.Drawing.Size(116, 23);
            this.Rejestration.TabIndex = 9;
            this.Rejestration.Text = "Zarejestruj się";
            this.Rejestration.UseVisualStyleBackColor = false;
            this.Rejestration.Click += new System.EventHandler(this.Rejestration_Click);
            // 
            // textValidation
            // 
            this.textValidation.BackColor = System.Drawing.Color.Teal;
            this.textValidation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textValidation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValidation.ForeColor = System.Drawing.Color.OrangeRed;
            this.textValidation.Location = new System.Drawing.Point(513, 53);
            this.textValidation.Multiline = true;
            this.textValidation.Name = "textValidation";
            this.textValidation.ReadOnly = true;
            this.textValidation.Size = new System.Drawing.Size(217, 23);
            this.textValidation.TabIndex = 38;
            this.textValidation.TabStop = false;
            this.textValidation.Text = "Błąd w loginie lub haśle";
            this.textValidation.Visible = false;
            this.textValidation.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(662, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(662, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(662, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(662, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(662, 428);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(243, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Red;
            this.textBox6.Location = new System.Drawing.Point(556, 367);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 44;
            this.textBox6.Text = "Adres e-mail";
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(557, 316);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 45;
            this.textBox7.Text = "Hasło";
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Red;
            this.textBox8.Location = new System.Drawing.Point(556, 428);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 46;
            this.textBox8.Text = "Telefon";
            this.textBox8.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Red;
            this.textBox9.Location = new System.Drawing.Point(557, 260);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 47;
            this.textBox9.Text = "Nazwisko";
            this.textBox9.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Red;
            this.textBox10.Location = new System.Drawing.Point(556, 209);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 48;
            this.textBox10.Text = "Imię";
            this.textBox10.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(650, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dołącz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.ConnectionDetails);
            this.SearchPanel.Controls.Add(this.dataGridView1);
            this.SearchPanel.Controls.Add(this.Gratulation);
            this.SearchPanel.Controls.Add(this.RezervationButton);
            this.SearchPanel.Location = new System.Drawing.Point(989, 106);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(472, 456);
            this.SearchPanel.TabIndex = 50;
            this.SearchPanel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Lprzesiadek});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(465, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // Gratulation
            // 
            this.Gratulation.AutoSize = true;
            this.Gratulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gratulation.ForeColor = System.Drawing.Color.Maroon;
            this.Gratulation.Location = new System.Drawing.Point(3, 375);
            this.Gratulation.Name = "Gratulation";
            this.Gratulation.Size = new System.Drawing.Size(205, 16);
            this.Gratulation.TabIndex = 2;
            this.Gratulation.Text = "Gratulacje! Zarezerowałeś bilet :)";
            this.Gratulation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gratulation.Visible = false;
            // 
            // RezervationButton
            // 
            this.RezervationButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.RezervationButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RezervationButton.ForeColor = System.Drawing.Color.White;
            this.RezervationButton.Location = new System.Drawing.Point(187, 335);
            this.RezervationButton.Name = "RezervationButton";
            this.RezervationButton.Size = new System.Drawing.Size(117, 23);
            this.RezervationButton.TabIndex = 1;
            this.RezervationButton.Text = "Zarezerwuj";
            this.RezervationButton.UseVisualStyleBackColor = false;
            this.RezervationButton.Click += new System.EventHandler(this.RezervationButton_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(509, 172);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 21);
            this.Error.TabIndex = 51;
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Error.Visible = false;
            // 
            // boxPass
            // 
            this.boxPass.Location = new System.Drawing.Point(727, 25);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(100, 20);
            this.boxPass.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(44, 358);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 11, 10, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(416, 27);
            this.dateTimePicker.TabIndex = 2;
            // 
            // hoursTimePicker
            // 
            this.hoursTimePicker.CustomFormat = "HH";
            this.hoursTimePicker.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold);
            this.hoursTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hoursTimePicker.Location = new System.Drawing.Point(133, 441);
            this.hoursTimePicker.Name = "hoursTimePicker";
            this.hoursTimePicker.ShowUpDown = true;
            this.hoursTimePicker.Size = new System.Drawing.Size(110, 39);
            this.hoursTimePicker.TabIndex = 3;
            // 
            // MinutesTimePicer
            // 
            this.MinutesTimePicer.CustomFormat = " mm";
            this.MinutesTimePicer.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold);
            this.MinutesTimePicer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MinutesTimePicer.Location = new System.Drawing.Point(249, 441);
            this.MinutesTimePicer.Name = "MinutesTimePicer";
            this.MinutesTimePicer.ShowUpDown = true;
            this.MinutesTimePicer.Size = new System.Drawing.Size(114, 39);
            this.MinutesTimePicer.TabIndex = 4;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Teal;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold);
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLabel.Location = new System.Drawing.Point(128, 397);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(235, 30);
            this.TimeLabel.TabIndex = 55;
            this.TimeLabel.Text = "Godzina Odjazdu";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Teal;
            this.labelFrom.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.labelFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFrom.Location = new System.Drawing.Point(40, 119);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(197, 23);
            this.labelFrom.TabIndex = 56;
            this.labelFrom.Text = "Stacja początkowa";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Teal;
            this.labelTo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.labelTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTo.Location = new System.Drawing.Point(40, 214);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(168, 23);
            this.labelTo.TabIndex = 57;
            this.labelTo.Text = "Stacja końcowa";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Teal;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold);
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(157, 307);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(188, 30);
            this.labelDate.TabIndex = 58;
            this.labelDate.Text = "Data Odjazdu";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(502, 106);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(471, 164);
            this.webBrowser1.TabIndex = 59;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Odjazd";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Przyjazd";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Czas Odjazdu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cena";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Lprzesiadek
            // 
            this.Lprzesiadek.HeaderText = "Liczba przesiadek";
            this.Lprzesiadek.Name = "Lprzesiadek";
            this.Lprzesiadek.ReadOnly = true;
            // 
            // ConnectionDetails
            // 
            this.ConnectionDetails.BackColor = System.Drawing.Color.Brown;
            this.ConnectionDetails.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionDetails.ForeColor = System.Drawing.Color.White;
            this.ConnectionDetails.Location = new System.Drawing.Point(6, 258);
            this.ConnectionDetails.Name = "ConnectionDetails";
            this.ConnectionDetails.Size = new System.Drawing.Size(26, 23);
            this.ConnectionDetails.TabIndex = 4;
            this.ConnectionDetails.Text = "i";
            this.ConnectionDetails.UseVisualStyleBackColor = false;
            this.ConnectionDetails.Click += new System.EventHandler(this.ConnectionDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(985, 594);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listBoxTo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.listBoxFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.MinutesTimePicer);
            this.Controls.Add(this.hoursTimePicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textValidation);
            this.Controls.Add(this.Rejestration);
            this.Controls.Add(this.textRejestr);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.FROM);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.boxLogin);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-TRAIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button FROM;
        private System.Windows.Forms.Button TO;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textRejestr;
        private System.Windows.Forms.Button Rejestration;
        private System.Windows.Forms.TextBox textValidation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button RezervationButton;
        private System.Windows.Forms.Label Gratulation;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker hoursTimePicker;
        private System.Windows.Forms.DateTimePicker MinutesTimePicer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lprzesiadek;
        private System.Windows.Forms.Button ConnectionDetails;
    }
}


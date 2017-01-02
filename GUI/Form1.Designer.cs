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
            this.FROM = new System.Windows.Forms.Button();
            this.TO = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.ConnectionDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cakowityczas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lprzesiadek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervationButton = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hoursTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MinutesTimePicer = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.UserAccount = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // FROM
            // 
            this.FROM.BackColor = System.Drawing.Color.White;
            this.FROM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.listBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.Location = new System.Drawing.Point(44, 202);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(416, 56);
            this.listBoxFrom.TabIndex = 30;
            this.listBoxFrom.Visible = false;
            this.listBoxFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxFrom_MouseDown);
            // 
            // listBoxTo
            // 
            this.listBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.Location = new System.Drawing.Point(44, 300);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(416, 56);
            this.listBoxTo.TabIndex = 31;
            this.listBoxTo.Visible = false;
            this.listBoxTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxTo_MouseDown);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.ConnectionDetails);
            this.SearchPanel.Controls.Add(this.dataGridView1);
            this.SearchPanel.Controls.Add(this.RezervationButton);
            this.SearchPanel.Location = new System.Drawing.Point(989, 106);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(472, 456);
            this.SearchPanel.TabIndex = 50;
            this.SearchPanel.Visible = false;
            // 
            // ConnectionDetails
            // 
            this.ConnectionDetails.BackColor = System.Drawing.Color.Brown;
            this.ConnectionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionDetails.ForeColor = System.Drawing.Color.White;
            this.ConnectionDetails.Location = new System.Drawing.Point(6, 258);
            this.ConnectionDetails.Name = "ConnectionDetails";
            this.ConnectionDetails.Size = new System.Drawing.Size(26, 23);
            this.ConnectionDetails.TabIndex = 4;
            this.ConnectionDetails.Text = "i";
            this.ConnectionDetails.UseVisualStyleBackColor = false;
            this.ConnectionDetails.Click += new System.EventHandler(this.ConnectionDetails_Click);
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
            this.Cakowityczas,
            this.Lprzesiadek,
            this.Column4});
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
            this.Column3.Width = 150;
            // 
            // Cakowityczas
            // 
            this.Cakowityczas.HeaderText = "Czas podróży";
            this.Cakowityczas.Name = "Cakowityczas";
            this.Cakowityczas.ReadOnly = true;
            // 
            // Lprzesiadek
            // 
            this.Lprzesiadek.HeaderText = "Liczba przesiadek";
            this.Lprzesiadek.Name = "Lprzesiadek";
            this.Lprzesiadek.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cena";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // RezervationButton
            // 
            this.RezervationButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.RezervationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RezervationButton.ForeColor = System.Drawing.Color.White;
            this.RezervationButton.Location = new System.Drawing.Point(187, 335);
            this.RezervationButton.Name = "RezervationButton";
            this.RezervationButton.Size = new System.Drawing.Size(146, 49);
            this.RezervationButton.TabIndex = 1;
            this.RezervationButton.Text = "Zarezerwuj";
            this.RezervationButton.UseVisualStyleBackColor = false;
            this.RezervationButton.Click += new System.EventHandler(this.RezervationButton_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(509, 172);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 20);
            this.Error.TabIndex = 51;
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Error.Visible = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(44, 358);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 11, 10, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(416, 26);
            this.dateTimePicker.TabIndex = 2;
            // 
            // hoursTimePicker
            // 
            this.hoursTimePicker.CustomFormat = "HH";
            this.hoursTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.hoursTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hoursTimePicker.Location = new System.Drawing.Point(133, 441);
            this.hoursTimePicker.Name = "hoursTimePicker";
            this.hoursTimePicker.ShowUpDown = true;
            this.hoursTimePicker.Size = new System.Drawing.Size(110, 36);
            this.hoursTimePicker.TabIndex = 3;
            // 
            // MinutesTimePicer
            // 
            this.MinutesTimePicer.CustomFormat = " mm";
            this.MinutesTimePicer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.MinutesTimePicer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MinutesTimePicer.Location = new System.Drawing.Point(249, 441);
            this.MinutesTimePicer.Name = "MinutesTimePicer";
            this.MinutesTimePicer.ShowUpDown = true;
            this.MinutesTimePicer.Size = new System.Drawing.Size(114, 36);
            this.MinutesTimePicer.TabIndex = 4;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Teal;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLabel.Location = new System.Drawing.Point(128, 397);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(225, 30);
            this.TimeLabel.TabIndex = 55;
            this.TimeLabel.Text = "Godzina Odjazdu";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Teal;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFrom.Location = new System.Drawing.Point(40, 119);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(193, 25);
            this.labelFrom.TabIndex = 56;
            this.labelFrom.Text = "Stacja początkowa";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Teal;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTo.Location = new System.Drawing.Point(40, 214);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(164, 25);
            this.labelTo.TabIndex = 57;
            this.labelTo.Text = "Stacja końcowa";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Teal;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(157, 307);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(181, 30);
            this.labelDate.TabIndex = 58;
            this.labelDate.Text = "Data Odjazdu";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(489, 89);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(484, 181);
            this.webBrowser1.TabIndex = 59;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GUI.Properties.Resources.pociag;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(502, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(471, 306);
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
            this.pictureBox4.Size = new System.Drawing.Size(471, 489);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // UserAccount
            // 
            this.UserAccount.BackColor = System.Drawing.Color.Teal;
            this.UserAccount.FlatAppearance.BorderSize = 0;
            this.UserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserAccount.ForeColor = System.Drawing.Color.White;
            this.UserAccount.Location = new System.Drawing.Point(44, 559);
            this.UserAccount.Name = "UserAccount";
            this.UserAccount.Size = new System.Drawing.Size(112, 23);
            this.UserAccount.TabIndex = 60;
            this.UserAccount.Text = ">> Moje konto";
            this.UserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserAccount.UseVisualStyleBackColor = false;
            this.UserAccount.Click += new System.EventHandler(this.UserAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(985, 620);
            this.Controls.Add(this.UserAccount);
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
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.FROM);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-TRAIN";
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button FROM;
        private System.Windows.Forms.Button TO;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button RezervationButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker hoursTimePicker;
        private System.Windows.Forms.DateTimePicker MinutesTimePicer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button ConnectionDetails;
        private System.Windows.Forms.Button UserAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cakowityczas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lprzesiadek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}


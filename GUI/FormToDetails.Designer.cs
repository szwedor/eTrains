namespace GUI
{
    partial class FormToDetails
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Odjazd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przyjazd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzasPrzyjazdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Odjazd,
            this.Przyjazd,
            this.Czas,
            this.CzasPrzyjazdu,
            this.Cena});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(827, 176);
            this.dataGridView.TabIndex = 1;
            // 
            // Odjazd
            // 
            this.Odjazd.HeaderText = "Odjazd";
            this.Odjazd.Name = "Odjazd";
            this.Odjazd.Width = 173;
            // 
            // Przyjazd
            // 
            this.Przyjazd.HeaderText = "Przyjazd";
            this.Przyjazd.Name = "Przyjazd";
            this.Przyjazd.Width = 170;
            // 
            // Czas
            // 
            this.Czas.HeaderText = "Czas Odjazdu";
            this.Czas.Name = "Czas";
            this.Czas.Width = 170;
            // 
            // CzasPrzyjazdu
            // 
            this.CzasPrzyjazdu.HeaderText = "Czas Przyjazdu";
            this.CzasPrzyjazdu.Name = "CzasPrzyjazdu";
            this.CzasPrzyjazdu.Width = 150;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.Width = 120;
            // 
            // FormToDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 176);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormToDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szczegóły";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odjazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przyjazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzasPrzyjazdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
    }
}
﻿namespace GUI
{
    partial class ConnectionDefinitionWindow
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
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Odjazd,
            this.Przyjazd,
            this.Czas,
            this.Cena});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(639, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // Odjazd
            // 
            this.Odjazd.HeaderText = "Odjazd";
            this.Odjazd.Name = "Odjazd";
            this.Odjazd.Width = 170;
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
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // ConnectionDefinitionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 172);
            this.Controls.Add(this.dataGridView);
            this.Name = "ConnectionDefinitionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionDefinitionWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odjazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przyjazd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
    }
}
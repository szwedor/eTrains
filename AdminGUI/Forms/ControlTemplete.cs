using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminGUI.Forms
{
    abstract public partial class ControlTemplete : UserControl
    {
        public ControlTemplete()
        {
            InitializeComponent();
        }
        protected Panel Background;
        private Panel returnPanel;
        protected Button returnButton;
        protected Button SaveButton;
        public ControlTemplete(Size s, Panel returnP)
        {
            
            InitializeComponent();
            this.Size = s;
            this.returnPanel = returnP;
            this.Controls.Add(Background = new Panel());
            Background.BackColor = Color.Teal;
            int Margin = 60;
            Background.Size = new Size(s.Width - Margin, s.Height - Margin);
            Background.Top = (s.Height - Background.Height)/2;
            Background.Left = (s.Width - Background.Width)/2;
            int padding = 10;
            returnButton = Program.MakeStylishButton(new System.Drawing.Size(Background.Width / 3 - padding, 50),
                new System.Drawing.Point(padding, padding), "Powrót");
            SaveButton = Program.MakeStylishButton(returnButton.Size,
              new System.Drawing.Point(Background.Width-padding-returnButton.Size.Width, padding), "Zapisz");
            SaveButton.Enabled = false;
            Background.Controls.Add(returnButton);
            Background.Controls.Add(SaveButton);
            returnButton.Click += new System.EventHandler(ReturnPanelClick);
            SaveButton.Click += new System.EventHandler(SaveClick);
        }

        protected virtual void ReturnPanelClick(object sender, EventArgs e)
        {
            returnPanel.Visible = true;
            this.Visible = false;

        }

        protected virtual void SaveClick(object sender, EventArgs e)
        {
         

        }
    }
}

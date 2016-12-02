using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminGUI.Forms
{
    public partial class AddNewConnection : ControlTemplete
    {
        private DomainModel.Models.ConnectionDefinition connectionDefinition;

        public AddNewConnection()
        {
            InitializeComponent();
        }

        public AddNewConnection(Size s, Panel returnP) : base(s, returnP)
        {
            InitializeComponent();
        }

        private Label Connection;
        private DateTimePicker starTimePicker;
        private Label from;
        private DateTimePicker toTimePicker;
        private Label frequency;
        private TextBox freqTextBox;
        private DateTimePicker hourTimePicker;
        private DateTimePicker minDateTimePicker;
        public AddNewConnection(Size s, Panel returnP, DomainModel.Models.ConnectionDefinition connectionDefinition) : this(s, returnP)
        {
            this.connectionDefinition = connectionDefinition;
            StringBuilder sb=new StringBuilder();
            sb.Append(connectionDefinition.Name)
                .Append(" Z:")
                .Append(connectionDefinition.Departure.Name)
                .Append("  Do:")
                .Append(connectionDefinition.Arrival.Name)
                .Append(" Cena:")
                .Append(connectionDefinition.Price)
                .Append(Environment.NewLine)
                .Append("Czas Przejazdu:")
                .Append(connectionDefinition.TravelTime);
             Connection = new Label()
            {
                Location =
                    new Point(returnButton.Location.X, returnButton.Height + Program.padding + returnButton.Location.Y),
                Size = new Size(returnButton.Width,returnButton.Height*3),
                Font = Program.DefaultFont,
                Text = sb.ToString()
            };
            Background.Controls.Add(Connection);

            

             starTimePicker = new DateTimePicker()
            {
                Location = new Point(SaveButton.Location.X , SaveButton.Location.Y+SaveButton.Height*2+Program.padding),
                MinDate = DateTime.Today,
                MaxDate = DateTime.Today.AddMonths(3),
                
            };
            Background.Controls.Add(starTimePicker);

             from = new Label()
            {
                Location =
                    new Point(starTimePicker.Location.X, -starTimePicker.Height +starTimePicker.Location.Y-Program.padding),
                Size = new Size(returnButton.Width, returnButton.Height),
                Font = Program.DefaultFont,
                Text = "Zakres dat przejazdów"
            };
           Background.Controls.Add(from);


             toTimePicker = new DateTimePicker()
            {
                Location =new Point(starTimePicker.Location.X,starTimePicker.Location.Y + starTimePicker.Height * 2),
                MinDate = DateTime.Today,
                MaxDate = DateTime.Today.AddMonths(12),
            };
            Background.Controls.Add(toTimePicker);

             frequency = new Label()
            {
                Location =
                    new Point(from.Location.X-from.Width, from.Location.Y),
                Size = new Size(returnButton.Width, returnButton.Height),
                Font = Program.DefaultFont,
                Text = "Częstotliwość w dniach"
            };
            
             freqTextBox = new TextBox()
            {
                Location =
                    new Point(from.Location.X - from.Width, starTimePicker.Location.Y),
                Size = new Size(frequency.Width-Program.padding, 40),
                Font = frequency.Font


        };
            Background.Controls.Add(freqTextBox);Background.Controls.Add(frequency);
            freqTextBox.TextChanged+=new EventHandler(TextChanged);

            Label TravelTime;
            TravelTime = new Label();
            TravelTime.Location = new Point(Program.padding+Connection.Width, SaveButton.Location.Y + 4 * SaveButton.Height);
            TravelTime.Font = Program.DefaultFont;
            TravelTime.Size = SaveButton.Size;
            TravelTime.Text = "Podaj godzinę odjazdu";
            Background.Controls.Add(TravelTime);

            hourTimePicker = new DateTimePicker();
            hourTimePicker.Format = DateTimePickerFormat.Custom;
            hourTimePicker.ShowUpDown = true;
            hourTimePicker.CustomFormat = "HH";
            hourTimePicker.Location = new Point(TravelTime.Location.X + TravelTime.Size.Width, TravelTime.Location.Y);
            hourTimePicker.Font = Program.DefaultFont;
            hourTimePicker.Size = new Size(55, 20);
            Background.Controls.Add(hourTimePicker);

            minDateTimePicker = new DateTimePicker();
            minDateTimePicker.Format = DateTimePickerFormat.Custom;
            minDateTimePicker.ShowUpDown = true;
            minDateTimePicker.CustomFormat = "mm";
            minDateTimePicker.Location = new Point(TravelTime.Location.X + TravelTime.Size.Width+60, TravelTime.Location.Y);
            minDateTimePicker.Font = Program.DefaultFont;
            minDateTimePicker.Size = new Size(55, 20);
            Background.Controls.Add(minDateTimePicker);
        }

        private int days;
        private void TextChanged(object sender, EventArgs e)
        {

            
            if (!int.TryParse(freqTextBox.Text, out days))
            {

                if (freqTextBox.Text.Length != 0)
                    freqTextBox.Text = freqTextBox.Text.Remove(freqTextBox.Text.Length - 1);
                SaveButton.Enabled = false;
                return;
            }
            SaveButton.Enabled = true;

        }

        protected override void SaveClick(object sender, EventArgs e)
        {

            base.SaveClick(sender, e);
            base.ReturnPanelClick(sender, e);
            Dispose(); 
            //ConnectionManagment cm=new ConnectionManagment();
            //cm.AddNewConnections(connectionDefinition, starTimePicker.Value, toTimePicker.Value, days,hourTimePicker.Value.Hour,minDateTimePicker.Value.Minute);
        }

        protected override void ReturnPanelClick(object sender, EventArgs e)
        {
            base.ReturnPanelClick(sender, e);
            Dispose();
        }
    }
}

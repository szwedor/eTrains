using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminGUI.Forms
{
    public partial class AddNewConnection : ControlTemplete
    {
        private DomainModel.Models.ConnectionDefinition _connectionDefinition;

        public AddNewConnection()
        {
            InitializeComponent();
        }

        public AddNewConnection(Size s, Panel returnP) : base(s, returnP)
        {
            InitializeComponent();
        }

        private Label _connection;
        private DateTimePicker _starTimePicker;
        private Label _from;
        private DateTimePicker _toTimePicker;
        private Label _frequency;
        private TextBox _freqTextBox;
        private DateTimePicker _hourTimePicker;
        private DateTimePicker _minDateTimePicker;
        public AddNewConnection(Size s, Panel returnP, DomainModel.Models.ConnectionDefinition connectionDefinition) : this(s, returnP)
        {
            this._connectionDefinition = connectionDefinition;
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
             _connection = new Label()
            {
                Location =
                    new Point(ReturnButton.Location.X, ReturnButton.Height + Program.Padding + ReturnButton.Location.Y),
                Size = new Size(ReturnButton.Width,ReturnButton.Height*3),
                Font = Program.DefaultFont,
                Text = sb.ToString()
            };
            Background.Controls.Add(_connection);

            

             _starTimePicker = new DateTimePicker()
            {
                Location = new Point(SaveButton.Location.X , SaveButton.Location.Y+SaveButton.Height*2+Program.Padding),
                MinDate = DateTime.Today,
                MaxDate = DateTime.Today.AddMonths(3),
                
            };
            Background.Controls.Add(_starTimePicker);

             _from = new Label()
            {
                Location =
                    new Point(_starTimePicker.Location.X, -_starTimePicker.Height +_starTimePicker.Location.Y-Program.Padding),
                Size = new Size(ReturnButton.Width, ReturnButton.Height),
                Font = Program.DefaultFont,
                Text = "Zakres dat przejazdów"
            };
           Background.Controls.Add(_from);


             _toTimePicker = new DateTimePicker()
            {
                Location =new Point(_starTimePicker.Location.X,_starTimePicker.Location.Y + _starTimePicker.Height * 2),
                MinDate = DateTime.Today,
                MaxDate = DateTime.Today.AddMonths(12),
            };
            Background.Controls.Add(_toTimePicker);

             _frequency = new Label()
            {
                Location =
                    new Point(_from.Location.X-_from.Width, _from.Location.Y),
                Size = new Size(ReturnButton.Width, ReturnButton.Height),
                Font = Program.DefaultFont,
                Text = "Częstotliwość w dniach"
            };
            
             _freqTextBox = new TextBox()
            {
                Location =
                    new Point(_from.Location.X - _from.Width, _starTimePicker.Location.Y),
                Size = new Size(_frequency.Width-Program.Padding, 40),
                Font = _frequency.Font


        };
            Background.Controls.Add(_freqTextBox);Background.Controls.Add(_frequency);
            _freqTextBox.TextChanged+=new EventHandler(TextChanged);

            Label travelTime;
            travelTime = new Label();
            travelTime.Location = new Point(Program.Padding+_connection.Width, SaveButton.Location.Y + 4 * SaveButton.Height);
            travelTime.Font = Program.DefaultFont;
            travelTime.Size = SaveButton.Size;
            travelTime.Text = "Podaj godzinę odjazdu";
            Background.Controls.Add(travelTime);

            _hourTimePicker = new DateTimePicker();
            _hourTimePicker.Format = DateTimePickerFormat.Custom;
            _hourTimePicker.ShowUpDown = true;
            _hourTimePicker.CustomFormat = "HH";
            _hourTimePicker.Location = new Point(travelTime.Location.X + travelTime.Size.Width, travelTime.Location.Y);
            _hourTimePicker.Font = Program.DefaultFont;
            _hourTimePicker.Size = new Size(55, 20);
            Background.Controls.Add(_hourTimePicker);

            _minDateTimePicker = new DateTimePicker();
            _minDateTimePicker.Format = DateTimePickerFormat.Custom;
            _minDateTimePicker.ShowUpDown = true;
            _minDateTimePicker.CustomFormat = "mm";
            _minDateTimePicker.Location = new Point(travelTime.Location.X + travelTime.Size.Width+60, travelTime.Location.Y);
            _minDateTimePicker.Font = Program.DefaultFont;
            _minDateTimePicker.Size = new Size(55, 20);
            Background.Controls.Add(_minDateTimePicker);
        }

        private int _days;
        private void TextChanged(object sender, EventArgs e)
        {

            
            if (!int.TryParse(_freqTextBox.Text, out _days))
            {

                if (_freqTextBox.Text.Length != 0)
                    _freqTextBox.Text = _freqTextBox.Text.Remove(_freqTextBox.Text.Length - 1);
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
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

        public AddNewConnection(Size s, Panel returnP, Admin.AdminClient ac, Task<List<DomainModel.Models.Station>> l) : base(s, returnP,ac,l)
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
        public AddNewConnection(Size s, Panel returnP, DomainModel.Models.ConnectionDefinition connectionDefinition, Admin.AdminClient ac, Task<List<DomainModel.Models.Station>> l) : this(s, returnP,ac,l)
        {
            this._connectionDefinition = connectionDefinition;
            StringBuilder sb=new StringBuilder();
            sb.Append(connectionDefinition.Name)
                .Append(Environment.NewLine)
                .Append("Z:")
                .Append(Environment.NewLine)
                .Append(connectionDefinition.Departure.Name)
                .Append(Environment.NewLine)
                .Append("Do:")
                .Append(Environment.NewLine)
                .Append(connectionDefinition.Arrival.Name)
                .Append(Environment.NewLine)
                .Append("Cena:")
                .Append(Environment.NewLine)
                .Append(connectionDefinition.Price)
                .Append(Environment.NewLine)
                .Append("Czas Przejazdu:")
                .Append(Environment.NewLine)
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
                 Location = new Point(SaveButton.Location.X, SaveButton.Location.Y + SaveButton.Height + Program.Padding),
                 MinDate = DateTime.Today,
                 MaxDate = DateTime.Today.AddMonths(3),

             };
            Background.Controls.Add(_starTimePicker);



            _toTimePicker = new DateTimePicker()
            {
                Location = new Point(_starTimePicker.Location.X, _starTimePicker.Location.Y + _starTimePicker.Height + Program.Padding),
                MinDate = DateTime.Today,
                MaxDate = DateTime.Today.AddMonths(12),
            };
            Background.Controls.Add(_toTimePicker);
            _from = new Label()
            {
                Location = new Point(_starTimePicker.Location.X, _toTimePicker.Location.Y + _toTimePicker.Height + Program.Padding),
                Size = new Size(_starTimePicker.Width - Program.Padding, 60),
                Font = Program.DefaultFont,
                Text = "Zakres dat przejazdów"

            };
            Background.Controls.Add(_from);

             _freqTextBox = new TextBox()
            {
                Location =
                    new Point(_from.Location.X , _from.Location.Y+_from.Height+Program.Padding),
                Size = new Size(_from.Width-Program.Padding, 40),
                Font = Program.DefaultFont


        };
            _frequency = new Label()
            {
                Location =
                    new Point(_freqTextBox.Location.X, _freqTextBox.Location.Y+_freqTextBox.Height+Program.Padding),
                Size = new Size(ReturnButton.Width, ReturnButton.Height),
                Font = Program.DefaultFont,
                Text = "Częstotliwość w dniach"
            };
            
            Background.Controls.Add(_freqTextBox); Background.Controls.Add(_frequency);
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
            _minDateTimePicker.Location = new Point(travelTime.Location.X + travelTime.Size.Width + 60, travelTime.Location.Y);
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
            
            AC.AddNewConnectionsAsync(_connectionDefinition, _starTimePicker.Value, _toTimePicker.Value, _days, _hourTimePicker.Value.Hour, _minDateTimePicker.Value.Minute);
        }

        protected override void ReturnPanelClick(object sender, EventArgs e)
        {
            base.ReturnPanelClick(sender, e);
            Dispose();
        }
    }
}

using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormToDetails : Form
    {
        public Form1 oldform;
        public FormToDetails(Form1 f)
        {
            oldform = f;
            InitializeComponent();
            DetailsView();
        }
        public void DetailsView()
        {
            var listofticekets = oldform.connectiontodetails;
            if (listofticekets == null)
            {
                MessageBox.Show("Nie ma połączenia do wyświetlenia szczegółów");
                return;
            }
            dataGridView.Rows.Clear();
            for(int i=0;i<listofticekets.Count;i++)
           // foreach (var elem in listofticekets)
            {
                var elem = listofticekets[listofticekets.Count-1-i];
            var x = new DataGridViewRow();
                x.Tag = elem;

                dataGridView.Rows.Add(x);
                dataGridView.Rows[i].Cells[0].Value = elem.ConnectionDefinition.Departure.Name;
                dataGridView.Rows[i].Cells[1].Value = elem.ConnectionDefinition.Arrival.Name;
                dataGridView.Rows[i].Cells[2].Value = elem.DepartureTime;
                dataGridView.Rows[i].Cells[3].Value = elem.ArrivalTime;
                dataGridView.Rows[i].Cells[4].Value = elem.ConnectionDefinition.Price;
               
            }
        }

        
    }
}

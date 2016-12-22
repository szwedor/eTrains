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
    public partial class ConnectionDefinitionWindow : Form
    {
        UserAccount ua;
        public ConnectionDefinitionWindow(UserAccount _ua)
        {
            InitializeComponent();
            ua = _ua;
            DetailsView();
        }
           
                
        public void DetailsView()
        {
            var listofticekets = ua.choosedtodetails;
            if(listofticekets==null)
            {
                MessageBox.Show("Nie ma połączenia do wyświetlenia szczegółów");
                return;
            }
            dataGridView.Rows.Clear();
            var x = new DataGridViewRow();
            int i = 0;
            foreach (var elem in listofticekets)
            {
                x.Tag = elem;
              
                dataGridView.Rows.Add(x);
                dataGridView.Rows[i].Cells[0].Value = elem.ConnectionDefinition.Departure.Name;
                dataGridView.Rows[i].Cells[1].Value = elem.ConnectionDefinition.Arrival.Name;
                dataGridView.Rows[i].Cells[2].Value = elem.DepartureTime;
                dataGridView.Rows[i].Cells[3].Value = elem.ArrivalTime;
                dataGridView.Rows[i].Cells[4].Value = elem.ConnectionDefinition.Price;
                dataGridView.Rows[i].Cells[5].Value = 5;
                
                
            }
        }
    


    }
}

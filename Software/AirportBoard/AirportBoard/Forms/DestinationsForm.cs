using AirportBoard.Logging;
using AirportBoard.Models;
using AirportBoard.Services;
using AirportBoard.Services.ComboBoxTools;
using AirportBoard.Services.GridTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportBoard.Forms
{
    public partial class DestinationsForm : Form
    {
        DestinationService destinationService = new DestinationService();
        Dictionary<string, string> values = new Dictionary<string, string>();

        public DestinationsForm()
        {
            InitializeComponent();
        }

        private void DestinationsForm_Load(object sender, EventArgs e)
        {
            destinationsLoadData();
            loadCities();

            destinationsGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(destinationsGridView_RowStateChanged);
        }

        private void addDestination_Click(object sender, EventArgs e)
        {
            try
            {
                string airport = airportNameTextBox.Text;
                string cityId = (destinationCityComboBox.SelectedItem as ComboBoxItem).Value.ToString(); // Get selected country id

                values.Clear();
                values.Add("airport", airport);
                values.Add("cityId", cityId);

                destinationService.setFields(values);
                destinationService.save();
                destinationsLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void updateDestination_Click(object sender, EventArgs e)
        {
            try
            {
                string airport = airportNameTextBox.Text;
                string cityId = (destinationCityComboBox.SelectedItem as ComboBoxItem).Value.ToString();

                values.Add("airport", airport);
                values.Add("cityId", cityId);

                destinationService.setFields(values);
                destinationService.update();
                destinationsLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void deleteDestination_Click(object sender, EventArgs e)
        {
            try
            {
                destinationService.setFields(values);
                destinationService.delete();
                destinationsLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void destinationsGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(destinationsGridView))
            {
                var row = destinationsGridView.SelectedRows[0];

                values.Clear();
                string id = Convert.ToString(row.Cells["destinationId"].Value);
                values.Add("id", id);

                airportNameTextBox.Text = Convert.ToString(row.Cells["destinationAirport"].Value);

                string city = Convert.ToString(row.Cells["destinationCityId"].Value);
                setSelectedCity(city);
                //Set comboBox item with this country to be selected
            }
        }

        private void destinationsLoadData()
        {
            Table.loadData(destinationsGridView, new Destination());
        }

        private void loadCities()
        {
            List<List<string>> rows = (new City()).getAll();

            foreach (List<string> row in rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = row[1]; // City name
                item.Value = row[0]; // City ID
                destinationCityComboBox.Items.Add(item);
            }

            destinationCityComboBox.SelectedIndex = 0;
        }

        private void setSelectedCity(string city)
        {
            string text;
            for (int i = 0; i < destinationCityComboBox.Items.Count; i++)
            {
                text = (destinationCityComboBox.Items[i] as ComboBoxItem).Value.ToString();
                if (city == text)
                {
                    destinationCityComboBox.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}

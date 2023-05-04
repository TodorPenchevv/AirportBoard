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
    public partial class AirlinesForm : Form
    {
        AirlineService airlineService = new AirlineService();
        Dictionary<string, string> values = new Dictionary<string, string>();

        public AirlinesForm()
        {
            InitializeComponent();
        }

        private void AirlinesForm_Load(object sender, EventArgs e)
        {
            airlinesLoadData();
            loadCountries();

            airlinesGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(airlinesGridView_RowStateChanged);
        }

        private void addAirline_Click(object sender, EventArgs e)
        {
            try
            {
                string airline = airlineTextBox.Text;
                string countryId = (airlineCountryComboBox.SelectedItem as ComboBoxItem).Value.ToString(); // Get selected country id

                values.Clear();
                values.Add("name", airline);
                values.Add("countryId", countryId);

                airlineService.setFields(values);
                airlineService.save();
                airlinesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void updateAirline_Click(object sender, EventArgs e)
        {
            try
            {
                string city = airlineTextBox.Text;
                string countryId = (airlineCountryComboBox.SelectedItem as ComboBoxItem).Value.ToString();

                values.Add("name", city);
                values.Add("countryId", countryId);

                airlineService.setFields(values);
                airlineService.update();
                airlinesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void deleteAirline_Click(object sender, EventArgs e)
        {
            try
            {
                airlineService.setFields(values);
                airlineService.delete();
                airlinesLoadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void airlinesGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(airlinesGridView))
            {
                var row = airlinesGridView.SelectedRows[0];

                values.Clear();
                string id = Convert.ToString(row.Cells["airlineId"].Value);
                values.Add("id", id);

                airlineTextBox.Text = Convert.ToString(row.Cells["airlineName"].Value);

                string country = Convert.ToString(row.Cells["airlineCountryId"].Value);
                setSelectedCountry(country);
                //Set comboBox item with this country to be selected
            }
        }

        private void airlinesLoadData()
        {
            Table.loadData(airlinesGridView, new Airline());
        }

        private void loadCountries()
        {
            List<List<string>> rows = (new Country()).getAll();

            foreach (List<string> row in rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = row[1]; // Country name
                item.Value = row[0]; // Country ID
                airlineCountryComboBox.Items.Add(item);
            }

            airlineCountryComboBox.SelectedIndex = 0;
        }

        private void setSelectedCountry(string country)
        {
            string text;
            for (int i = 0; i < airlineCountryComboBox.Items.Count; i++)
            {
                text = (airlineCountryComboBox.Items[i] as ComboBoxItem).Value.ToString();
                if (country == text)
                {
                    airlineCountryComboBox.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}

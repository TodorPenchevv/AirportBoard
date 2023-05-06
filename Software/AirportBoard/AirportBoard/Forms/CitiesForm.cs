using AirportBoard.Logging;
using AirportBoard.Models;
using AirportBoard.Services;
using AirportBoard.Services.ComboBoxTools;
using AirportBoard.Services.GridTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirportBoard.Forms
{
    public partial class CitiesForm : Form
    {
        CityService cityService = new CityService();
        Dictionary<string, string> values = new Dictionary<string, string>();

        public CitiesForm()
        {
            InitializeComponent();
        }

        private void CitiesForm_Load(object sender, EventArgs e)
        {
            loadCitiesData();
            loadCountries();

            citiesGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(citiesGridView_RowStateChanged);
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            try
            {
                values.Clear();
                getFieldValues();
                cityService.setFields(values);
                cityService.save();
                loadCitiesData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void updateCity_Click(object sender, EventArgs e)
        {
            try
            {
                getFieldValues();
                cityService.setFields(values);
                cityService.update();
                loadCitiesData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void getFieldValues()
        {
            string city = cityNameTextBox.Text;
            string countryId = (cityCountryComboBox.SelectedItem as ComboBoxItem).Value.ToString();

            values.Add("name", city);
            values.Add("countryId", countryId);
        }

        private void deleteCity_Click(object sender, EventArgs e)
        {
            try
            {
                cityService.setFields(values);
                cityService.delete();
                loadCitiesData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void citiesGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(citiesGridView))
            {
                var row = citiesGridView.SelectedRows[0];

                values.Clear();
                string id = Convert.ToString(row.Cells["cityId"].Value);
                values.Add("id", id);

                cityNameTextBox.Text = Convert.ToString(row.Cells["cityName"].Value);

                string country = Convert.ToString(row.Cells["cityCountryId"].Value);
                SelectedItem.set(cityCountryComboBox, country);
            }
        }

        private void loadCitiesData()
        {
            Table.loadData(citiesGridView, new City());
        }

        private void loadCountries()
        {
            List<List<string>> rows = (new Country()).getAll();

            foreach (List<string> row in rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = row[1]; // Country name
                item.Value = row[0]; // Country ID
                cityCountryComboBox.Items.Add(item);
            }

            cityCountryComboBox.SelectedIndex = 0;
        }
    }
}

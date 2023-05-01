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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirportBoard.Forms
{
    public partial class CitiesForm : Form
    {
        CityService cityService = new CityService();

        public CitiesForm()
        {
            InitializeComponent();
        }

        private void CitiesForm_Load(object sender, EventArgs e)
        {
            loadData();

            //Load Countries List
            ComboBoxItem item = new ComboBoxItem();
            item.Text = "Germany"; // Country name
            item.Value = 1; // Country ID
            cityCountryComboBox.Items.Add(item);

            cityCountryComboBox.SelectedIndex = 0;

            citiesGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(citiesGridView_RowStateChanged);
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            string city = cityNameTextBox.Text;
            string countryId = (cityCountryComboBox.SelectedItem as ComboBoxItem).Value.ToString(); // Get selected country id

            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("city", city);
            values.Add("countryId", countryId);

            cityService.save();
        }

        private void updateCity_Click(object sender, EventArgs e)
        {
            cityService.update();
        }

        private void deleteCity_Click(object sender, EventArgs e)
        {
            cityService.delete();
        }
        private void citiesGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(citiesGridView))
            {
                var row = citiesGridView.SelectedRows[0];

                string id = Convert.ToString(row.Cells["cityIdColumn"].Value);
                string city = Convert.ToString(row.Cells["cityNameColumn"].Value);
                string country = Convert.ToString(row.Cells["cityCountryColumn"].Value);

                cityNameTextBox.Text = city;

                Dictionary<string, string> values = new Dictionary<string, string>();
                values.Add("id", id);
                values.Add("name", city);
                values.Add("countryId", city);

                cityService.setFields(values);
            }
        }

        private void loadData()
        {
            Table.loadData(citiesGridView, new City());
        }
    }
}

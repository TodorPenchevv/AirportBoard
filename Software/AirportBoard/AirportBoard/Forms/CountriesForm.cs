using AirportBoard.Models;
using AirportBoard.Services;
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
    public partial class CountriesForm : Form
    {
        CountryService countryService = new CountryService();

        public CountriesForm()
        {
            InitializeComponent();
        }

        private void CountriesForm_Load(object sender, EventArgs e)
        {
            loadData();

            countriesGridView.RowStateChanged += new DataGridViewRowStateChangedEventHandler(countriesGridView_RowStateChanged);
        }

        private void addCountry_Click(object sender, EventArgs e)
        {
            string country = countryTextBox.Text;

            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("name", country);

            countryService.setFields(values);
            countryService.save();
            loadData();
        }

        private void updateCountry_Click(object sender, EventArgs e)
        {
            countryService.update();
            loadData();
        }

        private void deleteCountry_Click(object sender, EventArgs e)
        {
            countryService.delete();
            loadData();
        }

        private void countriesGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(countriesGridView))
            {
                var row = countriesGridView.SelectedRows[0];

                string id = Convert.ToString(row.Cells["countryIdColumn"].Value);
                string country = Convert.ToString(row.Cells["countryNameColumn"].Value);

                countryTextBox.Text = country;

                Dictionary<string, string> values = new Dictionary<string, string>();
                values.Add("id", id);
                values.Add("name", country);

                countryService.setFields(values);
            }
        }

        private void loadData()
        {
            Table.loadData(countriesGridView, new Country());
        }
    }
}

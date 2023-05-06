using AirportBoard.Logging;
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
        Dictionary<string, string> values = new Dictionary<string, string>();

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
            try
            {
                values.Clear();
                getFieldValues();
                countryService.setFields(values);
                countryService.save();
                loadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void updateCountry_Click(object sender, EventArgs e)
        {
            try
            {
                getFieldValues();
                countryService.setFields(values);
                countryService.update();
                loadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void getFieldValues()
        {
            string country = countryTextBox.Text;

            values.Add("name", country);
        }

        private void deleteCountry_Click(object sender, EventArgs e)
        {
            try
            {
                countryService.setFields(values);
                countryService.delete();
                loadData();
            }
            catch (Exception exception)
            {
                Notification.show("Error", exception.Message);
            }
        }

        private void countriesGridView_RowStateChanged(object sender, EventArgs e)
        {
            if (Row.isSelected(countriesGridView))
            {
                var row = countriesGridView.SelectedRows[0];

                values.Clear();
                string id = Convert.ToString(row.Cells["countryId"].Value);
                values.Add("id", id);

                countryTextBox.Text = Convert.ToString(row.Cells["countryName"].Value);
            }
        }

        private void loadData()
        {
            Table.loadData(countriesGridView, new Country());
        }
    }
}

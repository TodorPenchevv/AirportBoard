using AirportBoard.Services;
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

        private void addCountry_Click(object sender, EventArgs e)
        {
            countryService.save();
        }

        private void updateCountry_Click(object sender, EventArgs e)
        {
            countryService.update();
        }

        private void deleteCountry_Click(object sender, EventArgs e)
        {
            countryService.delete();
        }
    }
}

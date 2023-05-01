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
    public partial class CitiesForm : Form
    {
        CityService cityService = new CityService();

        public CitiesForm()
        {
            InitializeComponent();
        }

        private void addCity_Click(object sender, EventArgs e)
        {
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
    }
}

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
    public partial class FlightsForm : Form
    {
        FlightService flightService = new FlightService();

        public FlightsForm()
        {
            InitializeComponent();
        }
        private void addFlight_Click(object sender, EventArgs e)
        {
            flightService.save();
        }

        private void updateFlight_Click(object sender, EventArgs e)
        {
            flightService.update();
        }

        private void deleteFlight_Click(object sender, EventArgs e)
        {
            flightService.delete();
        }

    }
}

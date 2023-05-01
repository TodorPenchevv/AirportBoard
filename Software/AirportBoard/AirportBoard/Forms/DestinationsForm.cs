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
    public partial class DestinationsForm : Form
    {
        DestinationService destinationService = new DestinationService();

        public DestinationsForm()
        {
            InitializeComponent();
        }

        private void addDestination_Click(object sender, EventArgs e)
        {
            destinationService.save();
        }

        private void updateDestination_Click(object sender, EventArgs e)
        {
            destinationService.update();
        }

        private void deleteDestination_Click(object sender, EventArgs e)
        {
            destinationService.delete();
        }
    }
}

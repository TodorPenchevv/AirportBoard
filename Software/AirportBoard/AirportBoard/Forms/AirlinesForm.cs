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
    public partial class AirlinesForm : Form
    {
        AirlineService airlineService = new AirlineService();

        public AirlinesForm()
        {
            InitializeComponent();
        }

        private void addAirline_Click(object sender, EventArgs e)
        {
            airlineService.save();
        }

        private void updateAirline_Click(object sender, EventArgs e)
        {
            airlineService.update();
        }

        private void deleteAirline_Click(object sender, EventArgs e)
        {
            airlineService.delete();
        }
    }
}

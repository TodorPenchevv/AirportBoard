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
    public partial class GatesForm : Form
    {
        GateService gateService = new GateService();

        public GatesForm()
        {
            InitializeComponent();
        }

        private void addGate_Click(object sender, EventArgs e)
        {
            gateService.save();
        }

        private void updateGate_Click(object sender, EventArgs e)
        {
            gateService.update();
        }

        private void deleteGate_Click(object sender, EventArgs e)
        {
            gateService.delete();
        }
    }
}

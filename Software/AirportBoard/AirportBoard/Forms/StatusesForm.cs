using AirportBoard.Models;
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
    public partial class StatusesForm : Form
    {
        public StatusesForm()
        {
            InitializeComponent();
        }

        private void addStatus_Click(object sender, EventArgs e)
        {
            FlightStatus status = new FlightStatus();
            status.setStatus("boarding");
            status.save();
        }

        private void updateStatus_Click(object sender, EventArgs e)
        {
            FlightStatus status = new FlightStatus();
            status.setId("1");
            status.setStatus("Boarding");
            status.update();
        }

        private void deleteStatus_Click(object sender, EventArgs e)
        {
            FlightStatus status = new FlightStatus();
            status.setId("1");
            status.delete();
        }
    }
}

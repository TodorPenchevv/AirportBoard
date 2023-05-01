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
    public partial class StatusesForm : Form
    {
        StatusService statusService = new StatusService();

        public StatusesForm()
        {
            InitializeComponent();
        }

        private void addStatus_Click(object sender, EventArgs e)
        {
            statusService.save();
        }

        private void updateStatus_Click(object sender, EventArgs e)
        {
            statusService.update();
        }

        private void deleteStatus_Click(object sender, EventArgs e)
        {
            statusService.delete();
        }
    }
}

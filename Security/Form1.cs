using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        public fMain(string role, string username)
        {
            InitializeComponent();
            pMenu.BackColor = Color.FromArgb(172, 204, 196);
            pMenu.ForeColor = Color.FromArgb(255, 255, 255);
            pMenuBottom.BackColor = Color.FromArgb(172, 204, 196);
            pMenuBottom.ForeColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(245, 245, 245);
            lRole.Text += $" {role}";
            lLog.Text += $" {username}";
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            fService service = new fService();
            service.ShowDialog();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            fClients clients = new fClients();
            clients.ShowDialog();
        }

        private void workerBtn_Click(object sender, EventArgs e)
        {
            fWorkers workers = new fWorkers();
            workers.ShowDialog();
        }

        private void contrantsBtn_Click(object sender, EventArgs e)
        {
            fContracts contracts = new fContracts();
            contracts.ShowDialog();
        }

        private void brigadeBtn_Click(object sender, EventArgs e)
        {
            fBrigade brigade = new fBrigade();
            brigade.ShowDialog();
        }
    }
}

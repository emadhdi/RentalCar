using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp38
{
    public partial class Session_Agent : Form
    {
        public Session_Agent()
        {
            InitializeComponent();
        }

        private void FlotteBtn_Click(object sender, EventArgs e)
        {
            FlotteForm flotteForm1 = new FlotteForm();
            flotteForm1.ShowDialog();
        }

        private void ReserverBtn_Click(object sender, EventArgs e)
        {
            Reservation Reservation1 = new Reservation();
            Reservation1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintenanceForm Maintenance1 = new MaintenanceForm();
            Maintenance1.ShowDialog();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm Client1 = new ClientForm();
            Client1.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

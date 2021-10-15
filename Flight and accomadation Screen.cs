using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmflights : Form
    {
        public frmflights()
        {
            InitializeComponent();
            radInternational.Checked = true;
            radLocal.Checked = true;
            radroundtrip.Checked = true;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbArrivaldestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radInternational_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radInternational_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radLocal.Checked)
            {
                cmbDestinatiom.Enabled = false;
                cmbArrivaldestination.Enabled = false;
            }
            else
            {
                cmbDestinatiom.Enabled = true;
                cmbArrivaldestination.Enabled = true;
            }
        }

        private void radLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (radInternational.Checked)
            {
                comboxDepartCity.Enabled = false;
                comboxArrivalCity.Enabled = false;
            }
            else
            {
                comboxDepartCity.Enabled = true;
                comboxArrivalCity.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbDestinatiom.Text = string.Empty;
            cmbArrivaldestination.Text = string.Empty;
            comboxDepartCity.Text = string.Empty;
            comboxArrivalCity.Text = string.Empty;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
            
               
            
        }

        private void radroundtrip_CheckedChanged(object sender, EventArgs e)
        {
            if (radLocal.Checked)
            {
                radLocal.Enabled = false;
                comboxDepartCity.Enabled = false;
                comboxArrivalCity.Enabled = false;
               
            }
            else
            {
                radLocal.Enabled = true;
                comboxDepartCity.Enabled = true;
                comboxArrivalCity.Enabled = true;
            }
        }

        private void txtTotalParticipants_TextChanged(object sender, EventArgs e)
        {
            decimal totalParticipants;
            totalParticipants = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value;
            lblTotalParcipants.Text = totalParticipants.ToString();
        }
    }
}

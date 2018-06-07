using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSLVortex
{
    public partial class Form2 : Form
    {
        Object sender;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(GroupBox grp in groupBox2.Controls)
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYear.Checked)
            {
                grpYear.Enabled = true;
                grpYear.Visible = true;
            }
            else
            {
                grpYear.Enabled = false;
                grpYear.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDate.Checked)
            {
                grpDate.Enabled = true;
                grpDate.Visible = true;
            }
            else
            {
                grpDate.Enabled = false;
                grpDate.Visible = false;
            }
        }

        private void rdoMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMonth.Checked)
            {
                grpMonth.Enabled = true;
                grpMonth.Visible = true;
            }
            else
            {
                grpMonth.Enabled = false;
                grpMonth.Visible = false;
            }
        }

        private void rdoWebsite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWebsite.Checked)
            {
                grpWebsite.Enabled = true;
                grpWebsite.Visible = true;
            }
            else
            {
                grpWebsite.Enabled = false;
                grpWebsite.Visible = false;
            }
        }

        private void rdoSID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSID.Checked)
            {
                grpSession.Enabled = true;
                grpSession.Visible = true;
            }
            else
            {
                grpSession.Enabled = false;
                grpSession.Visible = false;
            }
        }
    }
}

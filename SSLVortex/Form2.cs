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
        SQLDB conn = new SQLDB();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rdoDate.Checked = true;
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

        private void btnDateGo_Click(object sender, EventArgs e)
        {
            String strt = dtpSDate.Value.ToString("MM-dd-yyyy");
            String end = dtpEDate.Value.AddDays(1).ToString("MM-dd-yyyy");

            string query = "SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody FROM SessionDB S1,StorageDB S2 WHERE S1.SessionID = S2.SessionID AND s1.StartTS >= '" + strt + "' AND s1.EndTS < '" + end + "';";

            conn.dataGridFill(query, dataGridView1, "sessiondb,storagedb");

            dtpSDate.Value = DateTime.Now;
            dtpEDate.Value = DateTime.Now;
        }

        private void btnMonthGo_Click(object sender, EventArgs e)
        {
            String sMnth = dtpMonth.Value.ToString("MMMM yyyy");
            String eMnth = dtpMonth.Value.AddMonths(1).ToString("MMMM yyyy");

            string query = "SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody FROM SessionDB S1,StorageDB S2 WHERE S1.SessionID = S2.SessionID AND s1.StartTS >= '" + sMnth + "' AND s1.StartTS < '" + eMnth + "';";

            conn.dataGridFill(query, dataGridView1, "sessiondb,storagedb");
            dtpMonth.Value = DateTime.Now;
        }

        private void btnYearGo_Click(object sender, EventArgs e)
        {
            String sYr = dtpYear.Value.ToString("yyyy");
            String eYr = dtpYear.Value.AddYears(1).ToString("yyyy");

            string query = "SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody FROM SessionDB S1,StorageDB S2 WHERE S1.SessionID = S2.SessionID AND s1.StartTS >= '" + sYr + "' AND s1.StartTS < '" + eYr + "';";

            conn.dataGridFill(query, dataGridView1, "sessiondb,storagedb");
            dtpMonth.Value = DateTime.Now;
        }

        private void btnSessionGo_Click(object sender, EventArgs e)
        {
            try
            {
                String sID = txtSession.Text;

                if (sID == "")
                {
                    throw new Exception("Enter the Session ID");
                }

                string query = "SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody FROM SessionDB S1,StorageDB S2 WHERE S1.SessionID = S2.SessionID AND S1.SessionID = " + sID + ";";

                conn.dataGridFill(query, dataGridView1, "sessiondb,storagedb");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWebsiteGo_Click(object sender, EventArgs e)
        {
            try
            {
                String website = txtWebsite.Text;

                if (website == "")
                {
                    throw new Exception("Enter the website");
                }

                string query = "SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody FROM SessionDB S1,StorageDB S2 WHERE S1.SessionID = S2.SessionID AND S2.ReqLines LIKE '%" + website + "%'; ";

                conn.dataGridFill(query, dataGridView1, "sessiondb,storagedb");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }
            else
            {
                Form3 frm = new Form3();

                frm.req = new Request(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                frm.res = new Response(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), dataGridView1.SelectedRows[0].Cells[5].Value.ToString(), dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                frm.ShowDialog();
            }
        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace SSLVortex
{
    public partial class frmMain : Form
    {
        bool activated = false;
        public bool runninng = false;
        public static Int32 port;
        SQLDB conn = new SQLDB();
        public int sID = 0;
        private int LastInd = 0;
        private DateTime sTime = DateTime.Now;

        public frmMain()
        {
            InitializeComponent();
            ProxyServer.Server.DumpHeaders = true;
            ProxyServer.Server.DumpResponseData = true;
            ProxyServer.Server.DumpPostData = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                activated = (activated == true) ? false : true;
                if (!activated)
                {
                    btnGo.Text = "Start Proxy";
                    txtHost.Enabled = true;
                    timer1.Stop();
                    if (runninng)
                        ProxyServer.Server.Stop();
                    label2.Text = "Proxy Server Stopped";
                }
                else
                {
                    btnGo.Text = "Stop Proxy";
                    txtHost.Enabled = false;
                    timer1.Start();
                    try
                    {
                        Int32.TryParse(txtHost.Text.Trim(), out port);
                        //ProxyServer.Server.ListeningPort = port;
                        runninng = ProxyServer.Server.Start();
                        if (runninng)
                            label2.Text = (String.Format("Proxy server started on {0}:{1}", ProxyServer.Server.ListeningIPInterface, ProxyServer.Server.ListeningPort));
                        else
                            btnGo_Click(sender, e);
                        textBox3.Text = printcertificate(ProxyServer.Server.GetCertificate2());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private string printcertificate(X509Certificate2 x509Certificate2)
        {
            string str = "";
            str += "Version : V" + x509Certificate2.Version;
            str += "\r\nSerial : " + x509Certificate2.GetSerialNumberString();
            str += "\r\nSignature Algorithm : " + x509Certificate2.SignatureAlgorithm.FriendlyName;
            //str += "\r\nSignature Hash: " + x509Certificate2.GetCertHashString();
            str += "\r\nIssuer : " + x509Certificate2.Issuer;
            str += "\r\nBegins On : " + x509Certificate2.NotBefore.ToString("dddd, MMMMdd,yyyy h:m:sstt");
            str += "\r\nExpires On : " + x509Certificate2.NotAfter.ToString("dddd, MMMMdd,yyyy h:m:sstt");
            str += "\r\nSubject : " + x509Certificate2.SubjectName.Name;
            //str += "\r\nPublic Key : " + BitConverter.ToString(x509Certificate2.PublicKey.EncodedKeyValue.RawData);
            str += "\r\nPublic Key : " + x509Certificate2.PublicKey.EncodedKeyValue.Oid.FriendlyName + " (" + x509Certificate2.PublicKey.Key.KeySize + " bits)";
            str += "\r\nPublic Key Parameters : " + x509Certificate2.GetKeyAlgorithmParametersString();
            //str += "\r\nKey Usage : " + x509Certificate2.Extensions[0].Oid.Value;
            //str += "\r\nEnhanced Key Usage : " + x509Certificate2.SignatureAlgorithm;
            //str += "\r\nSubject Alternative Name : " + x509Certificate2.alter;
            str += "\r\nThumbprint : " + x509Certificate2.Thumbprint;
            return str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            sID = conn.GetLastID();
            sTime = DateTime.Now;

            string query = "INSERT INTO SESSIONDB VALUES(" + sID + ",'" + sTime + "','" + DateTime.Now + "'," + 0 + ");";
            conn.runNonQuery(query);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label3.Text = Storage.getreqlen().ToString();
            label4.Text = Storage.getreslen().ToString();

            int len = Storage.getlen();
            for (int i = 0; i < len; i++)
            {
                ListViewItem item = new ListViewItem();
                try
                {
                    item.SubItems.Clear();
                    item.SubItems.Add(Storage.getrequest(i).parseHost()[1].Split(':')[0].ToUpper());
                    String str = Storage.getrequest(i).parseHost()[1].Split(':')[1].Split('/')[2];
                    item.SubItems.Add(str);
                    item.SubItems.Add(Storage.getrequest(i).parseHost()[1]);
                    listView1.Items.Add(item);
                }
                catch (Exception ex)
                {
                    //To the log
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Storage.getrequest(listView1.FocusedItem.Index).ToString();
            textBox2.Text = Storage.getresponse(listView1.FocusedItem.Index).ToString();
        }
        private void changeHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (runninng)
                ProxyServer.Server.Stop();

            string query = "UPDATE SESSIONDB SET ENDTS = '" + DateTime.Now + "', SCOUNT = " + LastInd + " WHERE SESSIONID = " + sID + ";";
            Console.WriteLine(query);
            conn.runNonQuery(query);

        }
        private void SaveSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Do you want to save the session data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SQLDB conn = new SQLDB();
                conn.connect();
                //Request req = new Request("h", "a", "l");
                //Response res = new Response("y", "a", "l");
                int len = Storage.getlen();

                string query = "INSERT INTO STORAGEDB VALUES";

                for (int i = LastInd; i < len; i++)
                {
                    query += "(" + sID + ",'" + Storage.getrequest(i).GetHeadline() + "','"
                    + Storage.getrequest(i).GetHeaders() + "','" + Storage.getrequest(i).GetBody() + "','"
                    + Storage.getresponse(i).GetHeadline() + "','" + Storage.getresponse(i).GetHeaders()
                    + "','" + Storage.getresponse(i).GetBody() + "'" + "),";
                }
                query = query.TrimEnd(',');
                LastInd = Storage.getlen();

                //Console.WriteLine(query);

                conn.runNonQuery(query);
            }
        }

        private void showOutprocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDB();
            frm.ShowDialog();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activated)
            {
                MessageBox.Show("Stop The Proxy First");
                return;
            }
            if (listView1.Items.Count > 0)
            {
                StringBuilder strHTMLBuilder = new StringBuilder();
                strHTMLBuilder.Append("<html >");
                strHTMLBuilder.Append("<head>");
                strHTMLBuilder.Append("</head>");
                strHTMLBuilder.Append("<body>");
                strHTMLBuilder.Append("<table border='1px' cellpadding='1' cellspacing='1' bgcolor='lightyellow' style='font-family:Garamond; font-size:smaller'>");

                strHTMLBuilder.Append("<tr >");
                strHTMLBuilder.Append("<td>HostName</td>");
                strHTMLBuilder.Append("<td>Request</td>");
                strHTMLBuilder.Append("<td>Response</td>");
                strHTMLBuilder.Append("</tr>");
                for (int i = 0; i < Storage.getlen(); i++)
                {
                    MessageBox.Show(i.ToString());
                    strHTMLBuilder.Append("<tr >");
                    strHTMLBuilder.Append("<td>" + Storage.getHosts()[i] + "</td>");
                    strHTMLBuilder.Append("<td>" + Storage.getrequest(i).ToString() + "</td>").Replace("\r\n", "<br />");
                    strHTMLBuilder.Append("<td>" + Storage.getresponse(i).ToString() + "</td>").Replace("\r\n", "<br />");
                    strHTMLBuilder.Append("</tr>");
                }
                strHTMLBuilder.Append("</table>");
                strHTMLBuilder.Append("</body>");
                strHTMLBuilder.Append("</html>");

                string Htmltext = strHTMLBuilder.ToString();
                MessageBox.Show(Htmltext);
            }
            else
            {
                MessageBox.Show("Error : Cant Create Report With 0 Entries.", "NO ELEMENTS");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSLVortex
{
    class SQLDB
    {
        SqlConnection conn = new SqlConnection("Data Source = POOJA-HP\\MSSQLSERVER1; Initial Catalog = vortex; Integrated Security = True;");
        //SqlConnection conn = new SqlConnection("Data Source = SERVER_NAME; Initial Catalog = DB_NAME; Integrated Security = True;");

        SqlCommand cmd;
        SqlDataReader dr;
        public void connect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't connect to server\n" + ex.Message + " exception occured.");
            }
        }

        public void disconnect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't connect to server\n" + ex.Message + " exception occured.");
            }
            finally
            {
                conn.Close();
            }
        }

        //
        public int GetLastID()
        {
            String querry = "select max(SessionID) as smax from SessionDB;";
            try
            {
                cmd = new SqlCommand(querry, conn);
                connect();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["smax"].ToString();
                    if (strid == "")
                    {
                        return 1;
                    }
                    else
                    {
                        return Convert.ToInt32(dr["smax"]) + 1;
                    }
                }
                dr.Close();
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return 0;
        }


        public void runNonQuery(string query)
        {
            connect();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            //Console.Write(query);
        }

        public SqlDataReader runQuery(string query)
        {
            try
            {
                cmd = new SqlCommand(query, conn);
                connect();
                return cmd.ExecuteReader();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return dr;
        }
        public void dataGridFill(string query, DataGridView dGV, string strTable)
        {
            try
            {


                connect();
                DataSet ds = new DataSet();
                ds.Clear();
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter daStock = new SqlDataAdapter(cmd);
                daStock.Fill(ds, strTable);
                dGV.DataSource = ds.Tables[strTable];
                disconnect();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
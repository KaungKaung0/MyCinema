using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class SaleReport : Form
    {
        public SaleReport()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
                //Display query  
                string Query = "SELECT * FROM voucher ORDER BY voucher_id DESC ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CloseAndOpen("dashboard");
        }
        private void CloseAndOpen(string form)
        {
            if (form == "dashboard")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenDashboard));
                t.Start();
                this.Close();
            }
        }
        private static void OpenDashboard()
        {
            Application.Run(new Home());
        }
    }
}

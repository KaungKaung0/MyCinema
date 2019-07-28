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
    public partial class ManageMovie : Form
    {
        public ManageMovie()
        {
            InitializeComponent();
        }

        private void ManageMovie_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
                //Display query  
                string Query = "SELECT * FROM movie";
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

        private void DataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                string MyConnection2 = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
                //Display query  
                string Query = "SELECT * FROM movie";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(MyAdapter);
                MyAdapter.UpdateCommand = mcb.GetUpdateCommand();
                MyAdapter.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }
    }
}

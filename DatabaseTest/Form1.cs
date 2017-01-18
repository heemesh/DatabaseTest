using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DatabaseTest
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand Comm1;
        MySqlDataAdapter da;
        string connString;

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            loading_label.Visible = true;
            connString = "SERVER= 31.220.105.200;PORT=3306;DATABASE=redflixc_FPM;UID=redflixc_heemesh;PASSWORD=heemesh2017";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                loading_label.Visible = false;
                connected_label.Visible = true;
                //MessageBox.Show("Connection Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                //String Command = "SELECT  ACCOUNT_ID, TENANT_NAME, TENANT_ADDRESS,PAYEE FROM `FIRST_PROPERTY_DATABASE` WHERE TENANT_MAIL_TYPE = 'Post' and PAYEE = 'owner'";
                String Command = searchTextbox.Text;
                Comm1 = new MySqlCommand(Command, conn);
                da = new MySqlDataAdapter(Comm1);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);
            }
            catch(Exception ex)
            {
                // test to see if this uploads
               // added new things 
                    //
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
        MySqlConnection connection;
        //MySqlCommand Comm1;
        //MySqlDataAdapter da;
        string connString;

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            loadConnect_label.Visible = true;
            connString = "SERVER= 31.220.105.200;PORT=3306;DATABASE=redflixc_FPM;UID=redflixc_heemesh;PASSWORD=heemesh2017";
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connString;
                connection.Open();

                loadConnect_label.Text = "Connected";
                loadConnect_label.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayTable_button_Click(object sender, EventArgs e)
        {
            try
            {
                String tableQueryCommand = "SELECT * FROM `FIRST_PROPERTY_DATABASE` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(tableQueryCommand, connection);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userAdded_label.Visible = false;
            try
            {
                String userQueryCommand = @"INSERT INTO FIRST_PROPERTY_DATABASE 
                    (ACCOUNT_ID, ACCOUNT_TYPE, APX_DT, FPM_PROCEDURE, OWNER_ADDRESS, OWNER_MAIL_TYPE,
                    OWNER_NAME, PAYEE, TENANT_ADDRESS, TENANT_DR, TENANT_MAIL_TYPE, TENANT_NAME) 
                    VALUES 
                    (@ACCOUNT_ID, @ACCOUNT_TYPE, @APX_DT, @FPM_PROCEDURE, @OWNER_ADDRESS, @OWNER_MAIL_TYPE,
                    @OWNER_NAME, @PAYEE, @TENANT_ADDRESS, @TENANT_DR, @TENANT_MAIL_TYPE, @TENANT_NAME)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = userQueryCommand;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@ACCOUNT_ID", accountID.Text);
                cmd.Parameters.AddWithValue("@ACCOUNT_TYPE", accountType.Text);
                cmd.Parameters.AddWithValue("@APX_DT", apxDT.Text);
                cmd.Parameters.AddWithValue("@FPM_PROCEDURE", fpmProcedure.Text);
                cmd.Parameters.AddWithValue("@OWNER_ADDRESS", ownerAddress.Text);
                cmd.Parameters.AddWithValue("@OWNER_MAIL_TYPE", ownerMailType.Text);
                cmd.Parameters.AddWithValue("@OWNER_NAME", OwnerName.Text);
                cmd.Parameters.AddWithValue("@PAYEE", payee.Text);
                cmd.Parameters.AddWithValue("@TENANT_ADDRESS", tenantAddress.Text);
                cmd.Parameters.AddWithValue("@TENANT_DR", tenantDr.Text);
                cmd.Parameters.AddWithValue("@TENANT_MAIL_TYPE", tenantMailType.Text);
                cmd.Parameters.AddWithValue("@TENANT_NAME", tenantName.Text);
                cmd.ExecuteNonQuery();

                userAdded_label.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
        string connString;

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            connString = "SERVER= xerographic-debits.000webhostapp.com;PORT=3306;DATABASE=id511580_users;UID=id511580_developer;PASSWORD=fpmanagement";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MessageBox.Show("connection success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

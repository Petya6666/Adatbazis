using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatbazis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Port=3307;Database=jegyek;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
              conn.Open();
                string sql = "SELECT * FROM jegyek.masodikview";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
               // MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }
        }
    }
}

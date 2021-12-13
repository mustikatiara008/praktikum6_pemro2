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

namespace P6_1_1204027
{
    public partial class Form1 : Form
    {
        private string url = "server=localhost;userid=root;password=;database=p6_1204027";

        private void UpdateDB(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Database has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdsave = "insert into MSPRODI values('" + txtIdProdi.Text + "','" + txtNamaProdi.Text + "','" + txtSingkatan.Text + "','" + txtKaProdi.Text + "','" + txtSekProdi.Text + "')";
            UpdateDB(cmdsave);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIdProdi.Text = "";
            txtKaProdi.Text = "";
            txtNamaProdi.Text = "";
            txtSekProdi.Text = "";
            txtSingkatan.Text = "";
        }
    }
}
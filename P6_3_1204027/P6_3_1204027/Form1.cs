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

namespace P6_3_1204027
{
    public partial class Form1 : Form
    {
        private string url = "server=localhost;userid=root;password=;database=p6_1204027";

        DataTable dataprodi = new DataTable();
        private void filldataset()
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(url))
            {
                MySqlCommand sqlCmd = new MySqlCommand("SELECT id_prodi, singkatan FROM msprodi", sqlConnection);
                sqlConnection.Open();
                MySqlDataAdapter sqlReader = new MySqlDataAdapter(sqlCmd);
                sqlReader.Fill(dataprodi);

                //while (sqlReader.Read())
                //{
                //    comboBox1.Items.Add(sqlReader["singkatan"].ToString());
                //    comboBox1.Items.Add(new List)
                //}
            }
            comboBox1.DataSource = dataprodi;
            comboBox1.DisplayMember = "singkatan";
            comboBox1.ValueMember = "id_prodi";
        }

        public Form1()
        {
            InitializeComponent();
            filldataset();
        }

        private void InsertDB(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jk = "";
            if (pr.Checked) { jk = pr.Text; } else if (lk.Checked) { jk = lk.Text; }
            string sDate = tanggal.SelectionStart.ToString("yyyy\\/MM\\/dd");
            string alamat = textBox1.Text;
            string cmdsave = "insert into MSMHS values('" + tbnpm.Text + "','" + tbnama.Text + "','" + sDate + "','" + jk + "','" + alamat + "','" + tbtelp.Text + "','" + comboBox1.SelectedValue + "')";
            InsertDB(cmdsave);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbnama.Clear();
            tbnpm.Clear();
            tbtelp.Clear();
            alamt.Text = "";
            comboBox1.Items.Insert(0, "-Please Select-");
            pr.Checked = false;
            lk.Checked = false;

        }

        private void seterror(Control control)
        {
            epWarn.SetError(control, "Harus diisi");
        }

        private void remerror()
        {
            epWarn.Clear();
        }

        private void tbnpm_Leave(object sender, EventArgs e)
        {
            if (tbnpm.Text == "")
            {
                seterror(tbnpm);
            }
            else
            {
                remerror();
            }
        }

        private void tbnama_Leave(object sender, EventArgs e)
        {
            if (tbnama.Text == "")
            {
                seterror(tbnama);
            }
            else
            {
                remerror();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                seterror(textBox1);
            }
            else
            {
                remerror();
            }
        }

        private void tbtelp_Leave(object sender, EventArgs e)
        {
            if (tbtelp.Text == "")
            {
                seterror(tbtelp);
            }
            else
            {
                remerror();
            }
        }
    }
}

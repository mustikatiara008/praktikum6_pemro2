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

namespace P6_2_1204027
{
    public partial class Form1 : Form
    {
        private string url = "server=localhost;userid=root;password=;database=p6_1204027";
        private DataSet Getdatasets()
        {
            DataSet mydataset = new DataSet();
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "select * from msprodi";
                command.CommandType = CommandType.Text;

                MySqlDataAdapter dataadap = new MySqlDataAdapter();
                dataadap.SelectCommand = command;
                dataadap.TableMappings.Add("Table", "Prodi");

                dataadap.Fill(mydataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mydataset;
        }
        private DataSet dsProdi;

        private void RefreshData()
        {
            dsProdi = Getdatasets();
            dgProdi.DataSource = dsProdi.Tables["Prodi"];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string url = "server=localhost;userid=root;password=;database=p6_1204027";
            string myConnectionString = "integrated security=true;datasource=localhost;initial catalog=p6_1204027";
            MySqlConnection conn = new MySqlConnection(url);

            conn.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter("select * from msprodi", conn);
            MySqlCommandBuilder mycmdBuilder = new MySqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = mycmdBuilder.GetInsertCommand();
            myAdapter.DeleteCommand = mycmdBuilder.GetDeleteCommand();
            myAdapter.UpdateCommand = mycmdBuilder.GetUpdateCommand();

            MySqlTransaction myTrans;
            myTrans = conn.BeginTransaction();
            myAdapter.InsertCommand.Transaction = myTrans;
            myAdapter.DeleteCommand.Transaction = myTrans;
            myAdapter.UpdateCommand.Transaction = myTrans;

            try
            {
                int rowsupdate = myAdapter.Update(dsProdi, "Prodi");
                myTrans.Commit();
                MessageBox.Show(rowsupdate.ToString() + " baris diperbarui", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTrans.Rollback();
            }

            MessageBox.Show(myAdapter.InsertCommand.CommandText);
            MessageBox.Show(myAdapter.UpdateCommand.CommandText);
            MessageBox.Show(myAdapter.DeleteCommand.CommandText);
        }
    }
}

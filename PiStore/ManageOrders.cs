using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStore
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
            //SqlConnection conn = DBConnect.GetInstance();
            //display();
        }

        public void display()
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //try
            //{
            //    DataTable dt = new DataTable();
            //    conn.Open();
            //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM View_Orders", conn);
            //    sda.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        public void clear()
        {
            txt_search.Text = "";
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM View_Orders", conn);
            //DataTable dt = new DataTable();
            //conn.Open();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM View_Orders WHERE concat(OrderID, ProductName, ClientName) like '%" + txt_search.Text + "%'", conn);
            //cmd.Parameters.AddWithValue("OrdersID", txt_search.Text);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
            //clear();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Filter = "CSV (*.csv)|*.csv";
            //    sfd.FileName = "OutputOrders.csv";
            //    bool fileError = false;
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(sfd.FileName))
            //        {
            //            try
            //            {
            //                File.Delete(sfd.FileName);
            //            }
            //            catch (IOException ex)
            //            {
            //                fileError = true;
            //                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
            //            }
            //        }
            //        if (!fileError)
            //        {
            //            try
            //            {
            //                int columnCount = dataGridView1.Columns.Count;
            //                string columnNames = "";
            //                string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
            //                for (int i = 0; i < columnCount; i++)
            //                {
            //                    columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
            //                }
            //                outputCsv[0] += columnNames;

            //                for (int i = 1; i < dataGridView1.Rows.Count; i++)
            //                {
            //                    for (int j = 0; j < columnCount; j++)
            //                    {
            //                        outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
            //                    }
            //                }

            //                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
            //                MessageBox.Show("Data Exported Successfully", "Info");
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error :" + ex.Message);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No Record To Export ", "Info");

            //}
        }
    }
}

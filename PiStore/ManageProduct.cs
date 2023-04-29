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
    public partial class ManageProduct : Form
    {
        public ManageProduct()
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
            //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product", conn);
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
            txt_Name.Text = "";
            txt_Description.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            txt_search.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //if (txt_Name.Text == "" || txt_Price.Text == "" || txt_Quantity.Text == "")
            //{
            //    MessageBox.Show("Please fill in the blank");
            //}
            //else
            //{
            //    try
            //    {
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand("INSERT INTO Product values ('" + txt_Name.Text + "','" + txt_Description.Text + "','" + txt_Price.Text + "','" + txt_Quantity.Text + "')", conn);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Data Inserted Successfully.");
            //        conn.Close();
            //        clear();
            //        display();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //SqlCommand cmd = new SqlCommand("sp_DeleteProduct", conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@ProductID", dataGridView1.SelectedRows[0].Cells["ProductID"].Value);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //clear();
            //display();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM View_Product", conn);
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //SqlCommand com = new SqlCommand("sp_UpdateProduct", conn);
            //com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@ProductID", dataGridView1.SelectedRows[0].Cells["ProductID"].Value);
            //com.Parameters.AddWithValue("@ProductName", txt_Name.Text);
            //com.Parameters.AddWithValue("@ProductDescription", txt_Description.Text);
            //com.Parameters.AddWithValue("@ProductPrice", txt_Price.Text);
            //com.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
            //conn.Open();
            //com.ExecuteNonQuery();
            //conn.Close();
            //display();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE concat(ProductID, ProductName) like '%" + txt_search.Text + "%'", conn);
            //cmd.Parameters.AddWithValue("ProductID", txt_search.Text);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
            //clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txt_Description.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txt_Price.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txt_Quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Filter = "CSV (*.csv)|*.csv";
            //    sfd.FileName = "OutputProduct.csv";
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
            //    MessageBox.Show("No Record To Export", "Info");

            //}
        }
    }
}

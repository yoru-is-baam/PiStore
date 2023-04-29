using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStore
{
    public partial class ManagePlaceOrder : Form
    {
        public ManagePlaceOrder()
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
            txt_ClientName.Text = "";
            txt_orderID.Text = "";
            txt_productID.Text = "";
            txt_ProductName.Text = "";
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_productID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txt_ProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = DBConnect.GetInstance();
            //if (txt_ClientName.Text == "" || txt_productID.Text == "" || txt_ProductName.Text == "")
            //{
            //    MessageBox.Show("Please fill in the blank");
            //}
            //else
            //{
            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand();
            //        cmd = conn.CreateCommand();


            //        cmd.CommandText = "UPDATE Product SET quantity = quantity - @newQuantity WHERE ProductID = @ProductID";
            //        cmd.Parameters.AddWithValue("@ProductID", txt_productID.Text);
            //        cmd.Parameters.AddWithValue("@newQuantity", nud_quantity.AllowDrop);
            //        cmd.ExecuteNonQuery();


            //        cmd.CommandText = "INSERT INTO View_Orders (Orders.OrderID, Product.ProductName, OrderItem.Quantity, Client.ClientName, Orders.OrderDate, Orders.TotalPrice) VALUES (@OrderID, @ProductName, @quantity, @ClientName, @OrderDate, @TotalPrice)";
            //        cmd.Parameters.AddWithValue("@OrderID", txt_orderID);
            //        cmd.Parameters.AddWithValue("@ProductID", txt_productID);
                 
            //        cmd.ExecuteNonQuery();


            //        cmd.Transaction.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            
        }
    }
}

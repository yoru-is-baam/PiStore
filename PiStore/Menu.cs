using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PiStore
{
	public partial class Menu : Form
	{
		private ManageEmployee manageEmployeeForm;
		private ManageClient manageClientForm;
		private ManageProduct manageProductForm;
		private ManagePlaceOrder managePlaceOrderForm;
		private ManageOrders manageOrdersForm;
		private ManageBill manageBillForm;

		public Menu()
		{
			InitializeComponent();
		}

		private void ShowForm<T>(T form) where T : Form, new()
		{
			if (form == null)
			{
				form = new T();
				form.FormClosed += (s, args) => form = null;
				form.Show();
			}
			else
			{
				form.BringToFront();
			}
		}

		private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm(manageEmployeeForm);
		}

		private void clientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm(manageClientForm);
		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm(manageProductForm);
		}

		private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm(managePlaceOrderForm);
		}

		private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm(manageOrdersForm);
		}

		private void printBillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm(manageBillForm);
		}

		private void Menu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.Login.Show();
		}
	}
}

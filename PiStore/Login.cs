using DAL;
using PiStore.Class.ValidationStrategy;
using System;
using System.Windows.Forms;

namespace PiStore
{
	public partial class Login : Form
	{
		private readonly PiStoreDBEntities _dbContext;
		private readonly ValidationContext _validationContext;

		public Login()
		{
			InitializeComponent();

			_dbContext = PiStoreDbContext.Instance;
			_validationContext = new ValidationContext();
		}

		private bool CheckValidation()
		{
			_validationContext.SetStrategy(new EmptyValidationStrategy());

			if (!_validationContext.Validate(UsernameBox.Text) || !_validationContext.Validate(PasswordBox.Text))
			{
				MessageBox.Show("Empty field!!");
				return false;
			}

			_validationContext.SetStrategy(new UsernameValidationStrategy(_dbContext));

			if (!_validationContext.Validate(UsernameBox.Text))
			{
				MessageBox.Show("Wrong username");
				return false;
			}

			_validationContext.SetStrategy(new PasswordValidationStrategy(_dbContext, UsernameBox.Text));

			if (!_validationContext.Validate(PasswordBox.Text))
			{
				MessageBox.Show("Wrong password");
				return false;
			}

			return true;
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			if (!CheckValidation()) return;

			var menu = new Menu();
			menu.Show();
			this.Hide();
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			UsernameBox.Text = "";
			PasswordBox.Text = "";

			UsernameBox.Focus();
		}
	}
}

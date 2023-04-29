using System;
using System.Windows.Forms;

namespace PiStore
{
	internal static class Program
	{
		public static Login Login;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Login = new Login();
			Application.Run(Login);
		}
	}
}

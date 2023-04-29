using DAL;
using System;
using System.Linq;

namespace PiStore.Class.ValidationStrategy
{
	public class PasswordValidationStrategy : IValidationStrategy
	{
		private readonly PiStoreDBEntities _dbContext;
		private readonly string _username;

		public PasswordValidationStrategy(PiStoreDBEntities dbContext, string username)
		{
			_dbContext = dbContext;
			_username = username;
		}

		public bool Validate(string password)
		{
			var account = _dbContext.Accounts.FirstOrDefault((a) => a.Username == _username);

			if (account == null) return false;
			if (account.Password != password) return false;

			return true;
		}
	}
}

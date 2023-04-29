using DAL;
using System;
using System.Linq;

namespace PiStore.Class.ValidationStrategy
{
	public class UsernameValidationStrategy : IValidationStrategy
	{
		private readonly PiStoreDBEntities _dbContext;

		public UsernameValidationStrategy(PiStoreDBEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public bool Validate(string data)
		{
			var account = _dbContext.Accounts.FirstOrDefault((a) => a.Username == data);

			return account != null;
		}
	}
}

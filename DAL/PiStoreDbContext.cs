namespace DAL
{
	public class PiStoreDbContext
	{
		private static PiStoreDBEntities _instance;

		private PiStoreDbContext()
		{

		}

		public static PiStoreDBEntities Instance => _instance ?? (_instance = new PiStoreDBEntities());
	}
}

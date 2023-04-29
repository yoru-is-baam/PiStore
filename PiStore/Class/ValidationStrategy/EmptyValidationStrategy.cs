using System;

namespace PiStore.Class.ValidationStrategy
{
	public class EmptyValidationStrategy : IValidationStrategy
	{
		public bool Validate(string data)
		{
			return !string.IsNullOrEmpty(data);
		}
	}
}

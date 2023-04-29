using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore.Class.ValidationStrategy
{
	public interface IValidationStrategy
	{
		bool Validate(string data);
	}
}

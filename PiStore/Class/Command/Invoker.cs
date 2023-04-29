using System;

namespace PiStore.Class.Command
{
	public class Invoker
	{
		private ICommand _command;

		public void SetCommand(ICommand command)
		{
			_command = command;
		}

		public void Execute()
		{
			_command.Execute();
		}
	}
}

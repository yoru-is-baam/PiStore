using DAL;
using PiStore.Class.Repository;
using System;

namespace PiStore.Class.Command
{
	public class AddEmployeeCommand : ICommand
	{
		private readonly Employee _employee;
		private readonly IEmployeeRepository _employeeRepository;

		public AddEmployeeCommand(Employee employee, IEmployeeRepository employeeRepository)
		{
			_employee = employee;
			_employeeRepository = employeeRepository;
		}

		public void Execute()
		{
			_employeeRepository.AddEmployee(_employee);
		}
	}
}

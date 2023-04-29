using DAL;
using System;
using System.Collections.Generic;
using Employee = PiStore.Class.Entity.Employee;

namespace PiStore.Class.Repository
{
	public interface IEmployeeRepository
	{
		void AddEmployee(DAL.Employee employee);
		List<Employee> GetEmployees();
	}
}

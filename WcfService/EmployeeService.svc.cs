using System;
using System.Collections.Generic;

namespace WcfService
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees;
        public EmployeeService()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee { Id = 1, Name = "Halil", Surname = "TOKSÖZ", IsWorking = true });
            _employees.Add(new Employee { Id = 2, Name = "Emre", Surname = "ŞANLI", IsWorking = true });
            _employees.Add(new Employee { Id = 3, Name = "Ecem", Surname = "FİLİZLİ", IsWorking = true });
            _employees.Add(new Employee { Id = 4, Name = "Employee", Surname = "Unknown", IsWorking = false });
        }
        public Employee GetEmployee(int id)
        {
            var employee = _employees.Find(x => x.Id == id);
            if (employee == null)
                throw new Exception("Employee not found");

            return employee;
        }
        public bool EmployeeIsWorking(int id) => GetEmployee(id).IsWorking;
    }
}

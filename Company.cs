using System;
using System.Collections.Generic;

namespace Company_Employee
{
    public class Company
    {
        private List<Employee> _employeeList;
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> EmployeeList
        {
            get
            {
                return _employeeList;
            }
            set
            {
                //value is a defined variable, built-in to c#
                _employeeList = value;
            }
        }

        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Today;
            _employeeList = new List<Employee>();
        }
    }

}
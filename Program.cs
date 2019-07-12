using System;

namespace Company_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            var twoGeeks = new Company("Two Geek Solutions");

            // Create three employees
            var employee1 = new Employee("Cavy", "Baby", "Mascot");
            var employee2 = new Employee("Cerin", "Street Dog", "Greeter");
            var employee3 = new Employee("Corey", "Arnold", "Bread-Winner");

            // Assign the employees to the company
            twoGeeks.EmployeeList.Add(employee1);
            twoGeeks.EmployeeList.Add(employee2);
            twoGeeks.EmployeeList.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (var employee in twoGeeks.EmployeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} starting at {twoGeeks.Name} on {employee.StartDate.ToShortDateString()} as the {employee.Title}.");
            }

        }
    }
}

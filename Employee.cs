using System;

namespace Company_Employee
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string first, string last, string title)
        {
            FirstName = first;
            LastName = last;
            Title = title;
            StartDate = DateTime.Today;
        }

    }
}
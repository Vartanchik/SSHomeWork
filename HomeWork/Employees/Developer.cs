using System;

namespace HomeWork
{
    public class Developer : Employee
    {
        public Developer(string firstName, string secondName, double salary, double experience, Manager manager)
            : base(firstName, secondName, salary, experience, manager)
        {

        }
    }
}

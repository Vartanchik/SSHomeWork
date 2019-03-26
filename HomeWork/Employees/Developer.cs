using System;

namespace BaseOOP
{
    public class Developer : Employee
    {
        public Developer(string firstName, string secondName, decimal salary, int experience, Manager manager)
            : base(firstName, secondName, salary, experience, manager)
        {

        }
    }
}

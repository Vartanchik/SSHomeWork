using System;

namespace BaseOOP
{
    public abstract class Employee
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Experience { get; set; }

        public decimal Salary { get; set; }

        public Manager Manager { get; set; }

        // Constructor for all employees except Managers
        public Employee(string firstName, string secondName, decimal salary, int experience, Manager manager)
        {
            FirstName = firstName;
            SecondName = secondName;
            Experience = experience;
            Salary = salary;
            Manager = manager;
        }

        // Constructor for Managers
        public Employee(string firstName, string secondName, decimal salary, int experience)
        {
            FirstName = firstName;
            SecondName = secondName;
            Experience = experience;
            Salary = salary;
            Manager = (Manager)this;
        }

        // Get salary for each employee with the same dependence of experience.
        protected decimal GetSalaryByExperience()
        {
            if (Experience > 5)
            {
                return Salary * 1.20m + 500; 
            }

            if (Experience > 2)
            {
                return Salary + 200;
            }

            return Salary;
        }

        // Calculation of salary by different dependences for each employee
        public virtual decimal CalculateSalary()
        {
            return GetSalaryByExperience();
        }

        public void GiveSalary()
        {
            Console.WriteLine($"{FirstName} {SecondName}: got salary: {CalculateSalary()}");
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}, manager: {Manager.SecondName}, experience: {Experience}";
        }
    }
}

using System;

namespace HomeWork
{
    public abstract class Employee
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public double Experience { get; set; }

        public double Salary { get; set; }

        public Manager Manager { get; set; }

        // Constructor for all employees except Managers
        public Employee(string firstName, string secondName, double salary, double experience, Manager manager)
        {
            FirstName = firstName;
            SecondName = secondName;
            Experience = experience;
            Salary = salary;
            Manager = manager;
        }

        // Constructor for Managers
        public Employee(string firstName, string secondName, double salary, double experience)
        {
            FirstName = firstName;
            SecondName = secondName;
            Experience = experience;
            Salary = salary;
            Manager = (Manager)this;
        }

        // Get salary for each employee with the same dependence of experience.
        protected double GetSalaryByExperience()
        {
            if (Experience > 5)
            {
                return Salary * 1.2 + 500;
            }

            if (Experience > 2)
            {
                return Salary + 200;
            }

            return Salary;
        }

        // Calculation of salary by different dependences for each employee
        public virtual double CalculateSalary()
        {
            return GetSalaryByExperience();
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}, manager: {Manager.SecondName}, experience: {Experience}";
        }
    }
}

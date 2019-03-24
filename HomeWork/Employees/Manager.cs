using System;
using System.Collections.Generic;

namespace HomeWork
{
    public class Manager : Employee
    {
        public List<Employee> Team { get; set; }

        //Constructor for Managers without team
        public Manager(string firstName, string secondName, double salary, double experience)
            : base(firstName, secondName, salary, experience)
        {
            Team = null;
        }

        //Constructor for Managers with team
        public Manager(string firstName, string secondName, double salary, double experience, List<Employee> teamMembers)
            : base(firstName, secondName, salary, experience)
        {
            Team = teamMembers;
        }

        public override double CalculateSalary()
        {
            double salary = GetSalaryByExperience();

            // Counter of developers in team
            int developersCount = 0;
            foreach (var employee in Team)
            {
                if (employee is Developer)
                    developersCount++;
            }

            if (Team.Count > 10)
            {
                salary += 300;
            }

            else if (Team.Count > 5)
            {
                salary += 200;
            }

            if (developersCount > Team.Count * 0.5)
            {
                salary *= 1.1;
            }

            return salary;
        }
    }
}

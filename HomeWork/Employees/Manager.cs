using System;
using System.Collections.Generic;

namespace BaseOOP
{
    public class Manager : Employee
    {
        public List<Employee> Team { get; set; }

        //Constructor for Managers without team
        public Manager(string firstName, string secondName, decimal salary, int experience)
            : base(firstName, secondName, salary, experience)
        {
            Team = null;
        }

        //Constructor for Managers with team
        public Manager(string firstName, string secondName, decimal salary, int experience, List<Employee> teamMembers)
            : base(firstName, secondName, salary, experience)
        {
            Team = teamMembers;
        }

        public bool IsDevelopersMoreThanTeamHalf()
        {
            int developersCount = 0;

            foreach (var employee in Team)
            {
                if (employee is Developer)
                    developersCount++;
            }

            if (developersCount > Team.Count / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override decimal CalculateSalary()
        {
            decimal salary = base.GetSalaryByExperience();

            if (Team.Count > 10)
            {
                salary += 300;
            }

            else if (Team.Count > 5)
            {
                salary += 200;
            }

            if (IsDevelopersMoreThanTeamHalf())
            {
                salary *= 1.1m;
            }

            return salary;
        }
    }
}

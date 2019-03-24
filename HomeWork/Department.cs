using System;
using System.Collections.Generic;

namespace HomeWork
{
    public class Department
    {
        public List<Manager> managers;

        public Department(List<Manager> managers)
        {
            this.managers = managers;
        }

        public void GiveSalary()
        {
            foreach(var manager in managers)
            {
                Console.WriteLine($"{manager.FirstName} {manager.SecondName}: got salary: {manager.CalculateSalary()}");

                foreach(var teamMember in manager.Team)
                {
                    Console.WriteLine($"{teamMember.FirstName} {teamMember.SecondName}: got salary: {teamMember.CalculateSalary()}");
                }
            }
        }
    }
}

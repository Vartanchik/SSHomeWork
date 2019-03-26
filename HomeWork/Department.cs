using System;
using System.Collections.Generic;

namespace BaseOOP
{
    public class Department
    {
        private List<Manager> managers;

        public Department(List<Manager> managers)
        {
            this.managers = managers;
        }

        public void PaySalary()
        {
            foreach(var manager in managers)
            {
                manager.GiveSalary();

                foreach(var teamMember in manager.Team)
                {
                    teamMember.GiveSalary();
                }
            }
        }
    }
}

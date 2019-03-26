using BaseOOP;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class DepartmentTests
    {
        Department department;

        [SetUp]
        public void Setup()
        {
            Manager manager2 = new Manager("Man2", "Manager2", 1500, 1);

            Developer developer8 = new Developer("Dev8", "Developer8", 1000, 2, manager2);
            Developer developer9 = new Developer("Dev9", "Developer9", 1700, 3, manager2);
            Developer developer10 = new Developer("Dev10", "Developer10", 3000, 7, manager2);

            Designer designer5 = new Designer("Des5", "Designer5", 2000, 3, manager2, 0.9m);
            Designer designer6 = new Designer("Des6", "Designer6", 600, 1, manager2, 0.4m);

            manager2.Team = new List<Employee>()
                {
                    developer8, developer9, developer10,
                    designer5, designer6
                };

            department = new Department(new List<Manager> { manager2 });
        }
        [Test]
        public void PaySalaryMethodShouldOutputAllEmployeesWhoGetSalary()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                department.PaySalary();

                string expected = "Man2 Manager2: got salary: 1650,0"
                    + "\r\n" + "Dev8 Developer8: got salary: 1000"
                    + "\r\n" + "Dev9 Developer9: got salary: 1900"
                    + "\r\n" + "Dev10 Developer10: got salary: 4100,00"
                    + "\r\n" + "Des5 Designer5: got salary: 1980,0"
                    + "\r\n" + "Des6 Designer6: got salary: 240,0" + "\r\n";
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}
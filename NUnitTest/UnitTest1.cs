using HomeWork;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class Tests
    {
        Manager manager1, manager2, manager3;

        Developer developer1, developer2, developer3, developer4, developer5, developer6, developer7,
            developer8, developer9, developer10, developer11, developer12, developer13, developer14, developer15;

        Designer designer1, designer2, designer3, designer4, designer5, designer6, designer7, designer8, designer9;

        Department department1, department2;

        [SetUp]
        public void Setup()
        {
            manager1 = new Manager("Man1", "Manager1", 4000, 6);
            manager2 = new Manager("Man2", "Manager2", 1500, 1);
            manager3 = new Manager("Man3", "Manager3", 2500, 2.5);

            developer1 = new Developer("Dev1", "Developer1", 500, 0.5, manager1);
            developer2 = new Developer("Dev2", "Developer2", 700, 1, manager1);
            developer3 = new Developer("Dev3", "Developer3", 1000, 1.5, manager1);
            developer4 = new Developer("Dev4", "Developer4", 1700, 3, manager1);
            developer5 = new Developer("Dev5", "Developer5", 3000, 7, manager1);
            developer6 = new Developer("Dev6", "Developer6", 500, 0.5, manager1);
            developer7 = new Developer("Dev7", "Developer7", 700, 1, manager1);
            developer8 = new Developer("Dev8", "Developer8", 1000, 1.5, manager2);
            developer9 = new Developer("Dev9", "Developer9", 1700, 3, manager2);
            developer10 = new Developer("Dev10", "Developer10", 3000, 7, manager2);
            developer11 = new Developer("Dev11", "Developer11", 500, 0.5, manager3);
            developer12 = new Developer("Dev12", "Developer12", 700, 1, manager3);
            developer13 = new Developer("Dev13", "Developer13", 1000, 1.5, manager3);
            developer14 = new Developer("Dev14", "Developer14", 1700, 3, manager3);
            developer15 = new Developer("Dev15", "Developer15", 3000, 7, manager3);

            designer1 = new Designer("Des1", "Designer1", 600, 0.5, manager1, 0.5);
            designer2 = new Designer("Des2", "Designer2", 900, 1.5, manager1, 0.8);
            designer3 = new Designer("Des3", "Designer3", 1200, 2.0, manager1, 0.7);
            designer4 = new Designer("Des4", "Designer4", 1700, 2.5, manager1, 0.6);
            designer5 = new Designer("Des5", "Designer5", 2000, 3, manager2, 0.9);
            designer6 = new Designer("Des6", "Designer6", 600, 0.5, manager2, 0.4);
            designer7 = new Designer("Des7", "Designer7", 1300, 2.2, manager3, 0.65);
            designer8 = new Designer("Des8", "Designer8", 700, 1.0, manager3, 0.8);
            designer9 = new Designer("Des9", "Designer9", 1200, 1.5, manager3, 0.95);

            manager1.Team = new List<Employee>()
                {
                    developer1, developer2, developer3, developer4, developer5, developer6, developer7,
                    designer1, designer2, designer3, designer4
                };


            manager2.Team = new List<Employee>()
                {
                    developer8, developer9, developer10,
                    designer5, designer6
                };

            manager3.Team = new List<Employee>()
                {
                    developer11, developer12, developer13, developer14, developer15,
                    designer7, designer8, designer9
                };

            department1 = new Department(new List<Manager> { manager1, manager2, manager3 });
            department2 = new Department(new List<Manager> { manager2 });
        }

        [Test]
        public void CalculateSalaryMethodShouldReturnSalary()
        {
            Assert.AreEqual(6160, manager1.CalculateSalary(), 0.001);
            Assert.AreEqual(1650, manager2.CalculateSalary(), 0.001);
            Assert.AreEqual(3190, manager3.CalculateSalary(), 0.001);
            Assert.AreEqual(4100, developer10.CalculateSalary(), 0.001);
            Assert.AreEqual(1980, designer5.CalculateSalary(), 0.001);
        }

        [Test]
        public void GiveSalaryMethodShouldOutputWhoGetSalary()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                department2.GiveSalary();

                string expected = "Man2 Manager2: got salary: 1650"
                    + "\r\n" + "Dev8 Developer8: got salary: 1000"
                    + "\r\n" + "Dev9 Developer9: got salary: 1900"
                    + "\r\n" + "Dev10 Developer10: got salary: 4100"
                    + "\r\n" + "Des5 Designer5: got salary: 1980"
                    + "\r\n" + "Des6 Designer6: got salary: 240" + "\r\n";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void OverridedToStringShouldGiveEmployeeDescription()
        {
            Assert.AreEqual("Man1 Manager1, manager: Manager1, experience: 6", manager1.ToString());
            Assert.AreEqual("Dev1 Developer1, manager: Manager1, experience: 0,5", developer1.ToString());
            Assert.AreEqual("Des1 Designer1, manager: Manager1, experience: 0,5", designer1.ToString());
        }
    }
}
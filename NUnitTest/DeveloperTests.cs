using BaseOOP;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class DeveloperTests
    {
        Developer developer1, developer2, developer3;

        [SetUp]
        public void Setup()
        {
            Manager manager1 = new Manager("Man1", "Manager1", 4000, 6);

            developer1 = new Developer("Dev1", "Developer1", 800, 1, manager1);
            developer2 = new Developer("Dev2", "Developer2", 1500, 3, manager1);
            developer3 = new Developer("Dev3", "Developer3", 3000, 6, manager1);

            manager1.Team = new List<Employee>()
                {
                    developer1, developer2, developer3
                };
        }

        [Test]
        public void CalculateSalary_When_Experience_1year()
        {
            Assert.AreEqual(800, (double)developer1.CalculateSalary(), 0.001);
        }

        [Test]
        public void CalculateSalary_When_Experience_3years()
        {
            Assert.AreEqual(1700, (double)developer2.CalculateSalary(), 0.001);
        }

        [Test]
        public void CalculateSalary_When_Experience_6years()
        {
            Assert.AreEqual(4100, (double)developer3.CalculateSalary(), 0.001);
        }

        //[Test]
        //public void GiveSalaryMethodShouldOutputWhoGetSalary()
        //{
        //    using (StringWriter sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);

        //        department2.PaySalary();

        //        string expected = "Man2 Manager2: got salary: 1650"
        //            + "\r\n" + "Dev8 Developer8: got salary: 1000"
        //            + "\r\n" + "Dev9 Developer9: got salary: 1900"
        //            + "\r\n" + "Dev10 Developer10: got salary: 4100"
        //            + "\r\n" + "Des5 Designer5: got salary: 1980"
        //            + "\r\n" + "Des6 Designer6: got salary: 240" + "\r\n";
        //        Assert.AreEqual(expected, sw.ToString());
        //    }
        //}

        [Test]
        public void OverridedToString_Developer()
        {
            Assert.AreEqual("Dev1 Developer1, manager: Manager1, experience: 1", developer1.ToString());
        }
    }
}
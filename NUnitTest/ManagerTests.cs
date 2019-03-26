using BaseOOP;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class TestDeveloper : Developer
    {
        public TestDeveloper() : base("Dev", "Developer", 1000m, 1, null)
        {

        }
    }

    public class TestDesigner : Designer
    {
        public TestDesigner() : base("Des", "Designer", 1000m, 1, null, 1m)
        {

        }
    }

    public class ManagerTests
    {
        Manager manager1, manager2, manager3;

        [SetUp]
        public void Setup()
        {
            manager1 = new Manager("Man1", "Manager1", 1000, 1);

            manager2 = new Manager("Man2", "Manager2", 2500, 3);

            manager3 = new Manager("Man3", "Manager3", 4000, 6);

            manager1.Team = new List<Employee>()
                {
                    new TestDeveloper(), new TestDeveloper(),
                    new TestDesigner(), new TestDesigner()
                };

            manager2.Team = new List<Employee>()
                {
                    new TestDeveloper(), new TestDeveloper(), new TestDeveloper(),
                    new TestDesigner(), new TestDesigner(), new TestDesigner(), new TestDesigner()
                };

            manager3.Team = new List<Employee>()
                {
                    new TestDeveloper(), new TestDeveloper(), new TestDeveloper(), new TestDeveloper(),
                    new TestDeveloper(), new TestDeveloper(), new TestDeveloper(),
                    new TestDesigner(), new TestDesigner(), new TestDesigner(), new TestDesigner()
                };
        }

        [Test]
        public void CalculateSalary_When_Experience_1year_And_4PersonTeam_And_DevelopersEqualsHalf()
        {
            Assert.AreEqual(1000, (double)manager1.CalculateSalary(), 0.001);
        }

        [Test]
        public void CalculateSalary_When_Experience_3years_And_7PersonTeam_And_DevelopersLessThenHalf()
        {
            Assert.AreEqual(2900, (double)manager2.CalculateSalary(), 0.001);
        }

        [Test]
        public void CalculateSalary_When_Experience_6years_And_11PersonTeam_And_DevelopersMoreThenHalf()
        {
            Assert.AreEqual(6160, (double)manager3.CalculateSalary(), 0.001);
        }

        [Test]
        public void OverridedToString_Manager()
        {
            Assert.AreEqual("Man1 Manager1, manager: Manager1, experience: 1", manager1.ToString());
        }
    }
}
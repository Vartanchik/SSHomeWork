using BaseOOP;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class DesignerTests
    {
        Designer designer1, designer2, designer3;

        [SetUp]
        public void Setup()
        {
            Manager manager1 = new Manager("Man1", "Manager1", 4000, 6);

            designer1 = new Designer("Des1", "Designer1", 600, 1, manager1, 1m);
            designer2 = new Designer("Des2", "Designer2", 900, 3, manager1, 0.8m);
            designer3 = new Designer("Des3", "Designer3", 1200, 6, manager1, 0.5m);

            manager1.Team = new List<Employee>()
                {
                    designer1, designer2, designer3
                };
        }

        [Test]
        public void CalculateSalary_When_Experience_1year_And_EffectivenessCoefficient_1()
        {
            Assert.AreEqual(600, (double)designer1.CalculateSalary(), 0.001);
        }

        [Test]
        public void CalculateSalary_When_Experience_3years_And_EffectivenessCoefficient_08()
        {
            Assert.AreEqual(880, (double)designer2.CalculateSalary(), 0.001);
        }

        [Test]
        public void CalculateSalary_When_Experience_6years_And_EffectivenessCoefficient_05()
        {
            Assert.AreEqual(970, (double)designer3.CalculateSalary(), 0.001);
        }

        [Test]
        public void OverridedToString_Designer()
        {
            Assert.AreEqual("Des1 Designer1, manager: Manager1, experience: 1", designer1.ToString());
        }
    }
}
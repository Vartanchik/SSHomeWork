using System;

namespace HomeWork
{
    public class Designer : Employee
    {
        public double EffectivenessCoefficient { get; set; }

        public Designer(string firstName, string secondName, double salary, double experience, Manager manager, double effectivenessCoefficient)
            : base(firstName, secondName, salary, experience, manager)
        {
            EffectivenessCoefficient = effectivenessCoefficient;
        }

        public override double CalculateSalary()
        {
            return GetSalaryByExperience() * EffectivenessCoefficient;
        }
    }
}

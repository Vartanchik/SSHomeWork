using System;

namespace BaseOOP
{
    public class Designer : Employee
    {
        private decimal effectivenessCoefficient;

        public decimal EffectivenessCoefficient
        {
            get
            {
                return effectivenessCoefficient;
            }

            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException($"{value} must be in range from 0 to 1");
                }

                effectivenessCoefficient = value;
            }
        }

        public Designer(string firstName, string secondName, decimal salary, int experience, Manager manager, decimal effectivenessCoefficient)
            : base(firstName, secondName, salary, experience, manager)
        {
            EffectivenessCoefficient = effectivenessCoefficient;
        }

        public override decimal CalculateSalary()
        {
            return base.GetSalaryByExperience() * EffectivenessCoefficient;
        }
    }
}

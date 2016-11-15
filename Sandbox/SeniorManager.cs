using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class SeniorManager : Manager
    {
        private int performanceLevel;

        public SeniorManager(string name, int monthlyBaseSalary, int monthlyBonus) : base(name, monthlyBaseSalary, monthlyBonus)
        {
            this.performanceLevel = 0;
        }

        public void SetPerformaceLevel(int performanceLevel)
        {
            this.performanceLevel = performanceLevel;
        }

        public override bool IsBonusPaidOut()
        {
            return (performanceLevel > 6);
        }
    }
}

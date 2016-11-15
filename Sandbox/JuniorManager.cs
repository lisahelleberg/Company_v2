using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class JuniorManager : Manager
    {
        // Instans fields
        private int workedHours;

        public JuniorManager(string name, int monthlyBaseSalary, int monthlyBonus,) : base(name, monthlyBaseSalary, monthlyBonus)
        {
            this.workedHours = 0;
        }

        public void SetWorkedHours(int workedHours)
        {
            this.workedHours = workedHours;
        }
        public override bool IsBonusPaidOut()
        {
            return (workedHours > 180);
        }
    }
}

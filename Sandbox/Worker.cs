using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        public int hourlyPay;
        public int monthlyHours;

        public Worker(string name, int hourlyPay, int monthlyHours) : base(name)
        {
            this.hourlyPay = hourlyPay;
            this.monthlyHours = monthlyHours;
        }

        public override int GetBonusPerMonth()
        {
            return 0;
        }

        public override int GetSalaryPerMonth()
        {
            return hourlyPay * monthlyHours;
        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }
}

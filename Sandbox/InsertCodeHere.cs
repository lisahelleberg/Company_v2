using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<Employee> allEmployees = new List<Employee>();

            Worker w1 = new Worker("Lars", 125, 150);
            Worker w2 = new Worker("Lone", 118, 120);
            Worker w3 = new Worker("Lasse", 95, 40);
            allEmployees.Add(w1);
            allEmployees.Add(w2);
            allEmployees.Add(w3);

            JuniorManager jm1 = new JuniorManager("Sigurd", 25000, 5000);
            jm1.SetWorkedHours(150);
            JuniorManager jm2 = new JuniorManager("Sigrid", 30000, 5000);
            jm2.SetWorkedHours(200);

            allEmployees.Add(jm1);
            allEmployees.Add(jm2);

            SeniorManager sm1 = new SeniorManager("Bent", 40000, 10000);
            sm1.SetPerformaceLevel(2);
            SeniorManager sm2 = new SeniorManager("Bente", 38000, 10000);
            sm2.SetPerformaceLevel(8);
            allEmployees.Add(sm1);
            allEmployees.Add(sm2);

            foreach (Employee e in allEmployees)
            {
                Console.WriteLine($"{e.GetName()} has a monthly salary of {e.GetSalaryPerMonth()}");
                Console.WriteLine();
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3Q2
{
    class HRandDEV:Employee
    {
        public double basicSalary;
        public HRandDEV(int id, string name,string des, int exp,double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = des;
            this.Experience = exp;
            this.basicSalary = salary;
        }
        public override double CountSalary()
        {
            if (Designation.Equals("HR",StringComparison.InvariantCultureIgnoreCase))
                return (basicSalary*12) + (1000 * Experience);
            else if (Designation.Equals("Developer",StringComparison.InvariantCultureIgnoreCase))
                return (basicSalary*12) + (2000 * Experience);
            else
                return basicSalary*12;
        }
    }
}

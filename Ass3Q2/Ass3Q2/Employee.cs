using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3Q2
{
    public abstract class Employee
    {
        public int Id;
        public string Name;
        public string Designation;
        public int Experience;
        public double AnnualSalary;
        public DateTime joiningDate;
        

        public abstract double CountSalary();
    }
}

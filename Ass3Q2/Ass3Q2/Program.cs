using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            HRandDEV hr = new HRandDEV(101, "xyz", "hr", 4,8000);
            hr.AnnualSalary= hr.CountSalary();
            Console.WriteLine("salary of {0} is :{1}", hr.Designation, hr.AnnualSalary);
            HRandDEV dev = new HRandDEV(101, "xyz", "Developer", 5, 8000);
            dev.AnnualSalary = dev.CountSalary();
            Console.WriteLine("salary of {0} is :{1}", dev.Designation, dev.AnnualSalary);
            HRandDEV emp = new HRandDEV(101, "xyz", "Manager", 4, 8000);
            emp.AnnualSalary = emp.CountSalary();
            Console.WriteLine("salary of {0} is :{1}", emp.Designation, emp.AnnualSalary);
            Console.Read();
        }
    }
}

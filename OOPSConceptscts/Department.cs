using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptscts
{
    internal class Department : Employee //base class Employee 
    {
        public string DeptName {  get; set; }

        public  override void Display()
        {
                  
            base.Display();
            Console.WriteLine(DeptName);
        }
    }
    class Manager : Department
    {
        public string MgrName { get; set; }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(MgrName);
        }
    }
}

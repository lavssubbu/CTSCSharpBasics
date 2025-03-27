using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptscts
{
    public class Employee
    {
      protected int Empid {  get; set; }
      protected string EmpName { get; set; }

        public static string OrgName = "Cognizant";

        //Constructor
        public Employee()
        {
            Console.WriteLine("Parameterless/Default constructor");
        }
        public Employee(int id,string EmpName)
        {
             Empid = id;
            this.EmpName = EmpName;
        }

        public virtual void Display()
        {
            Console.WriteLine(Empid + " " + EmpName);
        }
        public static void Show()
        {
            Console.WriteLine("Organization Name"+OrgName);
        }
    }
}


namespace OOPSConceptscts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee em = new Employee();

          
            Console.WriteLine("Enter id and name:");
            int id = int.Parse(Console.ReadLine());

            string nm = Console.ReadLine();

            Employee emp = new Employee(id, nm);
           
            emp.Display();
            Employee.Show();
          //  Employee em2 = new Employee() { Empid = 113, EmpName = "Anu" };
          //   Employee em3 = new Employee() { Empid = 114, EmpName = "Anu" };
           /// em2.Display();

           // Employee.Show();

           // em3.Display();
           // Employee.Show();

           // Department dep = new Department();
           // dep.Empid = 11;
           // dep.EmpName = "Anu";
           // dep.DeptName = "HR";
           // dep.Display();
           // // dep.Show();

           // Manager mgr = new Manager();

           // mgr.Empid = 11;
           // mgr.EmpName = "Anu";
           // mgr.DeptName = "HR";
           // mgr.MgrName = "Rekha";
           // mgr.Display();
        }
    }
}
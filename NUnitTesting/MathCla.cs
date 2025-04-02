using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtsCollectionsDemo
{
    public class MathCla
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }

        public virtual bool CheckValue()
        {
            return false;
        }
    }
    public class Employee
    {
        string Name;
        int Age;

        public Employee(string ename, int age)
        {
            Name = ename;
            Age = age;
        }
        public string name
        {
            get
            {
                return Name;
            }
           
        }

        public int age
        {
            get
            {
                return Age;
            }
           
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + Age);
        }
    }
}

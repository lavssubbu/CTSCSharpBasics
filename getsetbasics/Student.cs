using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getsetsamp
{
    internal class Student
    {
        private int sid;

        public int Stid
        {
            get
            {
                return sid;
            }
            set
            {
                sid = value;
            }
        }

        private string sname;

        public string Name
        {
            get
            {
                return sname;
            }
            set
            {
                if(value.ToLower().Equals("anu"))
                {
                    Console.WriteLine("Anu not allowed.Exceptional");
                }
                else
                {
                    sname = value;
                }
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value>25)
                {
                    Console.WriteLine("Not Eligible to attend the exam.Age should be below 25");
                }
                else
                {
                    age = value;
                }
            }
        }

    }
}

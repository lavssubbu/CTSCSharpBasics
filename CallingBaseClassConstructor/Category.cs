using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingBaseClassConstructor
{
    internal class Category : Product
    {
        string catname;

        public Category(int id,string proname,string catname) : base(id,proname) 
        {
            this.catname = catname;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(catname);
        }
    }
}

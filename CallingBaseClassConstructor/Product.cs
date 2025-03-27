using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingBaseClassConstructor
{
    internal class Product
    {
        int Proid;
        string ProName;

        public Product(int Proid,string ProName)
        {
            this.Proid = Proid;
            this.ProName = ProName;
        }

        public virtual void Print()
        {
            Console.WriteLine(Proid + " " + ProName);
        }

    }
}

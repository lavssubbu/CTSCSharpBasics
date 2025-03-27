using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcepts
{
    internal interface IShape
    {
        void Area();

        void Square(int side)
        {
            Console.WriteLine(side * side);
        }
    }
    class Circle : IShape
    {
        int radius = 5;
        public void Area()
        {
           Console.WriteLine(Math.PI * Math.Pow(radius, 2));
        }
    }

}

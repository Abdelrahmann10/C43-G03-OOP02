using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {

        // X, Y

        //public int X { get; set; }

        public int Y { get; set; }

        // Default

        public Child()
        {

        }

        public Child(int x, int y) : base(x)
        {
            // X = x ;
            Y = y;
            // X = 12; 


        }

        public void Fun01()
        {

            Console.WriteLine(" Fun01 From child ");
        }

        public override void Fun02()
        {

            Console.WriteLine($" X = {X} :: Y = {y}");
        }
    }
}

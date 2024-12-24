using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }

        public Parent()
        {

        }

        public Parent(int x)
        {
            X = x;

        }

        public void Fun01()
        {

            Console.WriteLine(" Fun01 From Parent ");
        }

        public virtual void Fun02()
        {

            Console.WriteLine($" X = {X} ");
        }

    }
}

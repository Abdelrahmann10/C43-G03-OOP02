using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonn
{
    public class TypeB : TypeA
    {
        void fun01()
        {
            a = 12; //  private 
            x = 12; //  internal
            y = 12; //  private   

            TypeA typeA = new TypeA();
            typeA.z = 12;

            TypeB typeB = new TypeB();
            typeB.x = 12;
            typeB.y = 12;
            typeB.z = 12;

        }
    }

    class TypeC
    {
        void Fun01()
        {
            TypeB typeB = new TypeB();
            typeB.z = 20;
        }
    }
}

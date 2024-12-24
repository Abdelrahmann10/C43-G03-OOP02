using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonn
{
    public class TypeA
    {
        protected int a;
        private protected int x;    //Private      //Can inherit    
        protected int y;            //Private      //Can inherit but can't use
        internal protected int z;   //Internal     //Can inherit inside the same project  
    }
}

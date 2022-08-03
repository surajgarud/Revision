using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    public class Inheritance
    {
        public class ParentClass
        {
            public ParentClass()
            {
                Console.WriteLine("Parent Class.");
            }
            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
        }
        public class ChildClass : ParentClass
        {
            public ChildClass()
            {
                Console.WriteLine("Child Constructor.");
            }
            
        }
    }
}

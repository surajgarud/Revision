using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    internal class Loop
    {
        public static void iteration()
        {
            for (int i=1; i<=5; i++)
			{
				Console.WriteLine("For Loop Iteration {0}",i);
			}
        }

		public static void whileloop()
		{
			int i = 1;
			while (i <= 5)
			{
				Console.WriteLine(" while Loop Iteration {0}", i);
				i++;
			}
		}

	}
}

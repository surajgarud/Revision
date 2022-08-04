using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Colection
    {
        public static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        

        public static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary: ");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key=" + element.Key + "& Value=" + element.Value);
            }
        }
        public static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Stack<int> stack = new Stack<int>();
            stack.Push(101);
            stack.Push(202);
            stack.Push(303);
            stack.Push(404);
            stack.Push(505);
            int pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);
        }

        public static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            //list.Add(123);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(list[3]);
        }

    }
}

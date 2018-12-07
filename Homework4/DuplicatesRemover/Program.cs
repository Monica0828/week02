using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(5);
            list.AddBefore(list.First, 3);
            list.AddBefore(list.First, 5);
            list.AddBefore(list.First, 3);
            list.AddBefore(list.First, 4);
            list.AddBefore(list.First, 4);
            list.AddBefore(list.First, 5);

            Console.WriteLine("Linked list before removing elements");
            foreach (var elem in list)
            {
                Console.Write(elem + " ");
            }
            //5 4 4 3 5 3 5 
            //0 1 2 3 4 5 6 

            //bool ok = false;
            for (int i = 0; i < list.Count - 1; i++)
            {
                var x = list.ElementAt(i);
                for (int j = i + 1; j < list.Count; j++)
                {                   
                    var y = list.ElementAt(j);
                    if (x == y)
                    {
                        list.Remove(y);
                        
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Linked list after removing elements");
            foreach (var elem in list)
            {
                Console.Write(elem + " ");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_connected_list
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> Names = new DoublyLinkedList<string>();
            Names.Add("Dima");
            Names.Add("Vika");
            Names.Add("Vadim");
            Names.AddFirst("Masha");

            foreach(var n in Names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine('\n');
            
            Names.Remove("Masha");
            Names.Remove("Sasha");
            foreach (var n in Names)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}

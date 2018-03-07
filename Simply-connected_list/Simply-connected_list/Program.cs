using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simply_connected_list
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> people = new LinkedList<string>();

            //add element
            people.Add("Dima");
            people.Add("Vika");
            people.Add("Vadim");
            people.Add("Anton");
            people.Add("Masha");

            //show elements (IEnumerable)
            Console.WriteLine("List: ");
            foreach(var p in people)
            {
                Console.WriteLine(p);
            }

            //remove element
            people.Remove("Anton");

            Console.WriteLine("\nAfter remove 'Anton'");
            people.Show();

            //is element in list?
            Console.WriteLine("\nIs element in list");

            bool isEl = people.Constrain("Vika");
            Console.WriteLine(isEl ? "Vika exist" : "Vika not exist");
            isEl = people.Constrain("Anton");
            Console.WriteLine(isEl ? "Anton exist" : "Anton not exist");

            //add element as first
            Console.WriteLine("\nAdd 'Sasha' in first position");
            people.AppendFirst("Sasha");
            people.Show();

            Console.ReadKey();


        }
    }
}

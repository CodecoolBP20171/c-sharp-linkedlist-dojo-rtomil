using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkdList list = new LinkdList();
            list.Add(1);
            list.Add(2);

            Console.WriteLine("tostring with 2 elements " + list.ToString());
            //Console.WriteLine(list.Count);

            list.Remove(2);
            Console.WriteLine("tostring with one remove " + list.ToString());

            Console.ReadKey();
        }
    }
}

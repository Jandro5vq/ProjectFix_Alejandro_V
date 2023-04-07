using System;
using System.Collections.Generic;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====> Unordered list: ");
            List<int> list = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                list.Add(Utils.random.Next());
                Console.WriteLine(list[i]);
            }

            list.Sort();
            Console.WriteLine("\n=====> Ordered list: ");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

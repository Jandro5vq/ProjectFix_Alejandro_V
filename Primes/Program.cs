using System;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            float num;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine(num + ": is prime");
            }
            else
            {
                Console.WriteLine(num + ": is not prime");
            }
        }
        public static bool IsPrime(float number)
        {
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            //TODO
            return true;
        }
    }
}

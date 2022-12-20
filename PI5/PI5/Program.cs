using System;

namespace PI5
{
    public class Program
    {
        public static long factorial(int fact)
        {
            int h1 = fact;
            long h2 = 1;
            if (fact == 0)
                return 1;
            else
            {
                for (int i = 1; i <= h1; i++)
                {
                    h2 *= i;
                }
            }
            return h2;
        }
        static void Main(string[] args)
        {

            Console.WriteLine( factorial(6));
        }
    }
}

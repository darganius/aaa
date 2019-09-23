using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int dx = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=10; i+=dx)
            {
                if (c < 0 && a != 0) f = -a * (x * x);
                else if (c > 0 && a == 0) f = (a - x) / (c * x);
                else f = x / c;
                Console.WriteLine(f);
                Console.ReadKey();
            }
        }
    }
}

using System;

namespace Prg_5_i_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2, b=3, c=5;
            b=a++ + b++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereCifreEgale
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    for(int k = 1; k <= i; k++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

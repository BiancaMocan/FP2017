using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDiagonala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dimensiunea matricii: ");
            int n = int.Parse(Console.ReadLine());
            int[,] m = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine("Elementul m[{0},{1}]", i,j);
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int suma_returnata = suma_deasupra_diagonala(m);
            Console.WriteLine("Suma deasupra diagonala este: {0}", suma_returnata);
            Console.ReadKey();
        }

        static int suma_deasupra_diagonala(int[,] m1)
        {
            int suma = 0;
            int i = 0;
            //parcurg liniile
            while (i < m1.GetLength(0) - 1)
            {
                int j = i + 1;
                //parcurg coloanele
                while (j < m1.GetLength(1))
                {
                    suma = suma + m1[i, j];
                    j++;
                }
                i++;
            }
            return suma;
        }
    }
}

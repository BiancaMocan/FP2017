using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numar elemente =");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            citire_vector(v);
            subsir(v);
            Console.ReadKey();
        }

        static void citire_vector(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("vect[{0}] = ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        private static void subsir(int[] v)
        {
            int lung_max = 0, poz_initiala = 0, poz_finala = 0, i = 0;

            while (i < v.Length - 1)
            {
                if (v[i] == 0)
                {
                    int temp_poz_initiala = i, temp_poz_finala = 0, temp_lung = 0;
                    Boolean diferit_de_zero = false; int j;
                    for (j = i + 1; j < v.Length && !diferit_de_zero; j++)
                    {
                        if (v[j] != 0)
                        {
                            diferit_de_zero = true; temp_poz_finala = j - 1; temp_lung = j - i; i = j;
                        }
                    }
                    if (j == v.Length && !diferit_de_zero)
                    {
                        temp_poz_finala = j - 1; temp_lung = j - i;i = j;
                    }
                    if (temp_lung > lung_max)
                    {
                        lung_max = temp_lung;
                        poz_initiala = temp_poz_initiala;
                        poz_finala = temp_poz_finala;
                    }
                }
                i++;
            }
            Console.WriteLine("Lungime maxima este {0}, de la {1} pana la {2}.", lung_max, poz_initiala, poz_finala);
        }
    }
}

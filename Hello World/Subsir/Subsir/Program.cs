﻿using System;
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
                    int aux_poz_initiala = i, aux_poz_finala = 0, aux_lung = 0;
                    Boolean stop = false; int j;
                    for (j = i + 1; j < v.Length && !stop; j++)
                    {
                        if (v[j] != 0)
                        {
                            stop = true; aux_poz_finala = j - 1; aux_lung = j - i; i = j;
                        }
                    }
                    if (j == v.Length && !stop)
                    {
                        aux_poz_finala = j - 1; aux_lung = j - i;
                    }
                    if (aux_lung > lung_max)
                    {
                        lung_max = aux_lung;
                        poz_initiala = aux_poz_initiala;
                        poz_finala = aux_poz_finala;
                    }
                }
                i++;
            }
            Console.WriteLine("Lungime maxima este {0}, de la {1} pana la {2}.", lung_max, poz_initiala, poz_finala);
        }
    }
}

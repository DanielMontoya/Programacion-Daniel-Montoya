using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[9] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int mayor = 4;
            int menor = 4;

            foreach (int element in numeros)
                {
                if (element> mayor)
                {
                    mayor = element;
                }

                if (element < menor)
                {
                    menor = element;
                }
            }

            Console.WriteLine("El numero mayor es {0} y el menor es {1}", mayor, menor);
            Console.ReadKey();
        }
    }
}

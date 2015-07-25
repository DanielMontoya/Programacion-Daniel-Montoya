using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el radio del cilindro");                       
            decimal r = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Escribe la altura del cilindro");
            decimal h = Convert.ToDecimal(Console.ReadLine());

            decimal V = h * (r * r) * 3.1415m;
            decimal A = 2 * (r * r) * (3.1415m) + (2 * 3.1415m * r * h);

            Console.WriteLine("El Volumen es {0}",V);
            Console.WriteLine("El Area es {0}",A);
                        
            Console.ReadKey();
                         
        }
    }
}

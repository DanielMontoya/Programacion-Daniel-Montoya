using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        enum dias { Domingo = 1, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado };

        static void Main(string[] args)
        {
             
            Console.WriteLine("Escribe un numero del 1 al 7");            
            int END = 0;
            while (END == 0)
            {
                string Dia = Console.ReadLine();
                switch (Dia)
                {
                    case "1":
                        Console.WriteLine(dias.Domingo);
                        break;
                    case "2":
                        Console.WriteLine(dias.Lunes);
                        break;
                    case "3":
                        Console.WriteLine(dias.Martes);
                        break;
                    case "4":
                        Console.WriteLine(dias.Miercoles);
                        break;
                    case "5":
                        Console.WriteLine(dias.Jueves);
                        break;
                    case "6":
                        Console.WriteLine(dias.Viernes);
                        break;
                    case "7":
                        Console.WriteLine(dias.Sabado);
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
           
        }

    }
}

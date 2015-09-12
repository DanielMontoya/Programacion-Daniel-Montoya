using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto9v1
{
    class Program
    {
       

        public static void Main(string[] args)
        {
            bool correct = true;           
            int i = 0;
            do
            {
                Console.WriteLine("¿Cual es la zona destino? (zona1, zona2, zona3, zona4)");
                string Zona = Console.ReadLine();
                Console.WriteLine("¿Cual es el precio del item? (entero)");
                int p = 0;

                correct = int.TryParse(Console.ReadLine(), out p);
                double result = 0;
                switch (Zona)
                {

                    case "zona1":
                        result = p*0.25;
                        break;
                    case "zona2":
                        result = p* 0.12 + 25;
                        break;
                    case "zona3":
                        result =  p* 0.08;
                        break;
                    case "zona4":
                        result = p* 0.04 + 25;
                        break;
                    case "exit":
                        i++;
                        break;
                    default:
                        correct = false;
                        break;

                }

                if (correct == true)
                {                    
                    Console.WriteLine("El fee es de {0}", result);
                }
                else
                    Console.WriteLine("Error en el calculo");
            }
            while (i == 0);

        }

       
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto9v1
{
    class Program
    {
        public delegate double CalculadorFees(double precio);

        public static void Main(string[] args)
        {
            bool correct = true;
            CalculadorFees calculadora = CalcZone1;
            int i = 0;
            do
            {
                Console.WriteLine("¿Cual es la zona destino? (zona1, zona2, zona3, zona4)");
                string Zona = Console.ReadLine();
                Console.WriteLine("¿Cual es el precio del item? (entero)");
                int precio = 0;
                                
                correct = int.TryParse(Console.ReadLine(), out precio);

                switch (Zona)
                {

                    case "zona1":
                        calculadora = CalcZone1;                        
                        break;
                    case "zona2":
                        calculadora = CalcZone2;                        
                        break;
                    case "zona3":
                        calculadora = CalcZone3;                        
                        break;
                    case "zona4":
                        calculadora = CalcZone4;                        
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
                    double resultado = calculadora(precio);
                    Console.WriteLine("El fee es de {0}", resultado);
                }
                else
                    Console.WriteLine("Error en el calculo");
            }
            while (i == 0);

        }

        public static double CalcZone1(double p)
        {
            return p * 0.25;
        }

        public static double CalcZone2(double p)
        {
            return p * 0.12 + 25;
        }

        public static double CalcZone3(double p)
        {
            return p * 0.08;
        }

        public static double CalcZone4(double p)
        {
            return p * 0.04 + 25;
        }
       }


    }



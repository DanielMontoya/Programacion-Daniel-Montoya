using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto9v1
{
    public class Calculadora
    {        
        public double Resultado;
        public Calculadora()
        {
           
        }

        public void calcular1(double precio)
        { Resultado = precio* 0.25;
        }
        public void calcular2(double precio)
        { Resultado = precio * 0.12 + 25;
        }
        public void calcular3(double precio)
        { Resultado = precio * 0.08;
        }
        public void calcular4(double precio)
        { Resultado = precio* 0.04 + 25;
        }

        public double obtain()
        {
            return Resultado;
        }




    }
    class Program
    {
        public delegate double CalculadorFees(double precio);

        public static void Main(string[] args)
        {
            bool correct = true;
            Calculadora calculadora = new Calculadora();
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
                        calculadora.calcular1(precio);
                        break;
                    case "zona2":
                        calculadora.calcular2(precio);
                        break;
                    case "zona3":
                        calculadora.calcular3(precio);
                        break;
                    case "zona4":
                        calculadora.calcular4(precio);
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
                    
                    Console.WriteLine("El fee es de {0}", + calculadora.Resultado);
                }
                else
                    Console.WriteLine("Error en el calculo");
            }
            while (i == 0);

        }
                
    }


}



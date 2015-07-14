using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamaño = 0;
            string rango = "";
            Console.WriteLine("¿Que variable deseas investigar?, ingresa el numero que le corresponda");
            string variable;
            Console.WriteLine(" ");
            Console.WriteLine("1: Byte");
            Console.WriteLine("2: SByte");
            Console.WriteLine("3: int32");
            Console.WriteLine("4: Uint32");
            Console.WriteLine("5: int16");
            Console.WriteLine("6: Uint16");
            Console.WriteLine("7: int64");
            Console.WriteLine("8: Uint64");
            Console.WriteLine("9: Single");
            Console.WriteLine("10: Double");
            Console.WriteLine("11: Char");
            Console.WriteLine("12: Boolean");
            Console.WriteLine("13: Object");
            Console.WriteLine("14: String");
            Console.WriteLine("15: Decimal");
            Console.WriteLine("");

            variable = Console.ReadLine();
            switch (variable)
                {
                    case "1":
                        {
                            tamaño = 8;
                            rango = "0 a 255";
                        }
                        break;
                    case "2":
                        {
                            tamaño = 8;
                            rango = "-128 a 127";
                        }
                        break;
                    case "3":
                        {
                            tamaño = 32;
                            rango = "-2.147.483.648 a 2.147.483.647";
                        }
                        break;
                    case "4":
                        {
                            tamaño = 32;
                            rango = "0 a 4294967295";
                        }
                        break;
                    case "5":
                        {
                            tamaño = 16;
                            rango = "-32.768 a 32.767";
                        }
                        break;
                    case "6":
                        {
                            tamaño = 16;
                            rango = "0 a 65535";
                        }
                        break;
                    case "7":
                        {
                            tamaño = 64;
                            rango = "-922337203685477508 a 922337203685477507";
                        }
                        break;
                    case "8":
                        {
                            tamaño = 64;
                            rango = "0 a 18446744073709551615";
                        }
                        break;
                    case "9":
                        {
                            tamaño = 32;
                            rango = "-3,402823e38 a 3,402823e38";
                        }
                        break;
                    case "10":
                        {
                            tamaño = 64;
                            rango = "-1,79769313486232e308 a 1,79769313486232e308";
                        }
                        break;
                    case "11":
                        {
                            tamaño = 16;
                            rango = "Símbolos Unicode utilizados en el texto";
                        }
                        break;
                    case "12":
                        {
                            tamaño = 8;
                            rango = "True o false";
                        }
                        break;
                    case "13":
                        {
                            tamaño = 64;
                            rango = "sin rango";
                        }
                        break;
                    case "14":
                        {
                            tamaño = 16;
                            rango = "sin rango";
                        }
                        break;
                    case "15":
                        {
                            tamaño = 8;
                            rango = "±1.0 × 10e−28 a ±7.9 × 10e28";
                        }
                        break;

                    default:
                        { Console.WriteLine("ERROR"); }
                        break;
                }

            Console.WriteLine("", tamaño);
            Console.WriteLine("El tamaño en bits de la variable es de: {0}", tamaño);
            Console.WriteLine("El rango de la variable es de: {0}", rango);
            Console.WriteLine("");
            Console.WriteLine("Fin del programa");

        }
        
    }
}

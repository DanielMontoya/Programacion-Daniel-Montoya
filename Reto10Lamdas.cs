﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoS10
{
    public delegate void EventoBalance(int valor);

    class Cerdo
    {
        public event EventoBalance Cambio;

        private int Dinero;
        public int dinero
        {
            set
            {
                Dinero += value;
                //activa el evento que activa el metodo
                maximo();                
            }
            get
            {
                return Dinero;
            }            
        }
        //metodo que activa el evento
        public void maximo ()
        {
            Cambio(Dinero);
        }            
    }
    class Program
    {       
        public static void Main(string[] args)
        {
            //creo el objeto que llamara los eventos
            Cerdo Piggy = new Cerdo();
            //subscribo un metodo
            Piggy.Cambio += (int valor) => Console.WriteLine("The balance amount is {0}", valor);
                                
            bool holder;
            do
            {
                Console.WriteLine("How much to deposit?");
                //cambio el valor del Dinero, lo que activa el evento        

                int holderDinero = 0;
                holder = Int32.TryParse(Console.ReadLine(), out holderDinero);

                Piggy.dinero = holderDinero;

                //subscribo el segundo metodo 
                if (Piggy.dinero >= 500)
                {
                    Piggy.Cambio += (int valor) => { Console.WriteLine("You have reached your savings goal¡ You have {0}", valor); Console.WriteLine("Exit"); Console.ReadKey(); } ;
                    //no funciona quitar la subscribcion con el uso de lamdas
                    Piggy.Cambio -= (int valor) => Console.WriteLine("The balance amount is {0}", valor);
                    Piggy.maximo();

                };

            } while((Piggy.dinero < 500) & (holder));
            
        }
       
    }
}

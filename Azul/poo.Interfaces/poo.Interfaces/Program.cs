using System;
using System.Threading.Channels;

namespace poo.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            carro carro = new carro();
            Console.WriteLine(carro.marca("Honda"));
            Console.WriteLine(carro.motor(2.1));
            Console.WriteLine(carro.ruedas(4));
            Console.WriteLine(carro.color("Negro"));

            Barco barco = new Barco();
            Console.WriteLine(barco.color("blanco"));
            Console.WriteLine(barco.marca("Honda"));
            Console.WriteLine(barco.motor(5.0));
            Console.WriteLine(barco.ruedas(0));
        }
    }
}
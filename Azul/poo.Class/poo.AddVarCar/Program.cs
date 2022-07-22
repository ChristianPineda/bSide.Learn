 using System;

namespace poo.AddVarCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            
            if(carro.Arrancar("Ford"))
            {
                Console.WriteLine("El carro " +carro.marca + " arrancó");
            }
            else
            {
                Console.WriteLine("El carro " + carro.marca + " no arrancó");
            }

            if (carro.Acelerar())
            {
                Console.WriteLine("El carro " + carro.marca + " aceleró");
            }
            else
            {
                Console.WriteLine("El carro " + carro.marca + " no aceleró");
            }

            if (carro.Frenar())
            {
                Console.WriteLine("El carro " + carro.marca + " frenó");
            }
            else
            {
                Console.WriteLine("El carro " + carro.marca + " no frenó");
            }
            Console.ReadKey();
        }
    }

    class Carro
    {
        public String marca;
        public bool aceleracion = false;
        public bool arranque = false;
        public bool freno = false;

        public bool Arrancar(string marca)
        {
            this.marca = marca;

            if (!arranque && !aceleracion && !freno)
            {
                this.arranque = true;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Acelerar()
        {
            if (arranque && !aceleracion && !freno)
            {
                this.aceleracion = true;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Frenar()
        {
            if (arranque && aceleracion && !freno)
            {
                this.freno = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

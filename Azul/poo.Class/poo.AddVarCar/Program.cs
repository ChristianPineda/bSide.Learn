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
                Console.WriteLine("El carro " +carro.Marca + " arrancó");
            }
            else
            {
                Console.WriteLine("El carro " + carro.Marca + " no arrancó");
            }

            if (carro.Acelerar())
            {
                Console.WriteLine("El carro " + carro.Marca + " aceleró");
            }
            else
            {
                Console.WriteLine("El carro " + carro.Marca + " no aceleró");
            }

            if (carro.Frenar())
            {
                Console.WriteLine("El carro " + carro.Marca + " frenó");
            }
            else
            {
                Console.WriteLine("El carro " + carro.Marca + " no frenó");
            }
            Console.ReadKey();
        }
    }

    class Carro
    {
        public String Marca;
        public bool Aceleracion = false;
        public bool Arranque = false;
        public bool Freno = false;

        public bool Arrancar(string marca)
        {
            this.Marca = marca;

            if (!Arranque && !Aceleracion && !Freno)
            {
                this.Arranque = true;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Acelerar()
        {
            if (Arranque && !Aceleracion && !Freno)
            {
                this.Aceleracion = true;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Frenar()
        {
            if (Arranque && Aceleracion && !Freno)
            {
                this.Freno = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;

namespace poo.Heredity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carro carro = new carro("Ford"); //Heredan todos, los métodos de la clase padre (o superclase)
            carro.Arrancar();
            carro.Acelerar();
            carro.AbrirPuertas();
            carro.Frenar();
            carro.PrintMarca();
            //Heredan también métodos "naturales" del lenguaje como equals, gethashcode, gettype y tostring (toint, etc)
            barco barco = new barco("Honda");
            barco.Acelerar();
            barco.LevantarAncla();
            barco.Arrancar();
            barco.Frenar();
            carro.PrintMarca();
            moto moto = new moto("Harley");
            moto.LevantarPata();
            moto.Acelerar();
            moto.Arrancar();
            moto.Frenar();
            moto.PrintMarca();
        }

        class vehiculo
        {
            string marca;
            public vehiculo(string marca) //Si requerimos algo en la superclase, lo requieren también los heredados
            {
                
            }
            public void Arrancar()
            {
                Console.WriteLine("Arrancó");
            }

            public void Acelerar()
            {
                Console.WriteLine("Aceleró");
            }

            public void Frenar()
            {
                Console.WriteLine("Frenó");
            }

            public void PrintMarca()
            {
                Console.WriteLine("La marca es: " + this.marca );
            }
        }

        class carro : vehiculo //Con los dos puntos ya hereda
        {
            public carro(string marca) : base(marca) //Se manda desde el constructor de la herencia, hacia la superclase
            {
                
            }

            public void AbrirPuertas()
            {
                Console.WriteLine("Abrió las puertas");
            }
        }

        class barco : vehiculo
        {
            public barco(string marca) : base(marca)
            {

            }
            public void LevantarAncla()
            {
                Console.WriteLine("Se levantó el ancla");
            }
        }

        class moto : vehiculo
        {
            public moto(string marca) : base(marca)
            {

            }
            public void LevantarPata()
            {
                Console.WriteLine("Se levantó la pata");
            }
        }
    }
}

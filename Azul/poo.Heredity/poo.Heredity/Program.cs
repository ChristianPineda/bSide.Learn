using System;

namespace poo.Heredity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carro carro = new carro();
            carro.Arrancar();
            carro.Acelerar();
            carro.AbrirPuertas();
            carro.Frenar();

            barco barco = new barco();
            barco.Acelerar();
            barco.LevantarAncla();
            barco.Arrancar();
            barco.Frenar();

            moto moto = new moto();
            moto.LevantarPata();
            moto.Acelerar();
            moto.Arrancar();
            moto.Frenar();
        }

        class vehiculo
        {
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
        }

        class carro : vehiculo //Con los dos puntos ya hereda
        {
            public void AbrirPuertas()
            {
                Console.WriteLine("Abrió las puertas");
            }
        }

        class barco : vehiculo
        {
            public void LevantarAncla()
            {
                Console.WriteLine("Se levantó el ancla");
            }
        }

        class moto : vehiculo
        {
            public void LevantarPata()
            {
                Console.WriteLine("Se levantó la pata");
            }
        }
    }
}

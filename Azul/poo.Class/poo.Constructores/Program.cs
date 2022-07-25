using System;

namespace poo.Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(); //Instanciar
            Console.WriteLine(carro.getInformationCarro());
        }
    }

    class Carro
    {
        private int puertas;
        private string color;
        private double motor;
        public Carro() //El constructor no lleva void u otro tipo y debe llamarse igual que la clase
        {
            //Determina constantes, valores inciales
            this.puertas = 4;
            this.color = "Rojo";
            this.motor = 2.1;
        }
        //Pueden haber varios constructores
        public String getInformationCarro() //Creas un método público que consume datos privados, para que no los puedan modificar
        {
            return "El carro tiene " + this.puertas + " puertas,es de color " + this.color + " y tiene un motor de versión " + this.motor;
        }
    }
}

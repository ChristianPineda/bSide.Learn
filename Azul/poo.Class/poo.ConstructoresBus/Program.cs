using System;

namespace poo.ConstructoresBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ViajeBus viaje = new ViajeBus(10);
            
            Console.WriteLine(viaje.getInforViaje());
            viaje.AgregarPersonas(1);
            
            Console.WriteLine(viaje.getInforViaje());
            viaje.EliminarPersonas(8);
            
            Console.WriteLine(viaje.getInforViaje());
        }
    }

    class ViajeBus
    {
        private int inipersonas;
        private int personas;


        public ViajeBus(int inipersonas)
        { 
            this.inipersonas = inipersonas;
            this.personas = inipersonas;
        }

        public string getInforViaje()
        {
            return " El viaje inició con " + this.inipersonas + " personas y actualmente tiene " + this.personas;
        }

        public void AgregarPersonas(int personas)
        {
            this.personas += personas;
        }

        public void EliminarPersonas(int personas)
        {
            this.personas -= personas;
        }
    }
}

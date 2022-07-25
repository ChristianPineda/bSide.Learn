using System;

namespace poo.ConstructoresBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco cuenta = new("Christian", 100);
            
            Console.WriteLine(cuenta.getInforBanco());

            cuenta.AgregarMonto(100);

            Console.WriteLine(cuenta.getInforBanco());

            cuenta.EliminarMonto(50);

            Console.WriteLine(cuenta.getInforBanco());
        }
    }

    class Banco
    {
        private double montoini;
        private double monto;
        string nombre;

        public Banco(string nombre, int montoini)
        {
            this.nombre = nombre;
            this.montoini = montoini;
            this.monto = montoini;
        }

        public string getInforBanco()
        {
            if (this.monto == this.montoini)
            {
                return "La persona " + this.nombre + " no ha hecho movimientos en el banco";
            }
            else
            {
                return "La persona " + this.nombre + " tiene un saldo inicial de " + this.montoini + " y actualmente tiene " + this.monto;
            }
        }

        public void AgregarMonto(double monto)
        {
            if (monto > 0)
            {
                this.monto += monto;
            }
        }

        public void EliminarMonto(double monto)
        {
            if (monto > 0)
            {
                if((this.monto - monto) > 0)
                this.monto -= monto;
                else this.monto = 0;
            }
        }
    }
}

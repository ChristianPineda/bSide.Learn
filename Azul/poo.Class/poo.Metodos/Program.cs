using System;

namespace poo.Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.n1 = 0;
            op.n2 = 5;

            Console.WriteLine("Suma: " + op.sumar());
            Console.WriteLine("Resta: " + op.restar());
            Console.WriteLine("Multiplicación: " + op.multiplicar());
            Console.WriteLine("División: " + op.dividir());
            Console.Read();
        }
    }

    class Operaciones
    {
        public double n1;
        public double n2;
        
        public double sumar()
        {
            return n1 + n2;
        }

        public double restar()
        {
            if (n1 > n2)
            {
                return n1 - n2;
            }
            else
            {
                return n2 - n1;
            }
        }

        public double multiplicar()
        {
            return n1 * n2;
        }

        public double dividir()
        {
            if (n1 > 0 && n2 > 0)
            {
                return n1 / n2;
            }
            else
            {
                return 0;
            }
        }
    }
}

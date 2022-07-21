using System;

namespace poo.AddVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del círculo");

            AreaCirculo area = new AreaCirculo();

            double radio = area.Area(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("El area del círculo es: {0}", radio);
            Console.ReadKey();
        }
    }

    public class AreaCirculo
    {
        public double Area(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}

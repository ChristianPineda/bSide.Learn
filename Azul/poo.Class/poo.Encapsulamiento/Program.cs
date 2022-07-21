using System;

namespace poo.Encapsulamiento
    //Public: Nivel de acceso más bajo, todos pueden acceder.
    //Protected: Sólo sus propias clases pueden acceder a esa clase.
    //Private: Se declaran sólo miembros accesibles.
    
    //Los nombres de las public van con mayúscula al inicio de cada palabra por convención PascalCase
    //Los nombres de las private y protected van con minúscula al inicio por convención camelCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Convertir convertir = new Convertir();

            convertir.CambiarQuetzales(9);

            Console.WriteLine(convertir.Convert(10));

            Console.ReadKey();
        }
    }
    
    class Convertir
    {
        double quetzales = 7.69;

        public double Convert(double dollar)
        {
            double r = dollar * quetzales;
            return r;
        }
        
        public void CambiarQuetzales(double quetzalesMod)
        {
            this.quetzales = quetzalesMod;
        }
    }
}

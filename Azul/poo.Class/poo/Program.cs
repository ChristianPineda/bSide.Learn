using System;

namespace poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewClass newClass = new NewClass(); //instanciar
            newClass.Hello(); //Llamado a método

            NewClass newClass2 = new NewClass(); //instanciar
            newClass2.Bye();
        }
    }

    class NewClass
    {
        public void Hello() //Encapsulación
        {
            Console.WriteLine("Hello World!");
        }
        
        public void Bye()
        {
            Console.WriteLine("Bye World!");
        }
    }
}

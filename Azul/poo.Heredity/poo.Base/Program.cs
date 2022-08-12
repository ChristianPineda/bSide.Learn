using System;
using System.Runtime.CompilerServices;

namespace poo.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Tecnico tecnico = new Tecnico("Ema","Rodhes", 001);
            tecnico.GetInfoEmpleado();

            Secretaria secretaria = new Secretaria("Noemi", "Soto", 002);
            secretaria.GetInfoEmpleado();

            Conserje conserje = new Conserje("Pedro", "Molina", 003);
            conserje.GetInfoEmpleado();
            conserje.GetHashCode();
        }
    }

    class Empleado
    {
        private string nombre;
        private string apellido;
        private int clave;

        public Empleado(string nombre, string apellido, int clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
        }
        public void GetInfoEmpleado()
        {
            Console.WriteLine("La clave del empleado "+ this.nombre + " " + this.apellido+" es: "+ this.clave);
        }
    }

    class Tecnico : Empleado
    {
        public Tecnico(string nombre, string apellido, int clave) : base(nombre, apellido, clave)
        {

        }
        public void Analizar()
        {
            Console.WriteLine("El técnico está analizando");
        }
    }
    class Secretaria : Empleado
    {
        public Secretaria(string nombre, string apellido, int clave) : base(nombre, apellido, clave)
        {
            
        }
        public void Archivar()
        {
            Console.WriteLine("La secretaria está archivando");
        }
    }
    class Conserje : Empleado
    {
        public Conserje(string nombre, string apellido, int clave) : base(nombre, apellido, clave)
        {
            
        }
        public void Barrer()
        {
            Console.WriteLine("El conserje está barriendo");
        }
    }
}
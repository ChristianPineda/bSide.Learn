using System;

namespace poo.Polimorfismo
{
    class Program
    {
        static void Main()
        {
            Tecnico tecnico = new Tecnico("Ema", "García", 1);
            tecnico.Marcar();
        }
    }

    class Empleado
    {
        private string _nombre;
        private string _apellido;
        private int _clave;

        public Empleado(string nombre, string apellido, int clave)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._clave = clave;
        }
        public void GetInfoEmpleado()
        {
            Console.WriteLine("La clave del empleado "+ this._nombre + " " + this._apellido+" es: "+ this._clave);
        }

        public virtual void Marcar() //Puede llamarse desde otros
        {
            Console.WriteLine("Marcó asistencia "+DateTime.Now);
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

        public override void Marcar()
        {
            base.Marcar();
            Console.WriteLine("El técnico marco desde un método virtual");
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
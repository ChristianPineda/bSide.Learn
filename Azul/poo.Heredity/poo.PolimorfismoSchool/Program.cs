using System;

namespace poo.PolimorfismoSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matemáticas");
            Matematica materia1 = new Matematica();
            materia1.Calificacion();
            Console.WriteLine("Música");
            Musica materia2 = new Musica();
            materia2.Calificacion();
            Console.WriteLine("Lengua");
            Lengua materia3 = new Lengua();
            materia3.Calificacion();
            Console.WriteLine("Computacion");
            Computacion materia4 = new Computacion();
            materia4.Calificacion();
        }
    }

    class Materia
    {
        private string name;
        public Materia(string name)
        {
            this.name = name;
        }

        public void GetInfoMateria()
        {
            Console.WriteLine("Materia: " + name);
        }

        public virtual void Calificacion()
        {
            Console.WriteLine("La forma de calificar es la establecida por el colegio");
        }
    }
    
    class Matematica:Materia
    {
        public Matematica():base("Matemáticas")
        {
            
        }

        new public void Calificacion()
        {
            Console.WriteLine("Mínimo de calificación: 60");
        }
    }
    class Lengua:Materia
    {
        public Lengua():base("Lenguaje")
        {
            
        }

        public override void Calificacion()
        {
            Console.WriteLine("Si hablas más de dos idiomas, pasasla materia");
        }
    }
    class Musica:Materia
    {
        public Musica():base("Música")
        {
            
        }

        public override void Calificacion()
        {
            base.Calificacion();
            Console.WriteLine("Si traes instrumento, pasas la materia");
        }
    }
    class Computacion:Materia
    {
        public Computacion():base("Computación")
        {
            
        }
    }
}
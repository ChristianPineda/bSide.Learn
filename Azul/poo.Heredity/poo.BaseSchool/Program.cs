using System;

namespace poo.BaseSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematicas materia1 = new Matematicas("Ema", 59);
            materia1.GetInfoMateria();

            Musica materia2 = new Musica("Manuel", 54);
            materia2.GetInfoMateria();

            Lenguaje materia3 = new Lenguaje("Mary", 44);
            materia3.GetInfoMateria();
        }
    }

    class Materia
    {
        private string name;
        private string teacher;
        private int students;

        public Materia(string name, string teacher, int students)
        {
            this.name = name;
            this.teacher = teacher;
            this.students = students;
        }

        public void GetInfoMateria()
        {
            Console.WriteLine("La materia: "+this.name+" impartida por "+this.teacher+" tiene "+this.students+" estudiantes");
        }
    }
    class Matematicas:Materia
    {
        public Matematicas(string teacher, int students) : base("Matemáticas", teacher, students)
        {
                
        }
    }

    class Musica : Materia
    {
        public Musica(string teacher, int students) : base("Música", teacher, students)
        {
                
        }
    }

    class Lenguaje : Materia
    {
        public Lenguaje(string teacher, int students) : base("Lenguaje", teacher, students)
        {
                
        }
    }
}
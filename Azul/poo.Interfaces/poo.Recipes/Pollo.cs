using System;
using poo.Recipes.Interfaces;

namespace poo.Recipes
{
    public class pollo:Recetas,IRecetas,ICalentar, ICalentar
    {
        public void CocinarPollo()
        {
            Console.WriteLine("Cociendo...");
        }

        public void LimpiarUtensilios()
        {
            Console.WriteLine("Limpiando utensilios...");
        }

        public void LimpiarIngredientes()
        {
            Console.WriteLine("Limpiando ingredientes...");
        }

        void IRecetas.LimpiarUtensilios()
        {
            Console.WriteLine("Limpiando...");
        }
        void IRecetas.LimpiarIngredientes()
        {
            Console.WriteLine("Limpiando...");
        }
    }
}
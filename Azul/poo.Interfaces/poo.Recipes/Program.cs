using System;
using poo.Recipes.Interfaces;

namespace poo.Recipes
{
    class Program
    {
        static void Main()
        {
            pollo pollo = new pollo();
            IRecetas recetas = pollo;
            ICalentar calentar = pollo;
            calentar.LimpiarUtensilios();
            recetas.LimpiarIngredientes();
        }
    }
}
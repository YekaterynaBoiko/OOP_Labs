using System;
using System.Text;

namespace Lab36_37_Task3
{
    /// <summary>
    /// Головний клас програми для роботи з кулінарним рецептом.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: складає рецепт, показує його картку та записує рецепт у файл.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Recipe recipe = new Recipe("Млинці", 4);
            recipe.AddIngredient(new Ingredient("Борошно", 250, 364));
            recipe.AddIngredient(new Ingredient("Молоко", 500, 52));
            recipe.AddIngredient(new Ingredient("Яйця", 120, 157));

            RecipePrinter printer = new RecipePrinter();
            printer.PrintCard(recipe);

            RecipeSaver recipeSaver = new RecipeSaver();
            recipeSaver.SaveToFile(recipe, "pancakes.txt");

            Console.WriteLine();
            Console.WriteLine("Рецепт записано у файл pancakes.txt");
        }
    }
}

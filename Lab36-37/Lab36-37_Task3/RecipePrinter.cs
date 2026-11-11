using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task3
{
    public class RecipePrinter
    {
        /// <summary>
        /// Виводить картку рецепта на екран.
        /// </summary>
        public void PrintCard(Recipe recipe)
        {
            Console.WriteLine($"===== {recipe.Title} =====");
            Console.WriteLine($"Кількість порцій: {recipe.Portions}");
            Console.WriteLine("Інгредієнти:");

            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"  - {ingredient.Name}: {ingredient.Grams} г");
            }

            Console.WriteLine($"Калорійність порції: {recipe.GetCaloriesPerPortion()} ккал");
        }
    }
}

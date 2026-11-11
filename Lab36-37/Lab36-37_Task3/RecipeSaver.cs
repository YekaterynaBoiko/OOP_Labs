using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab36_37_Task3
{
    public class RecipeSaver
    {
        /// <summary>
        /// Записує рецепт у текстовий файл.
        /// </summary>
        /// <param name="fileName">Ім'я файлу.</param>
        public void SaveToFile(Recipe recipe, string fileName)
        {
            List<string> lines = new List<string>();
            lines.Add($"{recipe.Title};{recipe.Portions}");

            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                lines.Add($"{ingredient.Name};{ingredient.Grams};{ingredient.CaloriesPer100Grams}");
            }

            File.WriteAllLines(fileName, lines);
        }
    }
}

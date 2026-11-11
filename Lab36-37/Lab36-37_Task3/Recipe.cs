using System;
using System.Collections.Generic;
using System.IO;

namespace Lab36_37_Task3
{
    /// <summary>
    /// Кулінарний рецепт із переліком інгредієнтів.
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Інгредієнти, що входять до рецепта.
        /// </summary>
        private readonly List<Ingredient> ingredients = new List<Ingredient>();
        public IReadOnlyList<Ingredient> Ingredients 
        { 
            get { return ingredients; } 
        }

        /// <summary>
        /// Назва страви.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Кількість порцій, на яку розрахований рецепт.
        /// </summary>
        public int Portions { get; }

        /// <summary>
        /// Створює рецепт без інгредієнтів.
        /// </summary>
        /// <param name="title">Назва страви.</param>
        /// <param name="portions">Кількість порцій.</param>
        public Recipe(string title, int portions)
        {
            Title = title;
            Portions = portions;
        }

        /// <summary>
        /// Додає інгредієнт до рецепта.
        /// </summary>
        /// <param name="ingredient">Інгредієнт, який потрібно додати.</param>
        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        /// <summary>
        /// Обчислює калорійність усієї страви.
        /// </summary>
        /// <returns>Кількість кілокалорій у всій страві.</returns>
        public int GetTotalCalories()
        {
            int total = 0;

            foreach (Ingredient ingredient in ingredients)
            {
                total += ingredient.GetCalories();
            }

            return total;
        }

        /// <summary>
        /// Обчислює калорійність однієї порції.
        /// </summary>
        /// <returns>Кількість кілокалорій в одній порції.</returns>
        public int GetCaloriesPerPortion()
        {
            return GetTotalCalories() / Portions;
        }
    }
}
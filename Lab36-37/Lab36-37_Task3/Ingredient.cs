namespace Lab36_37_Task3
{
    /// <summary>
    /// Інгредієнт страви.
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Назва інгредієнта.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Маса інгредієнта в грамах.
        /// </summary>
        public int Grams { get; }

        /// <summary>
        /// Калорійність 100 грамів інгредієнта.
        /// </summary>
        public int CaloriesPer100Grams { get; }

        /// <summary>
        /// Створює інгредієнт із вказаними характеристиками.
        /// </summary>
        /// <param name="name">Назва інгредієнта.</param>
        /// <param name="grams">Маса інгредієнта в грамах.</param>
        /// <param name="caloriesPer100Grams">Калорійність 100 грамів інгредієнта.</param>
        public Ingredient(string name, int grams, int caloriesPer100Grams)
        {
            Name = name;
            Grams = grams;
            CaloriesPer100Grams = caloriesPer100Grams;
        }

        /// <summary>
        /// Обчислює калорійність усієї маси інгредієнта.
        /// </summary>
        /// <returns>Кількість кілокалорій.</returns>
        public int GetCalories()
        {
            return Grams * CaloriesPer100Grams / 100;
        }
    }
}

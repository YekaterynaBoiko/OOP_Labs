namespace Lab38_40_Task4
{
    /// <summary>
    /// Страва з меню ресторану.
    /// </summary>
    public abstract class Dish
    {
        /// <summary>
        /// Назва страви.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Кухня, до якої належить страва.
        /// </summary>
        public string Cuisine { get; }

        /// <summary>
        /// Вид страви: перша, основна чи закуска.
        /// </summary>
        public abstract string Course { get; }

        /// <summary>
        /// Створює страву з указаною назвою та кухнею.
        /// </summary>
        /// <param name="name">Назва страви.</param>
        /// <param name="cuisine">Кухня, до якої належить страва.</param>
        protected Dish(string name, string cuisine)
        {
            Name = name;
            Cuisine = cuisine;
        }

        /// <summary>
        /// Повертає опис страви одним рядком.
        /// </summary>
        /// <returns>Рядок вигляду «Вид: назва (кухня)».</returns>
        public override string ToString()
        {
            return $"{Course}: {Name} ({Cuisine} кухня)";
        }
    }

    /// <summary>
    /// Перша страва.
    /// </summary>
    public abstract class Soup : Dish
    {
        /// <summary>
        /// Вид страви.
        /// </summary>
        public override string Course
        {
            get { return "Перша страва"; }
        }

        /// <summary>
        /// Створює першу страву.
        /// </summary>
        /// <param name="name">Назва страви.</param>
        /// <param name="cuisine">Кухня, до якої належить страва.</param>
        protected Soup(string name, string cuisine) : base(name, cuisine)
        {
        }
    }

    /// <summary>
    /// Основна страва.
    /// </summary>
    public abstract class MainCourse : Dish
    {
        /// <summary>
        /// Вид страви.
        /// </summary>
        public override string Course
        {
            get { return "Основна страва"; }
        }

        /// <summary>
        /// Створює основну страву.
        /// </summary>
        /// <param name="name">Назва страви.</param>
        /// <param name="cuisine">Кухня, до якої належить страва.</param>
        protected MainCourse(string name, string cuisine) : base(name, cuisine)
        {
        }
    }

    /// <summary>
    /// Закуска.
    /// </summary>
    public abstract class Appetizer : Dish
    {
        /// <summary>
        /// Вид страви.
        /// </summary>
        public override string Course
        {
            get { return "Закуска"; }
        }

        /// <summary>
        /// Створює закуску.
        /// </summary>
        /// <param name="name">Назва страви.</param>
        /// <param name="cuisine">Кухня, до якої належить страва.</param>
        protected Appetizer(string name, string cuisine) : base(name, cuisine)
        {
        }
    }
}
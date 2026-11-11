namespace Lab38_40_Task4
{
    /// <summary>
    /// Борщ — перша страва української кухні.
    /// </summary>
    public class Borscht : Soup
    {
        /// <summary>
        /// Створює порцію борщу.
        /// </summary>
        public Borscht() : base("Борщ", "українська")
        {
        }
    }

    /// <summary>
    /// Вареники з картоплею — основна страва української кухні.
    /// </summary>
    public class Varenyky : MainCourse
    {
        /// <summary>
        /// Створює порцію вареників.
        /// </summary>
        public Varenyky() : base("Вареники з картоплею", "українська")
        {
        }
    }

    /// <summary>
    /// Сало з часником — закуска української кухні.
    /// </summary>
    public class Salo : Appetizer
    {
        /// <summary>
        /// Створює порцію сала.
        /// </summary>
        public Salo() : base("Сало з часником", "українська")
        {
        }
    }
}

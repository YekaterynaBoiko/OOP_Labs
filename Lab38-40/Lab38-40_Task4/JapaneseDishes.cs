namespace Lab38_40_Task4
{
    /// <summary>
    /// Місо-суп — перша страва японської кухні.
    /// </summary>
    public class MisoSoup : Soup
    {
        /// <summary>
        /// Створює порцію місо-супу.
        /// </summary>
        public MisoSoup() : base("Місо-суп", "японська")
        {
        }
    }

    /// <summary>
    /// Суші з лососем — основна страва японської кухні.
    /// </summary>
    public class Sushi : MainCourse
    {
        /// <summary>
        /// Створює порцію суші.
        /// </summary>
        public Sushi() : base("Суші з лососем", "японська")
        {
        }
    }

    /// <summary>
    /// Едамаме — закуска японської кухні.
    /// </summary>
    public class Edamame : Appetizer
    {
        /// <summary>
        /// Створює порцію едамаме.
        /// </summary>
        public Edamame() : base("Едамаме", "японська")
        {
        }
    }
}

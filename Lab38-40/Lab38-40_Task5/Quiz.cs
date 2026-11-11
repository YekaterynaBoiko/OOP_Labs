namespace Lab38_40_Task5
{
    /// <summary>
    /// Тест на курсі навчальної системи.
    /// </summary>
    public class Quiz : IPrototype
    {
        /// <summary>
        /// Назва тесту, яку бачать студенти.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Максимальна кількість балів за тест.
        /// </summary>
        public int MaxPoints { get; }

        /// <summary>
        /// Кількість питань у тесті.
        /// </summary>
        public int QuestionCount { get; }

        /// <summary>
        /// Час на проходження тесту у хвилинах.
        /// </summary>
        public int TimeLimitMinutes { get; }

        /// <summary>
        /// Створює тест із указаними налаштуваннями.
        /// </summary>
        /// <param name="title">Назва тесту.</param>
        /// <param name="maxPoints">Максимальна кількість балів.</param>
        /// <param name="questionCount">Кількість питань.</param>
        /// <param name="timeLimitMinutes">Час на проходження у хвилинах.</param>
        public Quiz(string title, int maxPoints, int questionCount, int timeLimitMinutes)
        {
            Title = title;
            MaxPoints = maxPoints;
            QuestionCount = questionCount;
            TimeLimitMinutes = timeLimitMinutes;
        }

        public Quiz(Quiz other)
            : this(other.Title, other.MaxPoints, other.QuestionCount, other.TimeLimitMinutes)
        {
        }

        public IPrototype Clone() => new Quiz(this);

        public string GetType() => "Тест";

        /// <summary>
        /// Повертає опис тесту одним рядком.
        /// </summary>
        /// <returns>Назва та налаштування тесту.</returns>
        public override string ToString()
        {
            string settings = $"{MaxPoints} балів, {QuestionCount} питань, {TimeLimitMinutes} хв";
            return $"Тест «{Title}»: {settings}";
        }
    }
}
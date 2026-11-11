using System;
using System.Collections.Generic;

namespace Lab38_40_Task4
{
    /// <summary>
    /// Замовлення одного столу в ресторані.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Страви замовлення в порядку додавання.
        /// </summary>
        private readonly List<Dish> dishes = new List<Dish>();
        private readonly IDishFactory _dishFactory;

        public Order(IDishFactory dishFactory)
        {
            _dishFactory = dishFactory;
        }
        /// <summary>
        /// Страви замовлення, доступні лише для читання.
        /// </summary>
        public IReadOnlyList<Dish> Dishes
        {
            get { return dishes; }
        }

        /// <summary>
        /// Додає до замовлення першу страву з меню вказаної кухні.
        /// </summary>
        public void AddSoup() // тут був switch
        {
            dishes.Add(_dishFactory.CreateSoup());
        }

        /// <summary>
        /// Додає до замовлення основну страву з меню вказаної кухні.
        /// </summary>
        public void AddMainCourse()
        {
            dishes.Add(_dishFactory.CreateMainCourse());
        }

        /// <summary>
        /// Додає до замовлення закуску з меню вказаної кухні.
        /// </summary>
        public void AddAppetizer()
        {
            dishes.Add(_dishFactory.CreateAppetizer());
        }
    }
}
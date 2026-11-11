using System.Collections.Generic;

namespace Lab36_37_Task2
{
    /// <summary>
    /// Сумка ігрового персонажа з предметами.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Предмети, що зберігаються в сумці.
        /// </summary>
        private readonly List<GameItem> items = new List<GameItem>();

        /// <summary>
        /// Додає предмет до сумки.
        /// </summary>
        /// <param name="item">Предмет, який потрібно додати.</param>
        public void AddItem(GameItem item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Показує всі предмети із сумки.
        /// </summary>
        public void InspectAll()
        {
            foreach (GameItem item in items)
            {
                item.Inspect();
            }
        }

        /// <summary>
        /// Продає всі предмети із сумки та забирає їх звідти.
        /// </summary>
        /// <returns>Загальна кількість отриманих золотих монет.</returns>
        public int SellAll()
        {
            int gold = 0;

            foreach (GameItem item in items)
            {
                gold += item.Sell();
            }

            items.Clear();

            return gold;
        }
    }
}

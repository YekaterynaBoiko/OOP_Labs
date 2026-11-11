using System;
using System.Text;

namespace Lab36_37_Task1
{
    /// <summary>
    /// Головний клас програми для розрахунку місячного рахунку абонента.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: показує вартість послуг абонента за різними тарифами.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MobileBill bill = new MobileBill("+380671234567", 180, 12);

            Console.WriteLine($"Абонент: {bill.PhoneNumber}");
            Console.WriteLine($"Дзвінки: {bill.CallMinutes} хв");
            Console.WriteLine($"Інтернет: {bill.InternetGigabytes} ГБ");
            Console.WriteLine();
            bill.SetTariff(new StartTariff());
            PrintBill("Старт", bill);

            bill.SetTariff(new StudentTariff());
            PrintBill("Студент", bill);

            bill.SetTariff(new UnlimitedTariff());
            PrintBill("Безліміт", bill);
        }

        /// <summary>
        /// Виводить на екран вартість послуг і нараховані бонуси за поточним тарифом.
        /// </summary>
        /// <param name="tariffName">Назва тарифу для відображення.</param>
        /// <param name="bill">Рахунок абонента.</param>
        private static void PrintBill(string tariffName, MobileBill bill)
        {
            decimal cost = bill.GetMonthlyCost();
            int points = bill.GetBonusPoints();

            Console.WriteLine($"Тариф «{tariffName}»: {cost} грн, бонусних балів: {points}");
        }
    }
}

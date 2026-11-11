using System;

namespace Lab36_37_Task1
{
    /// <summary>
    /// Місячний рахунок абонента мобільного оператора.
    /// </summary>
    public class MobileBill 
    {
        /// <summary>
        /// Код тарифу, за яким обслуговується абонент.
        /// </summary>
        private ITariff tariff;

        /// <summary>
        /// Номер телефону абонента.
        /// </summary>
        public string PhoneNumber { get; }

        /// <summary>
        /// Кількість хвилин розмов за місяць.
        /// </summary>
        public int CallMinutes { get; }

        /// <summary>
        /// Обсяг використаного за місяць інтернету в гігабайтах.
        /// </summary>
        public int InternetGigabytes { get; }

        /// <summary>
        /// Створює рахунок абонента на основі даних про використання послуг.
        /// </summary>
        /// <param name="phoneNumber">Номер телефону абонента.</param>
        /// <param name="callMinutes">Кількість хвилин розмов за місяць.</param>
        /// <param name="internetGigabytes">Обсяг використаного інтернету в гігабайтах.</param>
        public MobileBill(string phoneNumber, int callMinutes, int internetGigabytes)
        {
            PhoneNumber = phoneNumber;
            CallMinutes = callMinutes;
            InternetGigabytes = internetGigabytes;
        }

        /// <summary>
        /// Встановлює тариф абонента.
        /// </summary>
        /// <param name="tariff">Код тарифу: "start", "student" або "unlimited".</param>
        public void SetTariff(ITariff tariff)
        {
            this.tariff = tariff;
        }


        /// <summary>
        /// Обчислює вартість послуг за місяць.
        /// </summary>
        /// <returns>Сума до сплати у гривнях.</returns>
        public decimal GetMonthlyCost()
        {
            return tariff.GetMonthlyCost(this);
        }

        /// <summary>
        /// Обчислює кількість бонусних балів, нарахованих за місяць.
        /// </summary>
        /// <returns>Кількість бонусних балів.</returns>
        public int GetBonusPoints()
        {
            return tariff.GetBonusPoints(this);
        }
    }
}
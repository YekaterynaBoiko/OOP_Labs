using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task5
{
    public interface INavigator
    {
        /// <summary>
        /// Будує пішохідний маршрут до вказаної точки.
        /// </summary>
        /// <param name="destination">Назва точки призначення.</param>
        void BuildRoute(string destination);

        /// <summary>
        /// Показує наступний поворот маршруту.
        /// </summary>
        void ShowNextTurn();
    }
}

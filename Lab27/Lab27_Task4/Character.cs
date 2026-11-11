using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task4
{
    public class Character : ICombatSystem, IBuildSystem
    {
        private int _pityTheEnemy = 10;
        private int _buidingProgress = 0;

        void ICombatSystem.Action()
        {
            Console.WriteLine($"Персонаж завдає шкод {_pityTheEnemy} штук");
        }
        void IBuildSystem.Action()
        {
            _buidingProgress += 5;
            Console.WriteLine($"Готовність споруди: {_buidingProgress}%");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digger
{
    // ===== Task 1 =====
    public class Terrain : ICreature
    {
        public string GetImageFileName() => "Terrain.png";
        public int GetDrawingPriority() => 0;
        public CreatureCommand Act(int x, int y)
            => new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        public bool DeadInConflict(ICreature conflictedObject) => true;
    }

    // ===== Task 2 =====
    public class Player : ICreature
    {
        public string GetImageFileName() => "Digger.png";
        public int GetDrawingPriority() => 2;
        public CreatureCommand Act(int x, int y)
        {
            var dx = 0;
            var dy = 0;
            switch (Game.KeyPressed)
            {
                case Keys.Left: dx = -1;
                    break;
                case Keys.Right: dx = 1;
                    break;
                case Keys.Up: dy = -1;
                    break;
                case Keys.Down: dy = 1;
                    break;
            }
            if (x + dx < 0 || x + dx >= Game.MapWidth)
                dx = 0;

            if (y + dy < 0 || y + dy >= Game.MapHeight)
                dy = 0;

            if (dx != 0 || dy != 0)
            {
                if (Game.Map[x + dx, y + dy] is Sack)
                {
                    dx = 0;
                    dy = 0;
                }
            }
            return new CreatureCommand { DeltaX = dx, DeltaY = dy };
        }

        public bool DeadInConflict(ICreature conflictedObject) => conflictedObject is Sack 
            || conflictedObject is Monster;
    }
    // ===== Task 3 =====
    public class Sack : ICreature
    {
        public string GetImageFileName() => "Sack.png";
        public int GetDrawingPriority() => 1;
        private int _fallDistance = 0;
        public CreatureCommand Act(int x, int y)
        {
            if (y + 1 < Game.MapHeight)
            {
                var below = Game.Map[x, y + 1];

                if (below == null || below is Player && _fallDistance > 0)
                {
                    _fallDistance++;

                    return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
                }
            }
            var command = new CreatureCommand(); 
            if (_fallDistance > 1)
                command.TransformTo = new Gold();

            _fallDistance = 0;
            return command;
        }

        public bool DeadInConflict(ICreature conflictedObject) => false;
    }

    public class Gold : ICreature
    {
        public string GetImageFileName() => "Gold.png";
        public int GetDrawingPriority() => 1;
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }
        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject is Player)
            {
                Game.Scores += 10;
                return true;
            }

            if (conflictedObject is Monster)
                return true;


            return false;
        }
    }

    // ===== Task 4 =====
    public class Monster : ICreature
    {
        public string GetImageFileName() => "Monster.png";
        public int GetDrawingPriority() => 2;
        public CreatureCommand Act(int x, int y)
        {
            var creature = new CreatureCommand();

            int a = -1;
            int b = -1;

            for (int i = 0; i < Game.MapWidth; i++)
            {
                for (int j = 0; j < Game.MapHeight; j++)
                {
                    if (Game.Map[i, j] is Player)
                    {
                        a = i;
                        b = j;
                    }
                }
            }

            if (a == -1)
                return creature;

            if (b > y && y + 1 < Game.MapHeight &&
                !(Game.Map[x, y + 1] is Terrain) &&
                !(Game.Map[x, y + 1] is Sack) &&
                !(Game.Map[x, y + 1] is Monster))
            {
                creature.DeltaY++;
            }

            if (b < y && y - 1 >= 0 &&
                !(Game.Map[x, y - 1] is Terrain) &&
                !(Game.Map[x, y - 1] is Sack) &&
                !(Game.Map[x, y - 1] is Monster))
            {
                creature.DeltaY--;
            }

            if (a > x && x + 1 < Game.MapWidth &&
                !(Game.Map[x + 1, y] is Terrain) &&
                !(Game.Map[x + 1, y] is Sack) &&
                !(Game.Map[x + 1, y] is Monster))
            {
                creature.DeltaX++;
            }

            if (a < x && x - 1 >= 0 &&
                !(Game.Map[x - 1, y] is Terrain) &&
                !(Game.Map[x - 1, y] is Sack) &&
                !(Game.Map[x - 1, y] is Monster))
            {
                creature.DeltaX--;
            }

            return creature;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return conflictedObject is Monster ||
                conflictedObject is Sack;
        }
    }
}

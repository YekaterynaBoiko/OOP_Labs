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

            return new CreatureCommand { DeltaX = dx, DeltaY = dy };
        }

        public bool DeadInConflict(ICreature conflictedObject) => false;
    }
}

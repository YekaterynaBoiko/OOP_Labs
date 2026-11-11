using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Task1
{
    public class Lamp
    {
        public int Brightness { get; private set; }
        public Mode CurrentMode { get; private set; } = Mode.Off;
        
        public enum  Mode { Off, Light, Nightlight }
        public void ModeSwitch(Mode mode)
        {
            CurrentMode = mode;
            Brightness = mode switch
            {
                Mode.Light => 60,
                Mode.Nightlight => 20,
                _ => 0
            };
        }

        public override string ToString()
        {
            string result = CurrentMode switch
            {
                Mode.Light => "Звичайне світло",
                Mode.Nightlight => "Нічник",
                _ => "Вимкнена"
            };

            return $"{result}, {Brightness}%";
        }
    }
}

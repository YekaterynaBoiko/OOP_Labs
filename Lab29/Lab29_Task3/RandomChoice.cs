using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task3
{
    record Reward(string Name, int Gold);
    public class RandomChoice
    {
        private static Random _random = new Random();

        public static T PickRandom<T>(IReadOnlyList<T> values)
        {
            if (values.Count == 0)
                throw new ArgumentException("List cannot be empty.");

            int index = _random.Next(values.Count);
            return values[index];
        }
    }
}

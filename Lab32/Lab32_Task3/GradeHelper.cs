using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Task3
{
    public class GradeHelper
    {
        public struct Result
        {
            public int Count;
            public int Min;
            public int Max;
            public double Average;
        }
        private readonly List<int> _grades = [];
        public void AddGrade(int grade)
        {
            if (grade < 1 || grade > 12)
                throw new ArgumentException("Оцінка має бути від 1 до 12");

            _grades.Add(grade);
        }

        public Result GetResult()
        {
            if (_grades.Count == 0)
                return new Result();

            return new Result
            {
                Count = _grades.Count,
                Min = _grades.Min(),
                Max = _grades.Max(),
                Average = _grades.Average()
            };
        }
    }
}

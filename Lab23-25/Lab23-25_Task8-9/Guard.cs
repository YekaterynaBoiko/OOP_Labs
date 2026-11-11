using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task8_9
{
    public class Guard
    {
        public void RegisterEntry(Employee employee)
        {
            DateTime CurrentTime = DateTime.Now;
            Console.WriteLine($"Дата та час: {CurrentTime} " +
                $"\nІм'я співробітника: {employee.Name}");

            DateTime deadline = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 8, 0, 0);
            if (CurrentTime > deadline)
            {
                Console.WriteLine($"{employee.Name} запізнився, його звільнено!"); // відмітити що людина е працює доробити
                employee.isWork = false;
            }
            else
                Console.WriteLine($"{employee.Name} прийшов вчасно");
        }

       
    }
}

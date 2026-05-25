using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab23_25_Task8_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Guard guard = new Guard();
            List<Employee> employees = new List<Employee>();
            employees.Add(new Programmer("Аліна"));
            employees.Add(new Designer("Петро"));
            employees.Add(new Programmer("Рома"));
            foreach (var employee in employees)
            {
                guard.RegisterEntry(employee);
                if (employee.isWork)
                    manager.AssingTask(employee);
            } 
        }
    }
}

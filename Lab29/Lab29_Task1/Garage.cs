using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task1
{
    public class Garage<T>
        where T : Transport
    {
        private List<T> vehicles = new List<T>();
        public void AddTransport(T vehicle)
        {
            vehicles.Add(vehicle);
        }
        public void PrintTransport()
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"\nSpeed: {vehicle.Speed}" +
                    $"\nModel: {vehicle.Model}");
                vehicle.Move();
            }
        }
    }
}

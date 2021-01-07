using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehice car = new Car();
            car.Refuel(10);
            car.Drive();
        }
    }

    public interface IVehice
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehice
    {
        private int Fuel { get; set; }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("I am Driving");
            }
            else
            {
                Console.WriteLine("Your car is empty, refuel it please");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }

}

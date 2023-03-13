using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSelector
{
    public class Car
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public void CreateCar()
        {
            Console.WriteLine("Please Chose your dream Color");
            var Color = Console.ReadLine();
            Console.WriteLine($"You have chosen {Color} is this correct?");
        }
    }
}

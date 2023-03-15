using System;
using System.Collections.Generic;
using System.Linq;


namespace CarSelector
{
    public class Garage
    {
        public List<CarCreate> CarList { get; set; }

        public Garage()
        {
            CarList = new List<CarCreate>();
            CarList.Add(new CarCreate("Blue", "Nissan", "Z20"));
            CarList.Add(new CarCreate("Red", "Ford", "Focus"));
            CarList.Add(new CarCreate("Grey", "Golf", "Polo"));
            CarList.Add(new CarCreate("Silver", "Vaxh", "Astra"));
        }


    }
}

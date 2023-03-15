using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSelector
{
    public class Garage
    {
        public List<CarCreate> CarList { get; set; }

        public Garage()
        {
            CarList = new List<CarCreate>();
        }
    }
}

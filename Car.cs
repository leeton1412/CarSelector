

namespace CarSelector
{
    public class CarCreate
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }


        public CarCreate(string color, string name, string model)
        {
            Color = color;
            Name = name;
            Model = model;
        }
        public string ToString()
        {
            return "Color: " + Color + "\n" + "Name: " + Name + "\n" + "Model: " + Model;
        }
    }
}

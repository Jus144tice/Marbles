using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
    public class Marble
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public Marble(int id, string color, string name, double weight)
        {
            Id = id;
            Color = color;
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Color: " + Color + ", Name: " + Name + ", Weight: " + Weight;
        }
    }
}

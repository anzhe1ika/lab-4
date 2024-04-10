using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1_27._03_
{
    internal class Region
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public List<District> Districts { get; set; }

        public Region(string name, double area, List<District> districts)
        {
            Name = name;
            Area = area;
            Districts = districts;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

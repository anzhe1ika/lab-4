using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1_27._03_
{
    internal class State
    {
        public string Name { get; set; }
        public City Capital { get; set; }
        public List<Region> Regions { get; set; }

        public State(string name, City capital, List<Region> regions)
        {
            Name = name;
            Capital = capital;
            Regions = regions;
        }

        public void DisplayCapital()
        {
            Console.WriteLine($"The capital of {Name} is {Capital}");
        }

        public void DisplayNumberOfRegions()
        {
            Console.WriteLine($"The number of regions in {Name} is {Regions.Count}");
        }

        public void DisplayArea()
        {
            double totalArea = 0;
            foreach (var region in Regions)
            {
                totalArea += region.Area;
            }
            Console.WriteLine($"The total area of {Name} is {totalArea} square kilometers");
        }

        public void DisplayRegionalCenters()
        {
            Console.WriteLine($"Regional centers in {Name}:");
            foreach (var region in Regions)
            {
                foreach (var district in region.Districts)
                {
                    Console.WriteLine($" - {district.DistrictCenter}");
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            State other = (State)obj;
            return Name == other.Name && Capital == other.Capital && Regions == other.Regions;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Capital, Regions);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1_27._03_
{
    internal class District
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public City DistrictCenter { get; set; }
        public District(string name, List<City> cities, City districtCenter)
        {
            Name = name;
            Cities = cities;
            DistrictCenter = districtCenter;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

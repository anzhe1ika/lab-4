using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1_27._03_
{
    internal class City
    {
        public string Name { get; set; }
        public City(string name)
        {
            Name = name;
        }        
        public override string ToString()
        {
            return Name;
        }
    }
}

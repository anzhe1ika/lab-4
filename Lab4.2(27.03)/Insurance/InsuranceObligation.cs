using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2_27._03_.Insurance
{
    public class InsuranceObligation
    {
        public int Premium { get; set; }
        public int Deductible { get; set; }
        public string Name { get; set; }

        public InsuranceObligation(int premium, int deductible, string name)
        {
            Premium = premium;
            Deductible = deductible;
            Name = name;
        }

        public virtual int CalculateRisk()
        {
            return Premium + Deductible;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    //public class InsuranceObligation
    //{
    //    public int Premium { get; set; }
    //    public int Deductible { get; set; }

    //    public InsuranceObligation(int premium, int deductible)
    //    {
    //        Premium = premium;
    //        Deductible = deductible;
    //    }

    //    public int CalculateRisk();
    //    {
    //        return Premium + Deductible;
    //    }
    //}
}

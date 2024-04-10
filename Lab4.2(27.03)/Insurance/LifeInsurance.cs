using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2_27._03_.Insurance
{
    public class LifeInsurance : InsuranceObligation
    {
        public LifeInsurance(int premium, int deductible, string name) : base(premium, deductible, name)
        {
        }

        public override int CalculateRisk()
        {
            return Premium * 3 + Deductible;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

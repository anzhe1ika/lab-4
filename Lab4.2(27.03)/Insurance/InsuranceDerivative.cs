using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2_27._03_.Insurance
{
    public class InsuranceDerivative
    {
            public InsuranceObligation Obligation { get; set; }

            public InsuranceDerivative(InsuranceObligation obligation)
            {
                Obligation = obligation;
            }

            public int CalculateRisk()
            {
                return Obligation.CalculateRisk();
            }
    }
}

using Lab4._2_27._03_.Insurance;
using System;
using System.Collections.Generic;
using System.IO;

namespace InsuranceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InsuranceObligation carInsurance = new CarInsurance(2000, 1500, "Car Insurance");
            InsuranceObligation healthInsurance = new HealthInsurance(2000, 1500, "Health Insurance");
            InsuranceObligation lifeInsurance = new LifeInsurance(2000, 1500, "Life Insurance");
            InsuranceObligation propertyInsurance = new PropertyInsurance(2000, 1500, "Property Insurance");

            List<InsuranceDerivative> derivatives = new List<InsuranceDerivative>();
            derivatives.Add(new InsuranceDerivative(carInsurance));
            derivatives.Add(new InsuranceDerivative(healthInsurance));
            derivatives.Add(new InsuranceDerivative(lifeInsurance));
            derivatives.Add(new InsuranceDerivative(propertyInsurance));

            derivatives.Sort((d1, d2) => d1.CalculateRisk().CompareTo(d2.CalculateRisk()));


            Console.WriteLine("Sorted Derivatives by Risk Level:");
            foreach (var derivative in derivatives)
            {
                Console.WriteLine($"{derivative.GetType().Name}: {derivative.CalculateRisk()}");
            }

            int minRisk = 5000;
            int maxRisk = 6000;

            Console.WriteLine($"\nLiabilities within risk range {minRisk}-{maxRisk}:");
            foreach (var derivative in derivatives)
            {
                int risk = derivative.CalculateRisk();
                if (risk >= minRisk && risk <= maxRisk)
                {
                    Console.WriteLine($"{derivative.GetType().Name}: {risk}");
                }
            }
        }
    }
}

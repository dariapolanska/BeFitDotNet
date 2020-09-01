using System.Collections.Generic;

namespace BeFitDotNet.Services
{
    public interface ICalculatorService
    {
        double CalculateBMI(float weight, float height);

        IDictionary<string, double> CalculateExtremesOfHealthyWeight(float height);
    }
}

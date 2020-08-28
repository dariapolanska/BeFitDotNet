using System;
using System.Collections.Generic;
using BeFitDotNet.Helpers;

namespace BeFitDotNet.Services
{
    public class CalculatorService : ICalculatorService
    {
        private const float MinBMIIndexForHealthyWeight = 18.5f;
        private const float MaxBMIIndexForHealthyWeight = 24.9f;

        public double CalculateBMI(float weight, float height)
        {
            CalculatorHelper.ThrowExceptionIfWeightOrHeightOutOfRange(weight, height);

            return Math.Round(weight / MathF.Pow(height, 2), 2);
        }

        public IDictionary<string, double> CalculateExtremesOfHealthyWeight(float height)
        {
            CalculatorHelper.ThrowExceptionIfHeightOutOfRange(height);

            return new Dictionary<string, double>() 
            {
                { "min", CalculateMinHealthyWeight(height) }, 
                { "max", CalculateMaxHealthyWeight(height) } 
            };
        }

        private double CalculateMinHealthyWeight(float height) => 
            Math.Round(MinBMIIndexForHealthyWeight * MathF.Pow(height, 2), 1);

        private double CalculateMaxHealthyWeight(float height) => 
            Math.Round(MaxBMIIndexForHealthyWeight * MathF.Pow(height, 2), 1);
    }
}

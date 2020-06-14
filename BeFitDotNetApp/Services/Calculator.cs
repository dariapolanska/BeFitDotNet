using System;

namespace BeFitDotNet.Services
{
    public static class Calculator
    {
        public static double CalculateBMI(float weight, float height) =>
            Math.Round(weight / MathF.Pow(height, 2), 2);

        public static double CalculateLowestCorrectWeight(float height)
        {
            float lowestIndex = 18.5f;

            return Math.Round(lowestIndex * MathF.Pow(height, 2), 1);
        }

        public static double CalculateHighestCorrectWeight(float height)
        {
            float highestIndex = 24.9f;

            return Math.Round(highestIndex * MathF.Pow(height, 2), 1);
        }
    }
}

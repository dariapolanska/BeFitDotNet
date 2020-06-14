using System;

namespace BeFitDotNet.Services
{
    public static class Calculator
    {
        public static double CalculateBMI(float weight, float height) =>
            Math.Round(weight / MathF.Pow(height, 2), 2);
    }
}

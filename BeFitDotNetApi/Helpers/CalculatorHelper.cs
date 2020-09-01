using System;

namespace BeFitDotNet.Helpers
{
    public static class CalculatorHelper
    {
        private const float MinAdultWeight = 22.5f;
        private const float MaxAdultWeight = 250f;
        private const float MinAdultHeight = 1.2f;
        private const float MaxAdultHeight = 2.5f;

        public static void ThrowExceptionIfWeightOrHeightOutOfRange(float weight, float height)
        {
            ThrowExceptionIfWeightBelowMin(weight);
            ThrowExceptionIfWeightAboveMax(weight);
            ThrowExceptionIfHeightOutOfRange(height);
        }

        public static void ThrowExceptionIfHeightOutOfRange(float height)
        {
            ThrowExceptionIfHeightBelowMin(height);
            ThrowExceptionIfHeightAboveMax(height);
        }

        private static void ThrowExceptionIfWeightBelowMin(float weight)
        {
            if (weight <= MinAdultWeight)
            {
                throw new InvalidOperationException($"The weight cannot be below {MinAdultWeight}.");
            }
        }

        private static void ThrowExceptionIfWeightAboveMax(float weight)
        {
            if (weight >= MaxAdultWeight)
            {
                throw new InvalidOperationException($"The weight cannot be above {MaxAdultWeight}.");
            }
        }

        private static void ThrowExceptionIfHeightBelowMin(float height)
        {
            if (height <= MinAdultHeight)
            {
                throw new InvalidOperationException($"The height cannot be below {MinAdultHeight}.");
            }
        }

        private static void ThrowExceptionIfHeightAboveMax(float height)
        {
            if (height >= MaxAdultHeight)
            {
                throw new InvalidOperationException($"The height cannot be above {MaxAdultHeight}.");
            }
        }
    }
}

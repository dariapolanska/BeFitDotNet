namespace BeFitDotNet.Helpers
{
    public static class CalculatorHelper
    {
        public static void CheckWeightValueCorrectness(float weight)
        {
            if (weight <= 0)
            {
                Exceptions.ThrowWeightBelowZero();
            }
        }

        public static void CheckHeightValueCorrectness(float height)
        {
            if (height <= 0)
            {
                Exceptions.ThrowHeightBelowZero();
            }
        }
    }
}

using System;

namespace BeFitDotNet.Helpers
{
    public static class Exceptions
    {
        public static void ThrowWeightBelowZero()
        {
            throw new InvalidOperationException("The weight should be higher than 0.");
        }

        public static void ThrowHeightBelowZero()
        {
            throw new InvalidOperationException("The height should be higher than 0.");
        }
    }
}

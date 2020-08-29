using System;
using Xunit;
using BeFitDotNet.Helpers;

namespace BeFitDotNetTests
{
    public class CalculatorHelperTests
    {
        private const float weightBelowMin = 20f;
        private const float weightWithinRange = 60f;
        private const float weightAboveMax = 255f;
        private const float heightBelowMin = 1.1f;
        private const float heightWithinRange = 1.7f;
        private const float heightAboveMax = 2.6f;

        [Fact]
        public void ThrowExceptionIfWeightOrHeightOutOfRange_WeightBelowMin_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() => 
                CalculatorHelper.ThrowExceptionIfWeightOrHeightOutOfRange(weightBelowMin, heightWithinRange));
        }

        [Fact]
        public void ThrowExceptionIfWeightOrHeightOutOfRange_WeightAboveMax_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
                CalculatorHelper.ThrowExceptionIfWeightOrHeightOutOfRange(weightAboveMax, heightWithinRange));
        }

        [Fact]
        public void ThrowExceptionIfWeightOrHeightOutOfRange_HeightOutOfRange_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
                CalculatorHelper.ThrowExceptionIfWeightOrHeightOutOfRange(weightWithinRange, heightBelowMin));
        }

        [Fact]
        public void ThrowExceptionIfHeightOutOfRange_HeightBelowMin_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
                CalculatorHelper.ThrowExceptionIfHeightOutOfRange(heightBelowMin));
        }

        [Fact]
        public void ThrowExceptionIfHeightOutOfRange_HeightAboveMax_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() => 
                CalculatorHelper.ThrowExceptionIfHeightOutOfRange(heightAboveMax));
        }
    }
}

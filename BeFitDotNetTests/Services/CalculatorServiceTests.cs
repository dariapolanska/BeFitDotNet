using Xunit;
using BeFitDotNet.Services;

namespace BeFitDotNetTests
{
    public class CalculatorServiceTests
    {
        private const float testHeight = 1.7f; 

        [Fact]
        public void CalculateBMI_TestValues_TestBMIValue()
        {
            float testWeight = 60f;
            float testBMIValue = 20.76f;
            var service = new CalculatorService();

            var result = service.CalculateBMI(testWeight, testHeight);

            Assert.Equal(testBMIValue, result, 2);
        }

        [Fact]
        public void CalculateExtremesOfHealthyWeight_TestHeight_TestExtremes()
        {
            float testMinWeight = 53.5f;
            float testMaxWeight = 72f;
            var service = new CalculatorService();

            var result = service.CalculateExtremesOfHealthyWeight(testHeight);

            Assert.Equal(testMinWeight, result["min"], 1);
            Assert.Equal(testMaxWeight, result["max"], 1);
        }
    }
}

using BeFitDotNet.Helpers;
using BeFitDotNet.Services;
using BeFitDotNet.WebModels;
using Microsoft.AspNetCore.Mvc;

namespace BeFitDotNet.Controllers
{
    [Route("/")]
    public class CalculatorController : Controller
    {
        [HttpPost("/bmi")]
        public double CalculateBMI(CalculatorForm calculatorForm)
        {
            CalculatorHelper.CheckWeightValueCorrectness(calculatorForm.Weight);
            CalculatorHelper.CheckHeightValueCorrectness(calculatorForm.Height);

            return Calculator.CalculateBMI(calculatorForm.Weight, calculatorForm.Height);
        }

        [HttpPost("/correct-weight")]
        public string CalculateCorrectWeight(CalculatorForm calculatorForm)
        {
            CalculatorHelper.CheckHeightValueCorrectness(calculatorForm.Height);

            var lowestCorrectWeight = Calculator.CalculateLowestCorrectWeight(calculatorForm.Height);
            var highestCorrectWeight = Calculator.CalculateHighestCorrectWeight(calculatorForm.Height);

            string correctWeightRange = $"{lowestCorrectWeight} - {highestCorrectWeight}";

            return correctWeightRange;
        }
    }
}
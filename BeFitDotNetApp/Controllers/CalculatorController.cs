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
    }
}
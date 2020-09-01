using BeFitDotNet.Services;
using BeFitDotNet.WebModels;
using Microsoft.AspNetCore.Mvc;

namespace BeFitDotNet.Controllers
{
    [Route("/")]
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("/bmi")]
        public double CalculateBMI(CalculatorFormWebModel calculatorForm) =>
            _calculatorService.CalculateBMI(calculatorForm.Weight, calculatorForm.Height);

        [HttpPost("/correct-weight")]
        public string CalculateExtremesOfCorrectWeight(CalculatorFormWebModel calculatorForm)
        {
            var extremes = _calculatorService.CalculateExtremesOfHealthyWeight(calculatorForm.Height);
            
            return $"{extremes["min"]} - {extremes["max"]}";
        }
    }
}

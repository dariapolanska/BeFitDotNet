using System.Collections.Generic;
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
        public IDictionary<string, double> CalculateExtremesOfCorrectWeight(
                CalculatorFormWebModel calculatorForm
            ) => _calculatorService.CalculateExtremesOfHealthyWeight(calculatorForm.Height);
    }
}

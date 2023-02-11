using Calculator.Core.Models;
using Calculator.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public ICalculatorService _calculatorService { get; }

        public CalculatorController( ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("ArithmaticMean")]
        public async Task<double> ArithmaticMean( List<int> numbers)
        {
            return await _calculatorService.CalculateAritmaticMean(numbers);
        }

        [HttpPost("StandardDaviation")]
        public async Task<double> StandardDaviation(List<int> numbers)
        {
            return await _calculatorService.CalculateStandardDeviation(numbers);
        }


        [HttpPost("Frequencies")]
        public async Task<List<double>> Frequencies(List<FrequencyModel> frequencyModel)
        {
            return await _calculatorService.CalculateFrequencies(frequencyModel);
        }

        [HttpPost("SquareRoot")]
        public async Task<double> SquareRoot(double number)
        {
            return await _calculatorService.CalculateSquareRoot(number);
        }
    }
}

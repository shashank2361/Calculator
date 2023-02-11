using Calculator.Core.Models;
using Calculator.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompoundInterestController : ControllerBase
    {

        ICompoundInterestService _interestService;
        public CompoundInterestController(ICompoundInterestService interestService)
        {
            _interestService = interestService;
        }

        [HttpPost("CompoundIncrease")]
        public async Task<double> CompoundIncrease(CompountInterestModel compountInterestModel)
        {
            return await _interestService.CalculateCompoundIncrease(compountInterestModel);
        }

        [HttpPost("CompoundDecrease")]
        public async Task<double> CompoundDecrease(CompountInterestModel compountInterestModel)
        {
            return await _interestService.CalculateCompoundDecrease(compountInterestModel);
        }
    }
}

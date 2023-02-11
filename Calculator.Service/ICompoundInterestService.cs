using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public interface ICompoundInterestService
    {
        Task<double> CalculateCompoundIncrease(CompountInterestModel compountInterestModel);
        Task<double> CalculateCompoundDecrease(CompountInterestModel compountInterestModel);

    }
}

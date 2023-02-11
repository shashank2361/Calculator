using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public class CompoundInterestService : ICompoundInterestService
    {
        public async Task<double> CalculateCompoundDecrease(CompountInterestModel compountInterestModel)
        {
            double body = 1 - (compountInterestModel.InterestRate / (100 * compountInterestModel.TimesPerYear));
            double exponent = compountInterestModel.TimesPerYear * compountInterestModel.Years;
            return Math.Round(compountInterestModel.PrincipleAmt * Math.Pow(body, exponent), 2);
        }

        public async Task<double> CalculateCompoundIncrease(CompountInterestModel compountInterestModel)
        {
            double body = 1 + (compountInterestModel.InterestRate / (100 * compountInterestModel.TimesPerYear));
            double exponent = compountInterestModel.TimesPerYear * compountInterestModel.Years;
            return  Math.Round(compountInterestModel.PrincipleAmt * Math.Pow(body, exponent) , 2);
        }
    }
}

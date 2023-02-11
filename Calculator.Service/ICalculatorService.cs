using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public interface ICalculatorService
    {
        Task<double> CalculateAritmaticMean(List<int> numbers);
        Task<double> CalculateStandardDeviation(List<int> numbers);
        Task<List<double>> CalculateFrequencies ( List<FrequencyModel> frequencyModels) ;
        Task<double> CalculateSquareRoot (double number );
    }
}

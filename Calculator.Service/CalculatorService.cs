using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public class CalculatorService : ICalculatorService
    {
        public async Task<double> CalculateAritmaticMean(List<int> numbers)
        {
            // Preferred Method
            //double avg = Queryable.Average(numbers.AsQueryable());
            //return avg;             
            return await calculateAverage(numbers);
        }
        public async Task<double> CalculateStandardDeviation(List<int> numbers)
        {
            double standardDeviation = 0;
            int count = numbers.Count();
            double sum = 0;
            if (count > 1)
            {
                double avg = await calculateAverage(numbers);
                foreach (var item in numbers)
                {
                    sum = sum + Math.Pow((item - avg), 2);
                }
                standardDeviation = Math.Sqrt(sum / count);
            }
            return Math.Round(standardDeviation,2);
        }


        public async Task<List<double>>  CalculateFrequencies(List<FrequencyModel> frequencyModels)
        {
            var listFrequecies = new List<double>();
            frequencyModels.ForEach(x => listFrequecies.Add(x.FrequencyDensity * x.Width));
            return listFrequecies;
        }


        public async Task<double> CalculateSquareRoot(double number)
        {
            return calculateSquareRoot(number);
           
        }

        private double calculateSquareRoot(double number)
        {
            double root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1) { break; }
            }
            return Math.Round(root, 2);
        }

        private async Task<double> calculateAverage(List<int> numbers)
        {
                int count = numbers.Count();
                double sumNumbers = 0;
                for (int i = 0; i < count; i++)
                {
                    sumNumbers = sumNumbers + numbers[i];
                }
               return (sumNumbers / count);
        }

      
    }
}

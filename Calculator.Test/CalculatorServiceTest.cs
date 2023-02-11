using Calculator.Core.Models;
using Calculator.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestFixture]

    public class CalculatorServiceTest
    {

        ICalculatorService _calculatorService;
        public CalculatorServiceTest()
        {
            _calculatorService = new CalculatorService();
        }

        [Test]
        public async Task CalculateAritmaticMean_InputTListOfNumbers_GetCorrectArithmaticMean()
        {
            //Arrange
            var numbers = new List<int> { 17 , 17, 517 , 51 };

            //Act
            double result = await _calculatorService.CalculateAritmaticMean(numbers);

            //Assert
            Assert.AreEqual(150.5, result);
        }

        [Test]
        public async Task  CalculateStandardDeviation_InputTListOfNumbers_GetCorrectDeviation()
        {
            //Arrange
            var numbers = new List<int> { 6, 2, 3, 1 };

            //Act
            double result = await _calculatorService.CalculateStandardDeviation(numbers);

            //Assert
            Assert.AreEqual(1.87, Math.Round( result , 2));
        }

        [Test]
        public async Task CalculateFrequencies_InputTListOfFrequencyModels_GetCorrectFrequencies()
        {
            //Arrange
            List<double> expectedFrequencies = new() {  4,  10,  15,  8,  6 }; 

            var frequencyModels = new List<FrequencyModel>(){
                new FrequencyModel(){ FrequencyDensity = 10 , Width = 0.4 } ,
                new FrequencyModel(){ FrequencyDensity = 10 , Width = 1.0 } ,
                new FrequencyModel(){ FrequencyDensity = 10 , Width = 1.5 } ,
                new FrequencyModel(){ FrequencyDensity = 10 , Width = 0.8 } ,
                new FrequencyModel(){ FrequencyDensity = 10 , Width = 0.6 } ,
            };

            //Act
            var result = await _calculatorService.CalculateFrequencies(frequencyModels);

            //Assert
            Assert.That(result, Is.EquivalentTo(expectedFrequencies));
            Assert.That(result, Is.Not.Empty);

        }

         [Test]
        [TestCase(9, 3)] //15.9
        [TestCase(25, 5)] // 15.93
        [TestCase(64, 8)] // 16.08

        public async Task CalculateStandardDeviation_InputTListOfNumbers_GetCorrectDeviation(double number , double expectedResult)
        {
            //Arrange
             
            //Act
            double result = await _calculatorService.CalculateSquareRoot(number);

            //Assert
            Assert.AreEqual(expectedResult, result  );
        }


    }
}

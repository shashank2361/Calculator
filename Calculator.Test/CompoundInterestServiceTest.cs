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
    public class CompoundInterestServiceTest
    {
        ICompoundInterestService _compoundInterestService;
        public CompoundInterestServiceTest()
        {
            _compoundInterestService = new CompoundInterestService();
        }

        [Test]
        public async Task CalculateCompoundIncrease_InputCompoundInterestModel_GetCorrectcompoundIncrease()
        {
            //Arrange
            var model = new CompountInterestModel()
                            {
                                PrincipleAmt = 1500,
                                InterestRate = 4.3,
                                TimesPerYear = 1,
                                Years = 6
                            };

            //Act
            double result = await _compoundInterestService.CalculateCompoundIncrease(model);
            //Assert
            Assert.AreEqual(1931.07,  result );
        }

        [Test]
        public async Task CalculateCompoundDecrease_InputCompoundInterestModel_GetCorrectcompoundIncrease()
        {
            //Arrange
            var model = new CompountInterestModel()
                            {
                                PrincipleAmt = 12000,
                                InterestRate = 4.0,
                                TimesPerYear = 1,
                                Years = 5
                            };

            //Act
            double result = await _compoundInterestService.CalculateCompoundDecrease(model);
            //Assert
            Assert.AreEqual(9784.47, result);
        }
    }
}

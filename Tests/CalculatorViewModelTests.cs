using CalculatorModule.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class CalculatorViewModelTests
    {
        [Fact]
        public void LoadCalculator_TotalIsZero_IsTrue()
        {
            //Arrange
            var calc = new DisplayViewModel();

            //Act
            var result = calc.Total;

            //Assert
            Assert.Equal(result, 0);
        }

        [Fact]
        public void Calculator()
        {
            //Arrange
            var calc = new DisplayViewModel();

            //Act
            var result = calc.Total;

            //Assert
            Assert.Equal(result, 0);
        }
    }
}

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
            var calc = ConstructCalculator();

            //Act
            var result = calc.Total;

            //Assert
            Assert.Equal(0, calc.Total);
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(0,0)]
        [InlineData(-1,1)]
        [InlineData(100,0)]
        public void Calculator_CanAddTwoNumbers_IsOK(int a, int b)
        {
            var calc = ConstructCalculator();

            calc.Add(a);
            calc.Add(b);
            Assert.Equal(a+b, calc.Total);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(-1, 1)]
        [InlineData(100, 0)]
        public void Calculator_CanSubtractTwoNumbers_IsOK(int a, int b)
        {
            var calc = ConstructCalculator();

            calc.Subtract(a);
            calc.Subtract(b);
            Assert.Equal(a - b, calc.Total);
        }

        private DisplayViewModel ConstructCalculator()
        {
            return new DisplayViewModel();
        }
    }
}

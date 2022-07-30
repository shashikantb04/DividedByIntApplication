using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DividedByIntApplication;

namespace DivideByIntUnitTest
{
    public class DivideByIntUnitTest
    {
        [Fact]
        public void CheckNumberDividebyboth()
        {
            int number = 15;
            string output = "FizzBuzz";
            string result = DivisonLogic.printResult(number);
            Assert.Equal(output, result);
        }
        [Fact]
        public void CheckNumberDivideby3()
        {
            int number = 6;
            string output = "Fizz";
            string result = DivisonLogic.printResult(number);
            Assert.Equal(output, result);
        }
        [Fact]
        public void CheckNumberDivideby5()
        {
            int number = 10;
            string output = "Buzz";
            string result = DivisonLogic.printResult(number);
            Assert.Equal(output, result);
        }
        [Fact]
        public void CheckNumberNoDividebyboth()
        {
            int number = 1;
            string output = "1";
            string result = DivisonLogic.printResult(number);
            Assert.Equal(output, result);
        }
    }
}

using System;
using Xunit;

namespace Assignment00.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_True_Divisible_by_4()
        {
            //Arrange
            var program = new Program();
            int year1 = 1444;

            //Act
            var output = program.IsLeapYear(year1);

            //Assert
            Assert.True(output);
        }
        [Fact]
        public void IsLeapYearFalse_Divisible_by_4()
        {
            var notLeapYearProgram = new Program();
            int year2 = 1333;

            var output = notLeapYearProgram.IsLeapYear(year2);
            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_Divisble_by_100()
        {
            var notLeapYear100 = new Program();
            var year_divisble_100 = 1700;

            var output = notLeapYear100.IsLeapYear(year_divisble_100);
            Assert.False(output);

        }


        [Fact]
        public void IsLeapYear_Divisible_By_400()
        {
            var leapYear400 = new Program();
            int year_Divisible_400 = 40_000;

            var output = leapYear400.IsLeapYear(year_Divisible_400);
            Assert.True(output);
    }
}
}

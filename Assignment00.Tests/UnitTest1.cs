using System;
using System.IO;
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
            //Arrange
            var notLeapYearProgram = new Program();
            int year2 = 1333;

            //Act
            var output = notLeapYearProgram.IsLeapYear(year2);
            
            //Assert
            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_Divisble_by_100()
        {
            //Arrange
            var notLeapYear100 = new Program();
            var year_divisble_100 = 1700;

            //Act
            var output = notLeapYear100.IsLeapYear(year_divisble_100);
            
            //Assert
            Assert.False(output);

        }


        [Fact]
        public void IsLeapYear_Divisible_By_400()
        {
            //Arrange
            var leapYear400 = new Program();
            int year_Divisible_400 = 40_000;

            //Act
            var output = leapYear400.IsLeapYear(year_Divisible_400);
            
            //Assert
            Assert.True(output);
    }
    [Fact]
        public void Yay_For_LeapYear()
        {
            //Arrange
            var yayProgram = new Program();
            int yayYear = 1444;

            //Act
            var output = false;
            output = yayProgram.IsLeapYear(yayYear);

            //Assert
            Assert.True(output);
        }

        [Fact]
        public void Yay_For_LeapYear_Console()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("1444");
            Console.SetIn(reader);

            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal($"Type in a year:{Environment.NewLine}yay",output);
        }

        [Fact]
        public void Nay_For_Leap_Year_Console()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("1700");
            Console.SetIn(reader);

            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal($"Type in a year:{Environment.NewLine}nay",output);

        }
}
}

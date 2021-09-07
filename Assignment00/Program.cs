using System;

namespace Assignment00
{
    public class Program
    {
        private bool _leapYear;

        public Program()
        {
            _leapYear = false;
        }

        public static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine("Type in a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            program.IsLeapYear(year);
            if(program._leapYear == true)
            {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        }

        public bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    _leapYear = false;
                    if(year % 400 == 0)
                    {
                        _leapYear = true;
                    }
                } else{
                    _leapYear = true;
                }
            }
            return _leapYear;
        }
    }
}

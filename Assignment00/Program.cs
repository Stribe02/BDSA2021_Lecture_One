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

        static void Main(string[] args)
        {
            Console.WriteLine("result: ");
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

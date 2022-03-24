using System;

namespace homeworkDateTimeex4
{
    class Program
    {
        static void dateTime()
        {
            DateTime currentDate = DateTime.Now;

            DateTime threeDaysFromNow = currentDate.AddDays(3);
            Console.WriteLine(threeDaysFromNow);
            Console.WriteLine("==============");

            DateTime oneMonthFromNow = currentDate.AddMonths(1);
            Console.WriteLine(oneMonthFromNow);
            Console.WriteLine("==============");

            DateTime oneMounthAndThreeDaysFromNow = currentDate.AddDays(3).AddMonths(1);
            Console.WriteLine(oneMounthAndThreeDaysFromNow);
            Console.WriteLine("==============");

            DateTime oneYearAndTwoMonthAgoFromToday = currentDate.AddMonths(-2).AddYears(-1);
            Console.WriteLine(oneYearAndTwoMonthAgoFromToday);
            Console.WriteLine("==============");

            string getMonth = String.Format("Current month is: {0:MMMM}", currentDate);
            Console.WriteLine("Current date is: " + getMonth);
            Console.WriteLine("==============");

            string currentYear = String.Format("Current year is: {0:yyyy}", currentDate);
            Console.WriteLine(currentYear);
            Console.WriteLine("==============");

            


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Date and Time Exercise 4");
            dateTime();

            Console.ReadLine();

        }
    }
}

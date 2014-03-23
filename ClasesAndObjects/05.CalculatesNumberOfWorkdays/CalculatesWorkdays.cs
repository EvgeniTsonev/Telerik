//Write a method that calculates the number of workdays between today
//and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday
//except a fixed list of public holidays specified preliminary as array.


using System;
namespace _5.NumberOfWorkdays
{
    class Program                                                           
    {
        //the method calculates the workdays
        static void NumberOfWorkdays(DateTime endday)
        {

            DateTime[] holidays = {
                                        new DateTime(2013, 01, 1),
                                        new DateTime(2013, 03, 03),
                                        new DateTime(2013, 05, 01),
                                        new DateTime(2013, 05, 24),
                                        new DateTime(2013, 09, 06),
                                        new DateTime(2013, 09, 22),
                                        new DateTime(2013, 11, 01),
                                        new DateTime(2013, 12, 24),
                                        new DateTime(2013, 12, 25),
                                        new DateTime(2013, 12, 26),
                                        new DateTime(2013, 12, 31),
                                  };
            DateTime today = DateTime.Today;
            int allDays = (endday - today).Days;
            int workDays = allDays;
            DateTime day = today;
            while (day <= endday)
            {
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday)
                {
                    workDays--;
                }
                else
                {
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (day == holidays[i])
                        {
                            workDays--;
                        }
                    }
                }
                day = day.AddDays(1);
            }
            Console.WriteLine(workDays);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a end date in YYYY/MM/DD format");     //няма проверка за корекция....
            DateTime enddate = DateTime.Parse(Console.ReadLine());
            NumberOfWorkdays(enddate);
        }
    }
}
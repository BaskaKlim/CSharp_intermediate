using System;
using System.Collections.Generic;

namespace DateAndTime
{
    class Program
    {

        static public List<double> HowOldIAm(DateTime now, DateTime startDay)
        {
            var timeOfMyLiving = now - startDay;

            double age = timeOfMyLiving.Days / 365;
            double days = timeOfMyLiving.Days;
            double hours = timeOfMyLiving.Hours;
            double minutes = timeOfMyLiving.Minutes;
           
            List<double> myAge = new List<double> { age, days,hours,minutes};

            return myAge;
        }
        static void Main(string[] args)
        {

         DateTime now = DateTime.Now;
         DateTime startDay = new DateTime(1988, 10,07,22,00,00);
         List<double> myAge = HowOldIAm(now,startDay);

         Console.WriteLine($"Mas presne {myAge[0]} rokov. Narodila si sa pred {myAge[1]} dnami, {myAge[2]} hodinami a {myAge[3]} minutami.");


            //rozne formaty casu a datumu
            var teraz = DateTime.Now;
            Console.WriteLine(now.ToLongDateString());  // Sunday, February 7, 2021
            Console.WriteLine(now.ToLongTimeString());  // 4:17:01 PM
            Console.WriteLine(now.ToShortDateString()); // 2/7/2021
            Console.WriteLine(now.ToShortTimeString()); // 4:17 PM
            Console.WriteLine(now.ToUniversalTime());   // 2/7/2021 3:17:01 PM

        }
    }
}

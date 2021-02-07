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
            
        }
    }
}

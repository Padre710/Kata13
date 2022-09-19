using System;
using System.Collections.Generic;
using System.Linq;
// using NUnit.Framework;


//Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM: SS)

//HH = hours, padded to 2 digits, range: 00 - 99
//MM = minutes, padded to 2 digits, range: 00 - 59
//SS = seconds, padded to 2 digits, range: 00 - 59
//The maximum time never exceeds 359999 (99:59:59)

//You can find some examples in the test fixtures.


//("00:00:00", (0));
//("00:00:05", (5));
//("00:01:00", (60));
//("23:59:59",(86399));
//("99:59:59", (359999));

namespace Kata13
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            List<string> List = new List<string>();
            // string stringVariable = intVariable.ToString(); 
           int hours = seconds / 3600;
            string hour = hours.ToString();
            int minutes = (seconds % 3600) / 60;
            string minute = minutes.ToString();
            int  secs = (seconds % 3600) % 60;
            string sec = secs.ToString();
            
            if (hour.Length ==1)
            {
                var n = string.Format("0{0}", hour);
                hour = n;
            }

            if (minute.Length == 1)
            {
                var n = string.Format("0{0}", minute);
                minute = n;
            }
            if (sec.Length == 1)
            {
                var n = string.Format("0{0}", sec);
                sec = n;
            }

            //  string answer = string.Format("{0:000}:{1:000}:{2:000}", hour, minute, sec);
            string answer = hour + ":" + minute + ":" + sec;



            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(TimeFormat.GetReadableTime(0));
            Console.WriteLine(TimeFormat.GetReadableTime(5));
            Console.WriteLine(TimeFormat.GetReadableTime(60));
            Console.WriteLine(TimeFormat.GetReadableTime(86399));
            Console.WriteLine(TimeFormat.GetReadableTime(359999));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class HumanReadableTime
    {

        public HumanReadableTime()
        {
            GetReadableTime(86399);
        }
        /// <summary>
        /// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
        ///HH = hours, padded to 2 digits, range: 00 - 99
        ///MM = minutes, padded to 2 digits, range: 00 - 59
        ///SS = seconds, padded to 2 digits, range: 00 - 59
        ///The maximum time never exceeds 359999 (99:59:59)
        ///You can find some examples in the test fixtures.
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static string GetReadableTime(int seconds)
        {
            int minutes = 0;
            int hours= 0;
      
            

            if (seconds / 60 > 0)
            {
                minutes = seconds / 60;

                seconds = seconds % 60;

                if (minutes / 60 > 0)
                {
                    hours = minutes / 60;

                    minutes = minutes % 60;
                }
            }
         





            string outSeconds = seconds > 10 ? seconds.ToString() : "0" + seconds.ToString();
            string outMinutes = minutes > 10 ? minutes.ToString() : "0" + minutes.ToString();
            string outhours = hours > 10 ? hours.ToString() : "0" + hours.ToString();



            return $"{outhours}:{outMinutes}:{outSeconds}";        
        }
    }
}

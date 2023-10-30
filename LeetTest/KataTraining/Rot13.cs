using System.Collections.Generic;
using System.Linq;

namespace LeetTest.KataTraining
{
    public class Rot13
    {

        public Rot13(string message) 
        {
            KataRot13(message);
        }


        /// <summary>
        /// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.
        ///    Create a function that takes a string and returns the string ciphered with Rot13.
        ///    If there are numbers or special characters included in the string, they should be returned as they are. 
        ///    Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
        ///     Assert.AreEqual("Grfg", Kata.Rot13("Test")
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string KataRot13(string message)
         {
            string solution = string.Empty;
            int charVal = 0;


            for (int i = 0; i < message.Length; i++)
            {
                int charIndex = (int)message[i];
                if ((charIndex >= 65 && charIndex <= 90))
                {
                    if (charIndex + 13 > 90)
                    {
                        charVal = 65 + (13 - (90 - charIndex) - 1);
                        solution += (char)charVal;
                    }else
                    {
                        solution += (char)(charIndex + 13);
                    }
                }
                else if (charIndex >= 97 && charIndex <= 122)
                {
                    if (charIndex + 13 > 122)
                    {

                        charVal = 97 + (13 - (122 - charIndex)-1);
                        solution += (char)charVal;
                    }
                    else
                    {
                        solution += (char)(charIndex + 13);
                    }
                }
                else
                {
                    solution += message[i];
                }
            }




            return solution;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class DecodeMorseCode
    {
        public DecodeMorseCode()
        {
            Decode("... --- ...");
        }

        /// <summary>
        /// The Morse code encodes every character as a sequence of "dots" and "dashes".
        /// For example, the letter A is coded as ·−, letter Q is coded as −−·−, and digit 1 is coded as ·−−−−. 
        /// The Morse code is case-insensitive, traditionally capital letters are used. When the message is written in Morse code, 
        /// a single space is used to separate the character codes and 3 spaces are used to separate words. For example, the message HEY JUDE in Morse code is ···· · −·−−   ·−−− ··− −·· ·.
        /// 
        /// 
        /// In addition to letters, digits and some punctuation, there are some special service codes,
        /// the most notorious of those is the international distress signal SOS (that was first issued by Titanic), that is coded as ···−−−···.
        /// These special codes are treated as single special characters, and usually are transmitted as separate words.
        /// 
        /// 
        /// </summary>
        /// <param name="morseCode"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static string Decode(string morseCode)
        {
           // Console.WriteLine(MorseCode.Get("...."));
            string temp = string.Empty;
            string solution = string.Empty;
            int spaces = 0;
            Console.WriteLine(morseCode);
            for (int i = 0; i < morseCode.Length; i++)
            {

                if (morseCode[i] != ' ')
                {
                    temp += morseCode[i].ToString().Trim();
                    if (temp.Length == morseCode.Length) return GetMorseCode(temp);

                    if (i == morseCode.Length - 1) solution += GetMorseCode(temp.Trim());
                    spaces = 0;
                }
                else
                {
                    solution += GetMorseCode(temp) + (spaces==2 ? " ":"");
                    temp = "";
                    spaces++;
                }


            }
            string newSol = "";
            foreach (var item in solution.Trim().Split(',')) 
            { 
                newSol+= item + " ";
            }

            return solution;
            throw new System.NotImplementedException("Please provide some code.");
        }

        public static string GetMorseCode(string morseCode)
        {
            switch (morseCode) 
            {
                case ".-":
                    return "A";
                case "-...":
                    return "B";
                case "-.-.":
                    return "C";
                case "-..":
                    return "D";
                case ".":
                    return "E";
                case "..-.":
                    return "F";
                case "--.":
                    return "G";
                case "....":
                    return "H";
                case "..":
                    return "I";
                case ".---":
                    return "J";
                case "-.-":
                    return "K";
                case ".-..":
                    return "L";
                case "--":
                    return "M";
                case "-.":
                    return "N";
                case "---":
                    return "O";
                case ".--.":
                    return "P";
                case "--.-":
                    return "Q";
                case ".-.":
                    return "R";
                case "...":
                    return "S";
                case "-":
                    return "T";
                case "..-":
                    return "U";
                case "...-":
                    return "V";
                case ".--":
                    return "W";
                case "-..-":
                    return "X";
                case "-.--":
                    return "Y";
                case "--..":
                    return "Z";
                case "···−−−···":
                    return "SOS";
                    default: return "";
            }

        }
    }
}

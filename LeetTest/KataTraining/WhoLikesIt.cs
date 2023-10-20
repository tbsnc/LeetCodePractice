using System;

namespace LeetTest.KataTraining
{
    public class WhoLikesIt
    {
        /// <summary>
        /// Implement the function which takes an array containing the names of people that like an item. 
        /// It must return the display text as shown in the examples:
        /// 
        /// [] -->  "no one likes this"
        ///["Peter"]                         -->  "Peter likes this"
        ///["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
        ///["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
        ///["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
        /// </summary>
        public WhoLikesIt(string[] name)
        {
            Likes(name);
        }
        public static string Likes(string[] name)
        {
            string result = string.Empty;
            
            switch (name.Length)
            {
                case 0:
                    result = "no one likes this";
                    break;
                case 1:
                    result = $"{name[0]} likes this";
                    break;
                case 2:
                    result = $"{name[0]} and {name[1]} like this";
                    break;
                case 3:
                    result = $"{name[0]}, {name[1]} and {name[2]} like this";
                    break;
                default:
                    result = $"{name[0]}, {name[1]} and {name.Length-2} others like this";
                    break;

            }

            return result;
        }
    }
}

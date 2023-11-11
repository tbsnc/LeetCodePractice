using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class TextAlignJustify
    {
        public TextAlignJustify() 
        {
            Justify("123 45 6", 7);
            Justify("Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. " +
                "In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique. " +
                "Nam a imperdiet tellus. Nulla eu vestibulum urna. Vivamus tincidunt suscipit enim, nec ultrices nisi volutpat ac. " +
                "Maecenas sit amet lacinia arcu, non dictum justo. Donec sed quam vel risus faucibus euismod. Suspendisse rhoncus rhoncus felis at fermentum. " +
                "Donec lorem magna, ultricies a nunc sit amet, blandit fringilla nunc. In vestibulum velit ac felis rhoncus pellentesque. Mauris at tellus enim. " +
                "Aliquam eleifend tempus dapibus. Pellentesque commodo, nisi sit amet hendrerit fringilla, ante odio porta lacus, ut elementum justo nulla et dolor.",
                15);


        }





        /// <summary>
        /// Your task in this Kata is to emulate text justification in monospace font. 
        /// You will be given a single-lined text and the expected justification width. 
        /// The longest word will never be greater than this width.
        /// Here are the rules:
        /// 
        ///Use spaces to fill in the gaps between words.
        ///Each line should contain as many words as possible.
        ///Use '\n' to separate lines.
        ///Gap between words can't differ by more than one space.
        ///Lines should end with a word not a space.
        ///'\n' is not included in the length of a line.
        ///Large gaps go first, then smaller ones ('Lorem--ipsum--dolor--sit-amet,' (2, 2, 2, 1 spaces)).
        ///Last line should not be justified, use only one space between words.
        ///Last line should not contain '\n'
        ///Strings with one word do not need gaps('somelongword\n').
        /// 
        /// Example with width=30:
        ///
        ///Lorem ipsum  dolor sit amet,
        ///consectetur adipiscing  elit.
        ///Vestibulum sagittis   dolor
        ///mauris, at  elementum ligula
        ///tempor eget.In quis rhoncus
        ///nunc, at aliquet orci.Fusce
        ///at dolor sit   amet felis
        ///suscipit tristique.   Nam a
        /// 
        ///  Assert.AreEqual("123  45\n6", Kata.Justify("123 45 6", 7));
        ///                   123   45\n6
        ///  "123  45  6 \n6  "
        /// </summary>
        /// <param name="str"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Justify(string str, int len)
        {
            string solution = "";
            List<string> listString = str.Split(' ').ToList();

            List<string> tempBlock = new List<string>();

            int count = 0;
            while(listString.Count > 0)
            {
                tempBlock.Add(listString[0]);
         
                count += listString[0].Length;

                if(count + tempBlock.Count - 1 > len) 
                {
                    tempBlock.RemoveAt(tempBlock.Count - 1);

                    if (tempBlock.Count == 1)
                    {
                        solution += tempBlock[0] + "\n";

                        tempBlock.Clear();
                        count = 0;
                        continue;
                    }

                    int spaces = len - tempBlock.Sum(x => x.Length);

                    while (spaces > 0)
                    {
                        for (int i = 0; i < tempBlock.Count - 1; i++)
                        {
                            if (spaces == 0) break;
                            tempBlock[i] += " ";
                            spaces--;
                        }
                       
                    }
                    tempBlock[tempBlock.Count-1] += "\n";   

                    foreach(string s in tempBlock) 
                    {
                        solution += s;
                    }
                    tempBlock.Clear();
                    count = 0;

                    continue;
                    
                }else if (count + tempBlock.Count - 1 == len)
                {
                    if (tempBlock.Count == 1)
                    {
                        solution += tempBlock[0] + "\n";
                    }

                    for (int i = 0; i < tempBlock.Count - 1; i++)
                    {
                        tempBlock[i] += " ";
                    }
                    tempBlock[tempBlock.Count-1] += "\n";

                    foreach (string s in tempBlock)
                    {
                        solution += s;
                    }

                    tempBlock.Clear();
                    count = 0;


                }

                if (listString.Count == 1 && tempBlock.Count > 0)
                {
                    if (tempBlock.Count == 1)
                    {
                        solution += tempBlock[0];
                    }
                    else
                    {

                        for (int i = 0; i < tempBlock.Count - 1; i++)
                        {
                            solution += tempBlock[i] + " ";
                        }
                        solution += tempBlock[tempBlock.Count - 1];
                    }
                    
                }

                listString.RemoveAt(0);
            }
            if (solution.EndsWith("\n")) solution = solution.Substring(0,solution.Count() -  1);
            return solution;
        }

    }
}

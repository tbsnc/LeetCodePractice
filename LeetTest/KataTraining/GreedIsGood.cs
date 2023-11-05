using System.Collections.Generic;
using System.Linq;

namespace LeetTest.KataTraining
{
    public class GreedIsGood
    {
        public GreedIsGood()
        {
            Score(new int[] { 5,1,3,4,1});
        }

        /// <summary>
        /// Greed is a dice game played with five six-sided dice. 
        /// Your mission, should you choose to accept it, is to score a throw according to these rules.
        /// You will always be given an array with five six-sided dice values.
        ///  Three 1's => 1000 points
        ///      Three 6's =>  600 points
        ///   Three 5's =>  500 points
        ///Three 4's =>  400 points
        ///hree 3's =>  300 points
        ///Three 2's =>  200 points
        ///One   1   =>  100 points
        ///One   5   =>   50 point
        /// 
        /// A single die can only be counted once in each roll. 
        /// For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.
        /// </summary>
        /// <param name="dice"></param>
        /// <returns></returns>
        public static int Score(int[] dice)
        {
            Dictionary<int, int> diceValues = new Dictionary<int, int>();
            int solution = 0;
            diceValues[1] = 0;
            diceValues[2] = 0;
            diceValues[3] = 0;
            diceValues[4] = 0;
            diceValues[5] = 0;
            diceValues[6] = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (diceValues.Any(x => x.Key == dice[i]))
                {
                    diceValues[dice[i]]++;

                    if (diceValues[dice[i]] == 3)
                    {
                        switch (dice[i])
                        {
                            case 1:
                                solution += 1000;
                                break;
                            case 2:
                                solution += 200;
                                break;
                            case 3:
                                solution += 300;
                                break;
                            case 4:
                                solution += 400;
                                break;
                            case 5:
                                solution += 500;
                                break;
                            case 6:
                                solution += 600;
                                break;
                            default: break;
                        }

                        diceValues[dice[i]] = 0;
                    }

                }
              
            }

            for (int i = 0; i < diceValues[5]; i++)
            {
                solution += 50;
            }
            for (int i = 0; i < diceValues[1]; i++)
            {
                solution += 100;
            }
            return solution;
        }
    }
}

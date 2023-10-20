using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest
{
    public class _22_GenerateParentheses
    {
        public _22_GenerateParentheses(int n)
        {
            GenerateParenthesis(n);
        }


        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();

            Stack<string> stack = new Stack<string>();

            BackTrack(n,0, 0, ref stack, ref result);

            return result;
        }

        public static void BackTrack(int n,int noOpen, int noClosed, ref Stack<string> stack,ref List<string> result)
        {
            if ((noOpen == noClosed) && noOpen == n)
            {
                string temp = string.Empty;

                for (int i = stack.Count - 1; i >= 0; i--)
                {
                    temp += stack.ElementAt(i);
                }

                result.Add(temp);
                return;
            }

            if (noOpen < n)
            {
                stack.Push("(");
                BackTrack(n, noOpen + 1, noClosed, ref stack,ref result);
                stack.Pop();
            }

            if (noClosed < noOpen)
            {
                stack.Push(")");
                BackTrack(n,noOpen,noClosed+1, ref stack, ref result);
                stack.Pop();
            }

            
        }

    }


}

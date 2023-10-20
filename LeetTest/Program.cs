using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetTest
{
    public class ListNode //21. Merge Two sorted list
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 3,2,4 };
            //int[] solutionO2 = TwoSum(nums, 6);
            //Console.WriteLine($"O(n^2) = [{solutionO2[0]}, {solutionO2[1]}]");
            //int[] solutionOn = TwoSumTwo(nums, 6);
            //Console.WriteLine($"O(n) = [{solutionOn[0]}, {solutionOn[1]}]");

            //int[] betterSol = TwoSumBest(nums, 6);
            //Console.WriteLine($"[{betterSol[0]}, {betterSol[1]}]");
            // Console.Write(IsNumberPalindrome(1000021).ToString());

            // Console.WriteLine(RomanToInt("MDLXX").ToString());
            //Console.WriteLine(ValidParentheses2("([)]").ToString());
            //Console.WriteLine(ValidParentheses2("((").ToString());
            //Console.WriteLine(ValidParentheses2("([](()(){[]}))").ToString());
            //Console.WriteLine(ValidParentheses2("()[]{}").ToString());
            //Console.WriteLine(LongestCommonPrefix(
            //   new string[] { "cir", "car" }
            //   ));
            //Console.WriteLine(LongestCommonPrefix(
            //  new string[] { "flower", "flower", "flower", "flower" })
            // );
            //Console.WriteLine(RemoveElement(new int[] { 1, 0, 0, 0, 0, 3, 3 }, 0).ToString());
            //Console.WriteLine(StrStrLOL("mississippi", "issipi"));

            // Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
            /// Console.WriteLine(AddBinaryReal("11", "1"));
            /// 
            //Console.WriteLine(MySqrt(2147483647));
            //  Console.WriteLine(ClimbStairs(45));
            // Merge(new int[] { 4, 4, 0, 0, 0, 0 }, 1, new int[] { 1, 2, 3, 5, 6 }, 5);
            //Merge(new int[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 },3,new int[] { -1, 1, 1, 1, 2, 3 },6);
            //Merge(new int[] { 2, 0 }, 1, new int[] { 1}, 1);
            //// Merge(new int[] { 1,2,3,4,5,0 }, 5, new int[] { 6 }, 1);
            // Console.WriteLine(GetRow(0));
            //Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
            //Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
            //Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));

            //Console.WriteLine(ConvertToTitle2(2147483647));
            //Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
            // Console.WriteLine(LengthOfLongestSubstring("abcdcefg"));
            // Console.WriteLine(LengthOfLongestSubstring2("abcdcefg"));
            //Console.WriteLine(LongestPalindromeOn2("bbb"));
            //Console.WriteLine(Reverse(-123));
            //  Console.WriteLine(IsStrPalindrome("anavolimilovana").ToString());
            //Console.WriteLine(MyAtoi("  -0012a42"));
            //Console.WriteLine(MyAtoi("words and 987"));
            //Console.WriteLine(new _12_IntegerToRoman(1994));
            // Console.WriteLine(new _15_3Sum(new int[] { -1, 0, 1, 2, -1, -4 }));
            //Console.WriteLine(new _17_LetterCombinationsPhoneNuber("234"));
            Console.WriteLine(new _22_GenerateParentheses(3).ToString());
        }
       
        
        public static void GenerateParenthesis()
        {

        }

        public static int MaxAreaFaster(int[] height)
        {
            int maxArea = 0;
            int currentArea = 0;
            int l = 0;
            int r = height.Length - 1;

            while (l < r)
            {
                currentArea = (r - l) * (height[r] > height[l] ? height[l] : height[r]);
                maxArea = currentArea > maxArea ? currentArea : maxArea;
                if (height[l] > height[r])
                {
                    r--;
                }else
                {
                    l++;
                }
            }

            return maxArea;
        }
        public static int MaxArea(int[] height)//11. Container With Most Water

        {
            int maxArea = 0;
            int currentArea = 0;
            for(int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    currentArea = (j - i) * (height[i] < height[j] ? height[i] : height[j]);
                     maxArea = maxArea < currentArea ? currentArea : maxArea;    
                }
            }


            return maxArea;
        }

        public static int MyAtoi(string s)
        {
            if(int.TryParse(s,out int x)) return x;
            int prefix=1;
            bool numReached = false;
            bool prefixAsigned = false;
            s = s.Trim();
            string newS = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (newS.Length == 0 && (s[i] == '+' || s[i] == '-'))
                {
                    if (prefixAsigned) return 0;
                    prefix = s[i] == '+' ? 1 : -1;
                    continue;
                }

                if (int.TryParse(s[i].ToString(), out x))
                {
                    newS += s[i];
                    numReached = true;
                }else if (newS.Length == 0)
                {
                    return 0;
                }
                else if (numReached)
                {
                    if (int.TryParse(newS, out x))
                    {
                        return int.Parse(newS) * prefix;
                    }
                    else
                    {
                        return prefix == 1 ? int.MaxValue : int.MinValue;
                    }
                }
            }
           
            if (int.TryParse(newS, out x))
            {
                return int.Parse(newS)*prefix;
            }else
            {
                return prefix == 1 ? int.MaxValue : int.MinValue;
            }
        }


        public static int Reverse(int x)
        {
            string number = x.ToString();
            string newNumber = "";
            bool negative = false;
            if (number[0] == '-')
            {
                number = number.Substring(1);
                negative = true;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                newNumber+= number[i];
            }

            if(negative)newNumber = string.Format("-{0}", newNumber);

            return int.TryParse(newNumber, out x) ? int.Parse(newNumber) : 0;
           
        }
        public static string LongestPalindromeOn2(string s)
        {
            string result = "";
            string current = "";
           
            for (int i = 0; i < s.Length  ; i++)
            {
                
                for (int j = 1; j <= s.Length - i ; j++)
                {
                    current = s.Substring(i, j);
                    if (IsStrPalindrome(current))
                    {
                        result = current.Length > result.Length ? current : result;
                    }
                }

            }


            return result;
        }




        public static bool IsStrPalindrome(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int LengthOfLongestSubstring2(string s)
        {
            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
            int l = 0;
            int maxLen = 0;

            char character;

            for (int r = 0; r < s.Length; r++)
            {
                character = s[r];

                if (keyValuePairs.ContainsKey(character) && keyValuePairs[character] >= l)
                {
                    l = keyValuePairs[character] + 1;
                }else
                {
                    maxLen = maxLen > r - l + 1 ? maxLen : r - l + 1;
                }
                keyValuePairs[character] = r;
            }

            return 0;
        }


        public static int LengthOfLongestSubstring(string s) //#3  Longest substring without repeating chars
        {
            Dictionary<char, int> seenChars = new Dictionary<char, int>();
            int lPointer = 0;
            int maxLength = 0;
            char character;
            for (int rPointer = 0; rPointer < s.Length; rPointer++)
            {
                character = s[rPointer];
                if (seenChars.ContainsKey(character) && seenChars[character] >= lPointer)
                {
                    lPointer = seenChars[character] + 1;
                }else
                {
                    maxLength = maxLength > rPointer - lPointer + 1 ? maxLength : rPointer - lPointer + 1;
                }
                seenChars[character] = rPointer;
            }

            return maxLength;


        }
        public static int MajorityElement(int[] nums) //169. Majority element
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.Any(x => x.Key == nums[i]))
                {
                    dict[nums[i]]++;
                }else
                {
                    dict[nums[i]] = 1;
                }
            }
            var result = dict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return result;
        }
        public static string ConvertToTitle2(int columnNumber)
        {
            string result = "";
            while (columnNumber > 0)
            {
                columnNumber--;
                char c = (char)('A' + columnNumber % 26);
                result = c + result;
                columnNumber /= 26;
            }
            return result;
        }
        public static string ConvertToTitle(int columnNumber)
        {
            List<char> alphabet = new List<char>();
            List<int> listInt = new List<int>();
            listInt.Add(0);
            listInt.Add(0);
            listInt.Add(0);
            listInt.Add(0);
            listInt.Add(0);
            listInt.Add(0);
            listInt.Add(0);

            string s = "";
            int listIntIndex = 1;
            bool carry = false;
            #region alphabet
            alphabet.Add('-');
            alphabet.Add('A');
            alphabet.Add('B');
            alphabet.Add('C');
            alphabet.Add('D');
            alphabet.Add('E');
            alphabet.Add('F');
            alphabet.Add('G');
            alphabet.Add('H');
            alphabet.Add('I');
            alphabet.Add('J');
            alphabet.Add('K');
            alphabet.Add('L');
            alphabet.Add('M');
            alphabet.Add('N');
            alphabet.Add('O');
            alphabet.Add('P');
            alphabet.Add('Q');
            alphabet.Add('R');
            alphabet.Add('S');
            alphabet.Add('T');
            alphabet.Add('U');
            alphabet.Add('V');
            alphabet.Add('W');
            alphabet.Add('X');
            alphabet.Add('Y');
            alphabet.Add('Z');
            #endregion

            for (int i = 1; i <= columnNumber; i++)
            {
                if (listInt[listInt.Count - 1] == 26)
                {

                    for (int j = listInt.Count - 1; j >= 0; j--)
                    {

                        if (listInt[j] == 26)
                        {
                            listInt[j] = 1;
                            
                            carry = true;
                        }
                        else if (carry)
                        {
                            listInt[j]++;
                            if (listInt[j] == 27)
                            {
                                listInt[j] = 1;
                                carry = true;
                            }else
                            {
                                carry = false;
                            }
                        }
                    }
                }
                else
                {
                    listInt[listInt.Count - 1]++;
                }
            }
            foreach (int i in listInt.Where(x => x!=0))
            {
                s += alphabet[i];

            }
            return s;
        }

        public static int SingleNumber(int[] nums)//136. Single Number
        {
            List<int> listNums = new List<int>();   
            listNums = nums.ToList();
            if(nums.Length == 1) return nums[0];
            for (int i = listNums.Min(); i < listNums.Count; i++)
            {
                if (listNums.Where(x => x == i).Count() == 1) return i;
            }
            return 0;
        }
        public static bool IsPalindrome(string s) // #125 valid palindrome
        {
            List<char> chars = new List<char>();
            foreach (char c in s.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                {
                    chars.Add(c);
                }
            }
            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i] != chars[chars.Count - i-1])
                {
                    return false;
                }
            }
            return true;
        }
        public static int MaxProfit(int[] prices)//121. Best Time to Buy and Sell Stock
        {
            int cheapest = 0;
            int maxProfit = 0;
            
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 0)
                {
                    cheapest = prices[i];
                    continue;
                }

                if (maxProfit < prices[i] - cheapest) 
                {
                    maxProfit = prices[i] - cheapest;
                }

                if (cheapest > prices[i])
                {
                    cheapest = prices[i];
                }

                
            }

            return maxProfit;
        }

        public static IList<int> GetRow(int rowIndex) // 119 pascal's triangle 2
        {
            IList<IList<int>> solutionList = new List<IList<int>>();
            List<int> tempList = new List<int>();

            for (int i = 0; i <= rowIndex; i++)
            {
                if (i == 0)
                {
                    solutionList.Add(new List<int>() { 1 }.ToArray());
                    if (i == rowIndex) return new int[] { 1 };
                }
                else if (i == 1)
                {
                    solutionList.Add(new List<int>() { 1, 1 }.ToArray());
                    if (i == rowIndex) return new int[] { 1 , 1};
                }
                else
                {
                    tempList.Add(1);

                    for (int j = 0; j < solutionList[i - 1].Count - 1; j++)
                    {
                        tempList.Add(solutionList[i - 1][j] + solutionList[i - 1][j + 1]);
                    }


                    tempList.Add(1);
                    if (i == rowIndex  ) return tempList;
                    solutionList.Add(tempList.ToArray());
                    tempList.Clear();
                }



            }


            return tempList;
        }
        public static IList<IList<int>> Generate(int numRows) //#118 pascal's triangle
        {
            IList<IList<int>> solutionList = new List<IList<int>>();
            List<int> tempList = new List<int>();

            for (int i = 1; i <= numRows; i++)
            {
                if (i == 1)
                {
                    solutionList.Add(new List<int>() { 1 }.ToArray());
                } else if (i == 2)
                {
                    solutionList.Add(new List<int>() { 1, 1 }.ToArray());
                } 
                else
                {
                    tempList.Add(1);

                    for (int j = 0; j < solutionList[i - 2].Count - 1; j++)
                    {
                        tempList.Add(solutionList[i - 2][j] + solutionList[i - 2][j + 1]);
                    }


                    tempList.Add(1);
                    solutionList.Add(tempList.ToArray());
                    tempList.Clear();
                }



            }


            return solutionList;

        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0 && n == 0) return;
            List<int> list = new List<int>();
            List<int> listBig = new List<int>();
            List<int> solution = new List<int>();

            if (n < m)
            {
                list = nums2.ToList();
                listBig = nums1.ToList();
            }else
            {
                list = nums1.ToList();
                listBig = nums2.ToList();
            }

            for (int i = list.Count()-1; i >= 0; i--)
            {
                if (list[i] == 0) { list.RemoveAt(i); } else { break; }
            }
            for (int i = listBig.Count() - 1; i >= 0; i--)
            {
                if (listBig[i] == 0) { listBig.RemoveAt(i); } else { break; }
            }
            for (int i = 0; i < listBig.Count(); i++)
            {
               
                if (list.Any(x => x < listBig[i]))
                {
                    foreach(int item in list.FindAll(x => x < listBig[i]))
                    {
                        solution.Add(item);
                        list.Remove(item);
                    }
                    
                }

                if(list.Any(x => x == listBig[i]))
                {
                    foreach (var item in list.FindAll(x => x == listBig[i]))
                    {
                        solution.Add(item);
                        list.Remove(item);
                    }
                    
                }

                solution.Add(listBig[i]);

                if (list.Count > 0 && i == listBig.Count - 1)
                {
                    foreach (var item in list.FindAll(x => x > listBig[i]))
                    {
                        solution.Add(item);
                    }
                }
                
                //if ((listBig.Count == list.Count) && i == listBig.Count - 1)
                //{
                //    foreach (var item in list.FindAll(x => x > listBig[i]))
                //    {
                //        solution.Add(item);
                //        list.Remove(item);
                //    }

                //}
            }
            for (int i = 0; i < solution.Count();i++)
            {
                nums1[i] = solution[i];
            }
        }
        public static int ClimbStairs(int n)//#70
        {

            if(n == 0) return 0;

            int prev = 0;
            int next = 1;
            for (int i = 1; i <= n; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }

        public static int MySqrtBetter(int x)
        {
            if (x <= 1)
            {
                return x;
            }

            long left = 1, right = x / 2;

            while (left <= right)
            {
                long mid = left + (right - left)/2;

                if (mid * mid > x)
                {
                    right = mid - 1;
                } 
                else if((mid + 1) * (mid + 1) > x)
                {
                    return (int)mid;   
                }else
                {
                    left = mid + 1;
                }

            }
            return (int)right;


        }

        public static int MySqrt(int x)
        {
            long no1;

            for (int i = 0; i < x; i++)
            {
                no1 = i;
                
                if (no1 * no1 > x)
                {
                    return i - 1;
                }
                else if (no1 * no1 == x)
                {
                    return i;
                }
            }
            return 0;
           
        }
        public static string AddBinaryReal(string aa, string bn)
        {
            StringBuilder a = new StringBuilder(aa);
            StringBuilder b = new StringBuilder(bn);
            

            bool[] returnbits = new bool[a.Length];

            for (int i = 0; i <= b.Length - 1; i++)
            {
                bool r = false; //r=0
                for (int j = a.Length - 1; j <= a.Length; j--)
                {
                    bool breakcond = false;
                    bool o1 = Convert.ToBoolean(int.Parse(a[i].ToString()));
                    if (r == false)
                    {
                        if (o1 == false) { o1 = true; breakcond = true; }//break
                        else if (o1 == true) { o1 = false; r = true; }
                    }
                    else
                    {
                        if (o1 == false) { o1 = true; breakcond = true; }//break
                        else if (o1 == true) { o1 = false; r = true; }
                    }
                    
                    a[j] = o1 == true ? '1' : '0' ;
                    if (breakcond == true)
                    {
                        break;
                    }
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                returnbits[i] = Convert.ToBoolean(a[i]);
            }

                        

            return "";
        }
        public static string AddBinary(string a, string b)
        {
            long no1 = Convert.ToInt64(a, 2);
            long no2 = Convert.ToInt64(b, 2);
            return Convert.ToString(no1 + no2, 2);
        }

        public static int[] PlusOne(int[] digits)
        {
            bool plusOne = false;
            List<int> list = new List<int>();

            if (!digits.Any(x => x != 9))
            {
                list.Add(1);
                for(int i = 1; i < digits.Length + 1; i++)
                {
                    list.Add(0);
                }
                
            }
            if(list.Count > 0) return list.ToArray();

            for (int i = digits.Length - 1; i >= 0; i--)
            {

                if (plusOne && digits[i] != 9)
                {
                    digits[i] += 1;
                    return digits;
                }

                if (digits[i] == 9) 
                {
                    digits[i] = 0;
                    plusOne = true;
                }else 
                {
                    digits[i]++;
                    return digits;
                }
            }
            return digits;
        }

        public static int LenghtOfLastWord(string s)
        {
            List<string> lista = new List<string>();
            foreach (string item in s.Split(Convert.ToChar(" ")))
            {
                if (item.Trim().Length > 0)
                {
                    lista.Add(item);
                }
                
            }

            return lista[lista.Count - 1].Length;

        }
        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            int next = Array.FindIndex(nums, x => x > target);
            if(next == -1) return nums.Length;
            return next - 1;
        }
        public static int StrStrLOL(string haystack, string needle) //#28 lol
        {
            return haystack.IndexOf(needle);
        }
        public static int StrStr(string haystack, string needle)  //#28
        {
            if (needle.Length > haystack.Length) return -1;
            for(int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (needle.Length > haystack.Length - i) return -1;
                    if (needle == haystack.Substring(i,  needle.Length))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public static int RemoveElement(int[] nums, int val) // or put all elements of value val to the end of an array, #27
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            for (int i = 0; i < nums.Count(); i++)
            {
                dic[i] = nums[i] == val ? "_" : nums[i].ToString();
            }
            int count = dic.Count;
            for (int i = 0; i < count; i++)
            {
                if (dic[i] == "_") dic.Remove(i);
            }
            count = 0;
            foreach (int i in dic.Keys)
            {
                nums[count] = Convert.ToInt32(dic[i]);
                count++;
            }
               
         
            return dic.Count();
        }


        public static int RemoveDuplicates2(int[] nums) //#26
        {
            HashSet<int> ints = new HashSet<int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!ints.Contains(nums[i]))
                {
                    ints.Add(nums[i]);
                    nums[count] = nums[i]; 
                    count++;
                }
            }
            return ints.Count();

        }
        public static int RemoveDuplicates(int[] nums)
        {
            Dictionary<int,int> result = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                {
                    continue;
                }else
                {
                    result[nums[i]] = nums[i];
                }
            }
            int count = 0;
            for (int i = result.Min(x=>x.Value); i <= result.Max(x => x.Value); i++)
            {
                if (result.Any(x => x.Value == i))
                {
                    nums[count] = i;
                    count++;
                }
            }
            return result.Count;
        }
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();

            while(list1.next != null )
            {
            }
            return new ListNode();
        }





        public static string LongestCommonPrefix(string[] strs)
        {
            Dictionary<int,string> solutionDict = new Dictionary<int,string>();
            string solution = "";
            if (strs.Count() == 1) return strs[0];
            if (strs.Count() == 0) return "";
            
            int minLen = strs.Min(x => x.Length);
            int anyMatch = 0;
            solution = strs[0].Substring(0,minLen);

            for (int i = 0; i < strs.Count(); i++)
            {
                anyMatch = 0;
                for (int j = 0; j < minLen; j++)
                {
                    if (solution[j] == strs[i][j])
                    {
                        anyMatch++;
                        if (solutionDict.ContainsKey(i))
                        {
                            solutionDict[i] += strs[i][j];
                        }else
                        {
                            solutionDict[i] = strs[i][j].ToString();
                        }
                    }
                    else { break; }
                }
                if (anyMatch == 0) return "";
            }
            solution = solutionDict.FirstOrDefault(x => x.Value.Length == solutionDict.Min(y => y.Value.Length)).Value;
            return solution;
        }






        public static bool ValidParentheses2(string text) //or how does it hurd
        {
            if(text.Length % 2 != 0) return false;
            Dictionary<char,char> valuePairs = new Dictionary<char,char>();
            valuePairs['('] = ')';
            valuePairs['['] = ']';
            valuePairs['{'] = '}';
            Stack<char> stack = new Stack<char>();

            char[] charArrOpen = new char[] { '(', '[', '{' };
            char[] charArrClosed = new char[] { ')', ']', '}' };

            for (int i = 0; i < text.Length; i++)
            {
                if (charArrOpen.Contains(text[i]))
                {
                    stack.Push(text[i]);
                }else if (charArrClosed.Contains(text[i]))
                {
                    if (stack.Count == 0) return false;
                    var popValue = stack.Pop();
                    if (!valuePairs.Any(x => x.Key == popValue && x.Value == text[i]))
                    {
                        return false;
                    }
                }
            }
            if(stack.Count == 0) return true;
            return false;
        }
        public static bool ValidParentheses(string text) 
        {
            var split1 = text.Substring(0, text.Length / 2);
            var split2 = text.Substring(text.Length / 2, text.Length / 2 );

            while (CheckSolution(split1))
            {
                for (int i = 0; i < split1.Length; i++)
                {
                    if ((split1[i] == '(' && split1[i + 1] == ')') || (split1[i] == '{' && split1[i + 1] == '}') || (split1[i] == '[' && split1[i + 1] == ']'))
                    {
                        split1 = split1.Remove(i, 2);


                    }
                }
            }

            while (CheckSolution(split2))
            {


                for (int j = 0; j < split2.Count(); j++)
                {
                    if ((split2[j] == '(' && split2[j + 1] == ')') || (split2[j] == '{' && split2[j + 1] == '}') || (split2[j] == '[' && split2[j + 1] == ']'))
                    {
                        split2 = split2.Remove(j, 2);


                    }
                }

            }
            split2 = split2.Replace(')', '(');
            split2 = split2.Replace(']', '[');
            split2 = split2.Replace('}', '{');
            if (split1 == split2) return true;
            return false;
        }


        public static bool CheckSolution(string text)
        {
            var split1 = text;
            
            for (int i = 0; i < split1.Length; i++)
            {
                if (i == split1.Length - 1) continue;
                if ((split1[i] == '(' && split1[i + 1] == ')') || (split1[i] == '{' && split1[i + 1] == '}') || (split1[i] == '[' && split1[i + 1] == ']'))
                {
                    return true;
                }
            }
            return false;
        }
            /// <summary>
            /// ////////////////
            /// </summary>
            /// <param name="s"></param>
            /// <returns></returns>
        


            public static int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict['I'] = 1;
            dict['V'] = 5;
            dict['X'] = 10;
            dict['L'] = 50;
            dict['C'] = 100;
            dict['D'] = 500;
            dict['M'] = 1000;

            for (int i = 0; i < s.Count(); i++)
            {
                if (i == s.Count() - 1)
                {
                    sum += dict[s[i]];
                    continue;
                }

                if (dict[s[i]] > dict[s[i + 1]])
                {
                    sum += dict[s[i]];
                }
                else if (dict[s[i]] == dict[s[i + 1]])
                {
                    sum += (dict[s[i]] * 2);
                    i++;
                    if (i != s.Count() - 1 && s[i] == s[i + 1])
                    {
                        sum += dict[s[i]];
                        i++;
                    }
                }
                else if (dict[s[i]] < dict[s[i + 1]])
                {
                    sum += (dict[s[i + 1]] - dict[s[i]]);
                    i++;
                }

            }
            return sum;
        }

        public static bool IsNumberPalindrome(int number)
        {
            string strNumber = number.ToString();
            bool result = true;
            for (int i = 0; i < strNumber.Length; i++)
            {
                if (strNumber[i] != strNumber[strNumber.Length - 1 - i])
                {
                    result =  false;
                    break;
                }
            

            }
            return result;
        }

        public static int[] TwoSumBest(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                temp = target - nums[i];
                if (dict.ContainsKey(temp))
                {
                    return new int[] { dict[temp] , i };
                }
                dict[nums[i]] = i;
            }
            return null;
        }


        public static int[] TwoSumTwo(int[] nums, int target)
        {
            int[] solution = new int[2];
            Dictionary<int,int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                

                if (i != nums.Length - 1 && nums[i] + nums[i + 1] == target)
                {
                    solution[0] = i;
                    solution[1] = i + 1;
                    return solution;
                }
                else if (dict.Any(x => x.Value + nums[i] == target))
                {
                    solution[0] = dict.SingleOrDefault(x => x.Value + nums[i] == target).Key;
                    solution[1] = i;
                    return solution;
                }
                dict.Add(i, nums[i]);


            }

            return solution;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] solution = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            solution[0] = i;
                            solution[1] = j;
                            return solution;
                        }
                    }
                }
            }


            return null;
        }
    }

   
}

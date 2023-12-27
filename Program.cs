using System;
using System.Collections.Generic;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = Console.ReadLine();
            // 'a' =97 A=65 z=122
            //Console.WriteLine((int)myString[0]);
            //Console.WriteLine(LengthOfLongestSubstring("accccbcdef"));
            /* Console.WriteLine();*/
            //var f = new _166FractionRecurringDecimal();
            // Console.WriteLine(f.FractionToDecimal(-1,-2147483648)); 
           var a = new _2896ApplyOperationsToMakeTwoStringEqual();
            a.MinOperations("1100011000", "0101001010", 2);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            Queue<char> queue = new Queue<char>();
            int[] records = new int[200];
            int max = 0;
            int l = 0;
            for (int r = 0; r < s.Length; r++)
            {
                int currentIndex = (int)s[r];
                queue.Enqueue(s[r]);
                records[currentIndex]++;
                if (max < (r - l+1)&& records[currentIndex]!=2) max = r - l+1;
                //计算最大值
                //表示已经不符合规则了
                while (records[currentIndex] == 2)
                {
                    int erase = queue.Dequeue();
                    //Console.WriteLine(records[currentIndex] + "" + currentIndex);
                    records[erase]--;
                    l++;

                }

            }
            return max;
        
        }
    }
}

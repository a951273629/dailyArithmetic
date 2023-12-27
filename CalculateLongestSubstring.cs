using System;
using System.Collections.Generic;
using System.Text;

namespace calculate
{
    class CalculateLongestSubstring
    {

        public int LengthOfLongestSubstring(string s)
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
                if (max < (r - l + 1) && records[currentIndex] != 2) max = r - l + 1;
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
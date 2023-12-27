using System;
using System.Collections.Generic;
using System.Text;

namespace calculate
{
    class _1871JumpGame
    {

        /// <summary>
        ///  站在当前的位置，看之前 minJump到maxJump 中间有没有可以到到达当前位置的地方，有就标记当前的点可以到达。没有就是false
        /// </summary>
        /// <param name="s"></param>
        /// <param name="minJump"></param>
        /// <param name="maxJump"></param>
        /// <returns></returns>
        public bool CanReach(string s, int minJump, int maxJump)
        {
            if (s[s.Length - 1] == '1') return false;
            bool[] dp = new bool[s.Length];
            dp[0] = true;

            // previous of position
            int previous = 0;
            // start dot
            for (int i = previous+minJump; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    for (int j = minJump; j <=maxJump; j++)
                    {
                        int temp = i - j;
                        if (temp >= 0&&temp <= s.Length&&dp[temp])
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                }

            }
            return dp[s.Length-1];
        }
    }
}

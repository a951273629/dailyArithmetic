using System;
using System.Collections.Generic;
using System.Text;

namespace calculate
{
    class _2896ApplyOperationsToMakeTwoStringEqual
    {
        public int MinOperations(string s1, string s2, int x)
        {
            bool[] equals = new bool[s1.Length];
            for (int i = 0; i < s1.Length; i++)
            {
                equals[i] =(s1[i] == s2[i];
            }
            
            Console.WriteLine(String.Concat(equals));
            return 0;
        }
    }
}

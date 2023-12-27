using System;
using System.Collections.Generic;
using System.Text;

namespace calculate
{
    class _166FractionRecurringDecimal
    {
        public string FractionToDecimal(int numerator, int denominator)
        {

            if (numerator == 0) return "0";
            //Map
            var dict = new Dictionary<long,int>();
            //decimal result = numerator / denominator;
            var res = new StringBuilder();
            //考虑结果可能是负数的情况 异或 相同正负返回假，不同正负返回正 
            var orNegative = (numerator>0)^(denominator>0)?"-":"" ;
            res.Append(orNegative);

            long num = Math.Abs((long)numerator);
            long den = Math.Abs((long)denominator);

            res.Append(num / den);

            //不能整除的部分
            num %= den;

            if (num == 0) return res.ToString();

            res.Append(".");
            while (num != 0)
            {
                num *= 10;
                res.Append(num / den);
                num %= den;
                if (dict.ContainsKey(num))
                {
                    int index = dict[num];
                    res.Insert(index, "(");
                    res.Append(")");
                    break;
                }else dict.Add(num, res.Length);
                if (res.Length >= 1e4) break;

            }
            return res.ToString();
        }

    }
}

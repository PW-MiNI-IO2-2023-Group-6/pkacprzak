using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringCalculator
    {
        public int Calculate(string arg)
        {
            if (arg == "") return 0;
            var numSplit = arg.Split(',', '\n').Select(str => int.Parse(str));
            foreach (var num in numSplit)
            {
                if (num < 0) throw new ArgumentOutOfRangeException();
            }
            return numSplit.Where(num => num <= 1000).Sum();
        }
    }
}
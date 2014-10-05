using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LINQTest
{
    static void Main()
    {
        List<int> nums = new List<int>();
        nums.Add(23);
        nums.Add(2);
        nums.Add(32);
        nums.Add(43);
        nums.Add(12);
        nums.Add(57);
        nums.Add(9);
        nums.Add(789);
        nums.Add(9);

        nums.WhereNot(x => x < 50);
        Console.WriteLine(nums.WhereNot(x => x < 50));
    }
}

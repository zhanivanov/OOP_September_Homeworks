using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtentions
{
    class TestExtensions
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder("georgi ivanov");
            IEnumerable<object> chars = new List<string>() { "georgiev", "ivanov" };
            Console.WriteLine(str.AppendAll(chars));
            string substring = str.Substring(4, 9);
            str.RemoveText("georgi ");
            Console.WriteLine(str);
            Console.WriteLine(substring);
        }
    }
}

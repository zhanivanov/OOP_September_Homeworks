using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Extensions
{
    public static string Substring(this StringBuilder str, int startIndex, int length)
    {
        string newString = "";
        if (startIndex > str.Length ||
            length > str.Length - startIndex ||
            startIndex < 0 ||
            length < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        for (int i = 0; i < str.Length; i++)
        {
            if (i == startIndex)
            {
                for (int j = i; j < length + i; j++)
                {
                    newString += str[j];
                }
            }
        }

        return newString;
    }

    public static StringBuilder RemoveText(this StringBuilder str, string text)
    {
        int index = str.ToString().ToLower().IndexOf(text.ToLower());
        str.Remove(index, text.Length);

        return str;
    }

    public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            str.Append(item.ToString());
        }

        return str;
    }
}

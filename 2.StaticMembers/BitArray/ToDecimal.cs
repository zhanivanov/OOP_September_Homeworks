
namespace BitArray
{
    using System;
    using System.Numerics;

    public static class ToDecimalNum
    {
        public static string ToDecimal(this string binary)
        {
            BigInteger decimalNum = new BigInteger();
            int multiplyer = 0;

            for (int i = 0; i <= binary.Length - 1; i++)
            {
                if (binary[i] == '1')
                {
                    decimalNum += (int)Math.Pow(2, multiplyer);
                }

                multiplyer++;
            }

            return decimalNum.ToString();
        }
    }
}
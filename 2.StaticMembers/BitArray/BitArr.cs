using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitArray
{

    class BitArr
    {
        private bool[] bitArray;
        private int size;

        public BitArr(int size)
        {
            this.Size = size;
            this.bitArray = new bool[this.size];
        }

        public int Size
        {
            get { return this.size; }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("size", "Array size must be in the range [0...1000000]");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > this.size - 1)
                {
                    throw new IndexOutOfRangeException("You are trying to access an index that doesn`t exist");
                }

                return this.bitArray[index] ? 1 : 0;
            }

            set
            {
                if (index < 0 || index > this.size - 1)
                {
                    throw new IndexOutOfRangeException("You are trying to access an index that doesn`t exist");
                }

                if (value != 1 && value != 0)
                {
                    throw new ArgumentException("bool array requires bool input");
                }

                this.bitArray[index] = value == 1 ? true : false;
            }
        }

        public override string ToString()
        {
            return String.Join("", this.bitArray.Select(b => b ? 1 : 0).ToArray());
        }

    }

    class BitArrayTester
    {
        public static void Main()
        {
            BitArr myArray = new BitArr(16);

            myArray[0] = 1;
            myArray[1] = 0;
            myArray[15] = 1;

            string decimalValue = myArray.ToString().ToDecimal();

            Console.WriteLine(decimalValue);
        }
    }
}
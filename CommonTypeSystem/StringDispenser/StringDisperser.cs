using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{   
    [Serializable]
    class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private string inputString;

        public StringDisperser(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                this.InputString += strings[i];
            }
        }

        public string InputString
        {
            get { return this.inputString; }
            set { this.inputString = value; }
        }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;

            if (stringDisperser == null)
            {
                return false;
            }

            if (!Object.Equals(this.inputString, stringDisperser.inputString))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = (this.inputString).GetHashCode();

            return hashCode;
        }

        public StringDisperser Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                return (StringDisperser)formatter.Deserialize(ms);
            }
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var letter in this.inputString)
            {
                result.AppendFormat("{0} ", letter);
            }

            return result.ToString();
        }

        public int CompareTo(StringDisperser other)
        {
            int compareResult = string.Compare(this.inputString, other.inputString);

            if (compareResult != 0)
            {
                return compareResult;
            }

            return 0;
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.inputString.Length; i++)
            {
                yield return this.inputString[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static bool operator ==(StringDisperser stringDisperser, StringDisperser otherString)
        {
            return StringDisperser.Equals(stringDisperser, otherString);
        }

        public static bool operator !=(StringDisperser stringDisperser, StringDisperser otherString)
        {
            return !StringDisperser.Equals(stringDisperser, otherString);
        }
    }
}

using System;

namespace School
{
    class Student : People
    {
        private string ucn;

        public Student(string ucn, string name, string details = null) : base(name, details)
        {
            this.UCN = ucn;
        }

        public string UCN
        {
            get { return this.ucn; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.ucn = value;
                }
            }
        }
    }
}

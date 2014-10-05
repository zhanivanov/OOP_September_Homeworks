using System;

namespace School
{
    abstract class People
    {
        private string name;
        private string details;

        public People(string name, string details = null)
        {
            this.Name = name;
            this.details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace School
{
    class Teacher : People
    {
        private List<Disciplines> disciplines = new List<Disciplines>();

        public Teacher(List<Disciplines> disciplines, string name, string details = null)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public List<Disciplines> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                if (value.Contains(null))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.disciplines = value;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumenStudentWorker
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName","Cannot be null or empty");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName 
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "Cannot be null or empty");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}

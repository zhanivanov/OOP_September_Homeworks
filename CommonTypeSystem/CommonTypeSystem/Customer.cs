using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    [Serializable]
    class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string fullName;
        private string id;
        private string permanentAddress;
        private string phoneNumber;
        private string email;
        List<Payment> payments = new List<Payment>();
        CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName, string id, string permanentAddress, string phoneNumber, string email, List<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
            this.fullName = this.firstName + " " + this.middleName + " " + this.lastName;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set { this.permanentAddress = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<Payment> Payments
        {
            get { return this.payments; }
            set { this.payments = value; }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set { this.customerType = value; }
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            bool firstNameCompare = Object.Equals(this.firstName, customer.firstName);
            bool middleNameCompare = Object.Equals(this.middleName, customer.middleName);
            bool lastNameCompare = Object.Equals(this.lastName, customer.lastName);
            bool idCompare = Object.Equals(this.id, customer.id);
            bool addressCompare = Object.Equals(this.permanentAddress, customer.permanentAddress);
            bool phoneCompare = Object.Equals(this.phoneNumber, customer.phoneNumber);
            bool emailCompare = Object.Equals(this.email, customer.email);
            bool customerTypeCompare = this.customerType == customer.customerType ? true : false;

            if (customer == null)
            {
                return false;
            }
            if (!firstNameCompare ||
                !middleNameCompare ||
                !lastNameCompare ||
                !idCompare ||
                !addressCompare ||
                !phoneCompare ||
                !emailCompare ||
                !customerTypeCompare)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Customer customer, Customer otherCustomer)
        {
            return Customer.Equals(customer, otherCustomer);
        }

        public static bool operator !=(Customer customer, Customer otherCustomer)
        {
            return !Customer.Equals(customer, otherCustomer);
        }

        public override string ToString()
        {
            string paymentsString = "";
            foreach (Payment payment in payments)
	        {
		        paymentsString += payment;
	        }
            return "First name: " + this.firstName +
                "\nMiddle name: " + this.middleName +
                "\nLast name: " + this.lastName +
                "\nID: " + this.id +
                "\nAddress: " + this.permanentAddress +
                "\nPhone: " + this.phoneNumber +
                "\nEmail: " + this.email +
                "\nPayments: " + paymentsString +
                "\nCustomer type: " + this.customerType;
        }

        public object Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                return formatter.Deserialize(ms);
            }
        }

        public int CompareTo(Customer other)
        {
            if(this.fullName.CompareTo(other.fullName) == 0)
            {
                return this.id.CompareTo(other.id);
            }

            return this.fullName.CompareTo(other.fullName);
        }
    }
}

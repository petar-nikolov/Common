using System;
using System.Linq;

namespace CMS.BL
{
    public class Customer
    {
        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }

            //Sanity checking data, before assigning value to encapsulated field:
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _customerName = value;
            }
        }

        private string _customerEmail;

        public string CustomerEmail
        {
            get => _customerEmail;
            set
            {
                if (value.Contains('@'))
                {
                    _customerEmail = value;
                }
                else
                {
                    throw new FormatException("You have entered not valid email address");
                }
            }
        }

        public bool Validate()
        {
            return _customerEmail != null || _customerName != null;
        }
    }
}
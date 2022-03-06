using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    public class Customer
    {
        #region 
        private string _name;
        private string _phoneNumber;
        private string _mail;
        private string _adress;
        private int _streetNumber;
        private int _postalNumber;
        private string _town;
        #endregion

        #region 
        public Customer(string name, string phoneNumber, string mail, string adress, int streetNumber, int postalNumber, string town)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _mail = mail;
            _adress = adress;
            _streetNumber = streetNumber;
            _postalNumber = postalNumber;
            _town = town;
        }
        #endregion

        #region 
        public string Name
        {
            get { return _name; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string Mail
        {
            get { return _mail; }
        }

        public string Adress
        {
            get { return _adress; }
        }

        public int StreetNumber
        {
            get { return _streetNumber; }
        }

        public int PostalNumber
        {
            get { return _postalNumber; }
        }

        public string Town
        {
            get { return _town; }
        }
        #endregion

        #region
        public static string FormatString()
        {
            return "{0, -15} {1, -25}";
        }
        public override string ToString()
        {
            return base.ToString() + "My Customers";
        }
        #endregion
    }
}

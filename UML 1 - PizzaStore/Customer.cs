using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    public class Customer
    {
        #region instance fields
        private string _name;
        private string _phoneNumber;
        private string _mail;
        private string _adress;
        private int _streetNumber;
        private int _postalNumber;
        #endregion

        #region constructor
        public Customer(string name, string phoneNumber, string mail, string adress, int streetNumber, int postalNumber)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _mail = mail;
            _adress = adress;
            _streetNumber = streetNumber;
            _postalNumber = postalNumber;
        }
        #endregion

        #region properties
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
        #endregion

        #region
        #endregion
    }
    //3 kunde objekter
}

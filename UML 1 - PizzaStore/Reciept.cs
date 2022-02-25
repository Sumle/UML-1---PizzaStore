using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    class Reciept
    {
        #region
        private DateTime _time;
        private DateTime _date;
        private double _price;
        #endregion

        #region
        public Reciept(DateTime time, DateTime date, double price)
        {
            _time = time;
            _date = date;
            _price = price;
        }
        #endregion

        #region
        public DateTime Time
        {
            get { return _time; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        public double Price
        {
            get { return _price; }
        }
        #endregion

        #region
        #endregion
    }
}

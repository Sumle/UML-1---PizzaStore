using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    public class Toppings
    {
        #region
        private string _nameOfEkstraTopping;
        private int _priceOfEkstraTopping;
        #endregion

        #region
        public Toppings(string nameOfEkstraTopping, int priceOfEkstraTopping)
        {
            _nameOfEkstraTopping = nameOfEkstraTopping;
            _priceOfEkstraTopping = priceOfEkstraTopping;
        }
        #endregion

        #region
        public string NameOfEkstraTopping
        {
            get { return _nameOfEkstraTopping; }
        }

        public int PriceOfEkstraTopping
        {
            get { return _priceOfEkstraTopping; }
        }
        #endregion

        #region
        #endregion
    }
}

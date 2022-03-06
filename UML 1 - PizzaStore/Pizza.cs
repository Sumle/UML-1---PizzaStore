using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    public class Pizza
    {
        #region 
        private string _nameOfPizza;
        private int _priceOfPizza;
        #endregion

        #region 
        public Pizza(string NameOfPizza, int priceOfPizza)
        {
            _nameOfPizza = NameOfPizza;
            _priceOfPizza = priceOfPizza;
        }
        #endregion

        #region 
        public string NameOfPizza
        {
            get { return _nameOfPizza; }
        }

        public int PriceOfPizza
        {
            get { return _priceOfPizza; }
        }
        #endregion

        #region 
        public override string ToString()
        {
            return base.ToString() + "My Pizzas";
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    public class Pizza
    {
        #region Instance fields 
        private string _nameOfPizza;
        private int _priceOfPizza;
        #endregion

        #region Constructor
        public Pizza()
        {
            _nameOfPizza = "";
            _priceOfPizza = 0;
        }
        #endregion

        #region Properties
        public string NameOfPizza
        {
            get { return _nameOfPizza; }
            set { _nameOfPizza = value; }
        }

        public int PriceOfPizza
        {
            get { return _priceOfPizza; }
            set { _priceOfPizza = value; }
        }
        #endregion

        #region Methods
        public static string ToString()
        {
            Pizza pizza1 = new Pizza();
            Console.WriteLine(pizza1);
            return $"Name: {pizza1} - Price: {Price}";
        }

        #endregion
    }
    //3 pizzaer
}
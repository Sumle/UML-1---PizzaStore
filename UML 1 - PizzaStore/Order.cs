using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    public class Order
    {
        #region
        private int _numberOfPizza;
        private double _taxPct;
        private double _deliveryCost;
        Pizza pizza;
        #endregion

        #region
        public Order()
        {
            _numberOfPizza = 0;
            _taxPct = 0.0;
            _deliveryCost = 0.0;
            pizza = new Pizza();
        }
        #endregion

        #region
        public int NumberOfPizza
        {
            get { return _numberOfPizza; }
            set { _numberOfPizza = value; }
        }

        public double TaxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }

        public double DeliveryCost
        {
            get { return _deliveryCost; }
            set { _deliveryCost = value; }
        }
        #endregion

        #region
        public double CalculateTotalPrice()
        {

        }

        public static string ToString()
        {
            return $"Number of pizzas bought is: {Pizza}, and the cost is: {TotalPrice} and that is including tax and deliverycost.";
        }
        #endregion
    }
    //en funktion kaldet CalculateTotalPrice
    //3 ordre objekter med forskellige pizzaer
}

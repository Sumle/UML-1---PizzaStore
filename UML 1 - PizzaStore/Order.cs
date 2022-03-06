using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___PizzaStore
{
    public class Order
    {
        #region
        private double _taxPct;
        private double _deliveryCost;
        private Customer _customer;
        private Pizza _pizza;
        private Toppings _toppings;
        #endregion

        #region
        public Order(Customer customer, Pizza pizza, Toppings toppings)
        {
            _taxPct = 0.10;
            _deliveryCost = 40;
            _customer = customer;
            _pizza = pizza;
            _toppings = toppings;
        }
        #endregion

        #region
        public double TaxPct
        {
            get
            {
                return _taxPct * 100;
            }
        }

        public double DeliveryCost
        {
            get { return _deliveryCost; }
        }

        #endregion

        #region
        public string FormatString()
        {
            return "{0, -15} {1, -24} {2, -25} {3, -50}";
        }
        public void Text()
        {
            Console.WriteLine($"{FormatString()}", "Full Name;", $"{_customer.Name}", $"{_pizza.NameOfPizza}", $"{_pizza.PriceOfPizza}kr");
            Console.WriteLine($"{FormatString()}", "Adress:", $"{_customer.Adress}", $"{_toppings.NameOfEkstraTopping}", $"{_toppings.PriceOfEkstraTopping}kr");
            Console.WriteLine($"{FormatString()}", "Email:", $"{_customer.Mail}", $" ", $" ");
            Console.WriteLine($"{FormatString()}", "Phonenumber:", $"{_customer.PhoneNumber}", $" ", $" ");
            Console.WriteLine($"{FormatString()}", "Town:", $"{_customer.Town}", $" ", $" ");
            Console.WriteLine($"{FormatString()}", "Housenumber:", $"{_customer.StreetNumber}", $" ", $" ");
            Console.WriteLine($"{FormatString()}", "Postalnumber:", $"{_customer.PostalNumber}", $" ", $" ");
            Console.WriteLine();
            Console.WriteLine("{0, 93}", $"Total (inkl. 40 kr delivery");
            Console.WriteLine("{0, 93}", $"and 10% tax):");
            Console.WriteLine("{0, 93}", $"{CalculateTotalPrice()}");
            Console.WriteLine("{0, 93}", "_____");
        }

        public override string ToString()
        {
            return base.ToString() + "My Orders";
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = (_pizza.PriceOfPizza + _toppings.PriceOfEkstraTopping + DeliveryCost) * (_taxPct + 1);
            return totalPrice;
        }

        public static string FormatAnotherString()
        {
            return "{0, -40} {1, -25} {2, -20}";
        }

        public void PrintOrderInfo()
        {
            Console.WriteLine($"{FormatAnotherString()}", "Info about Customer:", "Info about order:", "Price:");
            Text();
        }
        #endregion
    }
}

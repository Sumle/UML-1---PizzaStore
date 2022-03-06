using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UML_1___PizzaStore
{
    public class Store
    {
        #region
        private Order _o1;
        private Order _o2;
        private Order _o3;
        #endregion

        #region
        public Store(Order o1, Order o2, Order o3)
        {
            _o1 = o1;
            _o2 = o2;
            _o3 = o3;
        }
        #endregion

        #region
        public Order O1
        {
            get { return _o1; }
        }
        public Order O2
        {
            get { return _o2; }
        }
        public Order O3
        {
            get { return _o3; }
        }
        #endregion

        #region 
        public static void PrintLine()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Console.ResetColor();
        }

        public static void Start()
        {
            Customer c1 = new Customer("Kurt Hansen", "12345678", "kh@gmail.com", "Maglehøjen", 4, 4000, "Roskilde");
            Customer c2 = new Customer("Lotte Mortensen", "87654321", "lm@gmail.com", "Gormsvej", 18, 4000, "Roskilde");
            Customer c3 = new Customer("Henry Andersen", "13579246", "hm@gmail.com", "Maglekildevej", 59, 4000, "Roskilde");

            Pizza p1 = new Pizza("Magherita", 89);
            Pizza p2 = new Pizza("Hawaii", 89);
            Pizza p3 = new Pizza("Vegetarian", 89);

            Toppings t1 = new Toppings("- Exstra Chili", 5);
            Toppings t2 = new Toppings("- Exstra Cheese", 5);
            Toppings t3 = new Toppings("- Exstra Champignon", 10);

            Order order1 = new Order(c1, p1, t1);
            Order order2 = new Order(c2, p2, t2);
            Order order3 = new Order(c3, p3, t3);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                             " + "Welcome to Big Mammas Pizzaria" + "\n");
            Console.ResetColor();
            PrintLine();
            Console.WriteLine();
            order1.PrintOrderInfo();
            PrintLine();
            Console.WriteLine();
            order2.PrintOrderInfo();
            PrintLine();
            Console.WriteLine();
            order3.PrintOrderInfo();
            PrintLine();
        }

        public override string ToString()
        {
            return base.ToString() + "Big Mammas Pizzaria";
        }
        #endregion
    }
}

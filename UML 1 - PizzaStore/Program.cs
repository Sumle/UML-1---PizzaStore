using System;

namespace UML_1___PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to Big Mammas Pizza House!");
            Console.WriteLine($"Click 'Enter' to see the orders...");
            Console.ReadKey();
            Console.WriteLine();

            Pizza pizza1 = new Pizza();
            Pizza pizza2 = new Pizza();
            Pizza pizza3 = new Pizza();

            Customer customer1 = new Customer("Kurt Hansen", "12345678", "kh@gmail.com", "Marglevej", 2, 4000);
            Customer customer2 = new Customer("Lotte Mortensen", "87654321", "lm@gmail.com", "Lorensensvej", 19, 4060);
            Customer customer3 = new Customer("Henry Andersen", "13579246", "ha@gmail.com", "Hedegårdsvej", 25, 4000);

            Toppings topping1 = new Toppings("Ost", 5);
            Toppings topping2 = new Toppings("Chili", 5);
            Toppings topping3 = new Toppings("Champignon", 7);

            Order order1 = new Order(1,pizza1,customer1, topping1);
            Order order2 = new Order(1, pizza2, customer2, topping2);
            Order order3 = new Order(1, pizza3, customer3, topping3);
        }
        //skal bruge ToString på alle klasser
    }
}

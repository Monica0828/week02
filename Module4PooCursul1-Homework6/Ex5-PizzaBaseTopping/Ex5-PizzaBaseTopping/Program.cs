using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PizzaBaseTopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaBase1 = new PizzaBase(BaseType.Regular, 8.5);
            var pizzaBase2 = new PizzaBase(BaseType.Italian, pizzaBase1.Cost * 1.5);
            var pizzaBase3 = new PizzaBase(BaseType.Thick, 10);

            var listOfPizza = new List<Pizza>();

            var listOfToppings1 = new List<PizzaTopping>();
            listOfToppings1.Add(new PizzaTopping(new Topping() { Type = ToppingType.Meat, Name = ToppingName.Salami }, 3));
            listOfToppings1.Add(new PizzaTopping(new Topping() { Type = ToppingType.Cheese, Name = ToppingName.BuffaloMozarella }, 6));
            listOfToppings1.Add(new PizzaTopping(new Topping() { Type = ToppingType.Vegetables, Name = ToppingName.Mushrooms }, 4));
            listOfPizza.Add(new Pizza("Quatro Formaggi", pizzaBase1, listOfToppings1));

            var listOfToppings2 = new List<PizzaTopping>();
            listOfToppings2.Add(new PizzaTopping(new Topping() { Type = ToppingType.Meat, Name = ToppingName.Chicken }, 4.3));
            listOfToppings2.Add(new PizzaTopping(new Topping() { Type = ToppingType.Meat, Name = ToppingName.Prosciutto }, 8.8));
            listOfToppings2.Add(new PizzaTopping(new Topping() { Type = ToppingType.Vegetables, Name = ToppingName.Pepper }, 5.5));
            listOfPizza.Add(new Pizza("Mamma Mia", pizzaBase2, listOfToppings2));

            var listOfToppings3 = new List<PizzaTopping>();
            listOfToppings3.Add(new PizzaTopping(new Topping() { Type = ToppingType.Meat, Name = ToppingName.Tuna }, 11));
            listOfToppings3.Add(new PizzaTopping(new Topping() { Type = ToppingType.Vegetables, Name = ToppingName.Mushrooms }, 4));
            listOfToppings3.Add(new PizzaTopping(new Topping() { Type = ToppingType.Vegetables, Name = ToppingName.Pepper }, 5.5));
            listOfPizza.Add(new Pizza("Dopo Poco", pizzaBase3, listOfToppings3));

            foreach (var elem in listOfPizza)
            {
                Console.WriteLine(elem.Print());
                Console.WriteLine($"Base: {elem.Base.Print()}");
                Console.WriteLine("Toppings: ");
                foreach (var top in elem.ListOfToppings)
                {
                    Console.WriteLine(top.Print().PadLeft(15));
                }

                Console.WriteLine(elem.CalculateTotalCost());
            }

            Console.ReadKey();
        }
    }
}

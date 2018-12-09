using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PizzaBaseTopping
{
    class Pizza
    {
        public Pizza(string name, PizzaBase pizzaBase, List<PizzaTopping> listOfToppings)
        {
            Name = name;
            Base = pizzaBase;
            ListOfToppings = listOfToppings;
        }

        public string Name { get; set; }

        public PizzaBase Base { get; set; }

        public List<PizzaTopping> ListOfToppings { get; set; }

        public double Cost { get; set; }

        public void AddTopping(PizzaTopping pizzaTopping)
        {
            ListOfToppings.Add(pizzaTopping);
        }

        public string CalculateTotalCost()
        {
            double costs = Base.Cost;
            foreach (var elem in ListOfToppings)
            {
                costs = costs + elem.Cost;
            }
            return $"Total cost: ${costs}";
        }

        public string Print()
        {
            return $"Pizza {Name}";

        }
    }
}

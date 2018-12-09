using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PizzaBaseTopping
{
    class PizzaTopping
    {
        public PizzaTopping(Topping toppingType, double cost)
        {
            Topping = toppingType;
            Cost = cost;
        }
        public Topping Topping { get; set; }
        public double Cost { get; set; }

        public string Print()
        {
            var nameToPrint = Topping.Type == ToppingType.Meat ? Topping.Name.ToUpper() : Topping.Name;
            var message = $"{nameToPrint} (${Cost})";

            return message.PadLeft(message.Length + 5);
        }
    }
    public enum ToppingType
    {
        Cheese,
        Meat,
        Vegetables
    }

    public static class ToppingName
    {
        public const string Salami = "Salami";
        public const string Prosciutto = "Prosciutto";
        public const string Chicken = "Chicken";
        public const string Tuna = "Tuna";


        public const string Parmigiano = "Parmigiano";
        public const string BuffaloMozarella = "Buffalo mozarella";
        public const string Gorgonzola = "Gorgonzola";



        public const string Pepper = "Pepper";
        public const string Jalapeno = "Jalapeno";
        public const string Mushrooms = "Mushrooms";



    }

    public class Topping
    {
        public ToppingType Type { get; set; }

        public string Name { get; set; }
    }

}

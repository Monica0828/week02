using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PizzaBaseTopping
{
    class PizzaBase
    {
        public PizzaBase(BaseType baseType, double cost)
        {
            Name = baseType;
            Cost = cost;
        }

        public BaseType Name { get; set; }

        public double Cost { get; set; }

        public string Print()
        {
            return $"{ Name} (${ Cost})";
        }

    }
    enum BaseType
    {
        Regular,
        Thick,
        Italian
    }

}

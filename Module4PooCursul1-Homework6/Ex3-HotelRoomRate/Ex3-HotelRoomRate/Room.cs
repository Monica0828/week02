using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomRate
{
    class Room
    {
        public Room(string name, Rate dailyRate, int adults, int children)
        {
            Name = name;
            DailyRate = dailyRate;
            Adults = adults;
            Children = children;
        }
        public string Name { get; set; }

        public Rate DailyRate{ get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public decimal GetPriceForDays(int numberOfDays)
        {
            return numberOfDays * DailyRate.Amount;
        }

        public string Print()
        {
            return $"Name of the room is {Name}, has the price of {DailyRate.Amount} {DailyRate.Currency}. Can have {Adults} adults and {Children} children.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomRate
{
    class Rate
    {
        public Rate(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;

        }
        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string Print()
        {
            return $"Amount is {Amount} and currency is: {Currency}.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomRate
{
    class Hotel
    {
        public Hotel(string name, string city, int stars, List<Room> listOfRooms)
        {
            Name = name;
            City = city;
            Stars = stars;
            ListOfRooms = listOfRooms;
        }
        public string Name { get; set; }

        public string City { get; set; }

        public int Stars { get; set; }

        public List<Room> ListOfRooms { get; set; }

        public decimal GetPriceForNumberOfRooms(Room room,int numberOfRooms)
        {
            return numberOfRooms * room.DailyRate.Amount;   
        }

        public string Print()
        {
            return $"Hotel name is {Name}, is in city {City} and has {Stars} stars.";
        }

    }
}

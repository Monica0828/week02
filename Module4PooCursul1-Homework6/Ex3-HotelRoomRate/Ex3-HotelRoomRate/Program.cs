using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomRate
{
    class Program
    {
        static void Main(string[] args)
        {

            var rate1 = new Rate(200, "Euro");
            var rate2 = new Rate(50, "Euro");
            var rate3 = new Rate(20, "Euro");

            var room1 = new Room("Manhatten", rate1, 2,0);
            var room2 = new Room("Brooklyn", rate2, 4, 0);
            var room3 = new Room("Queens", rate3, 2, 2);

            var listOfRooms = new List<Room>();
            listOfRooms.Add(room1);
            listOfRooms.Add(room2);
            listOfRooms.Add(room3);

            var hotel = new Hotel("Hilton", "New York", 5,listOfRooms);

            Console.WriteLine("Add a hotel - 1");
            Console.WriteLine("Delete a hotel - 2");
            Console.WriteLine("Find a room with price smaller that - 3");
            Console.WriteLine("Please select an option from above");
            var value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    var hotel2 = new Hotel("Marriott", "Philadelphia", 4, listOfRooms);
                    Console.WriteLine($"A new hotel was added. {hotel2.Name} was inserted");
                    break;
                case 2:

                    break;
                case 3:
                    Console.WriteLine("Please insert the price for room");
                    var valueForRoom = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Rooms with Daily rate amount smaller than {valueForRoom}");
                    var find = false;
                    foreach (var elem in listOfRooms)
                    {
                        if (elem.DailyRate.Amount < valueForRoom)
                        {
                            Console.WriteLine(elem.Name);
                            find = true;
                        }
                    }
                    if(find==false)
                    {
                        Console.WriteLine($"There was no rooms with price smaller than {valueForRoom}");
                    }

                    break;

                default:
                    break;
            }
            

            Console.ReadKey();
        }
    }
}

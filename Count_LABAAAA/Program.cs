using Count_LABAAAA;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Count_LABAAAA
{
    public class Program
    {
        static void Main()
        {
            Roll roll = new Roll(4, 5, 10);
            Room room = new Room(5, 5, 5, new Window(2, 2));

            Console.WriteLine("Полная площадь комнаты "+room.FullArea(room)); 
            Console.WriteLine("Кол-во рулонов для обклеивания "+room.CountOfRolls(roll,room));
            Console.WriteLine("Кол-во рублей за рулоны "+room.FullPrice(roll,room));
            Console.ReadLine();
        }
    }
}


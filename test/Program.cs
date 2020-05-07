using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Domain;
using WindowsFormsApp1.Model;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new HotelWinFormsDbContext())
            {
                var database = db.Rooms;
                List<Room> rooms = new List<Room>();
                foreach (var item in database)
                {
                    rooms.Add(item);
                }
                string s= "1 a";
                s=s.Trim(' ');
                string price = (from p in rooms where p.RoomNumber.ToLower().Replace(" ",string.Empty) == "1  a ".ToLower().Replace(" ", string.Empty) select p.PricePerWeek).FirstOrDefault().ToString();
               
                Console.WriteLine(price);
               
                Console.ReadKey();

            }
        }
    }
}

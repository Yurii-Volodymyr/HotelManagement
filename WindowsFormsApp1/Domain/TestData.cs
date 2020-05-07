//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WindowsFormsApp1.Model;

//namespace WindowsFormsApp1.Domain
//{
//    public class TestData
//    {
//        public static List<Order> GetOrders()
//        {
//            List<Order> orders = new List<Order>() {
//                new Order()
//                {
//                    Email="adws@com.com",
//                    Gender="Male",
//                    Passport ="AC58793",
//                    Phone =12498719,
//                    OrderId =3,
//                    TotalCosting =250,
//                    UserName ="User Name",
//                    BirthDay= new DateTime(2000,5,10),
//                    DepartureDate= new DateTime(2020, 4, 3, 0, 0, 0, 0),
//                    EntryDate=new DateTime(2020,4,5)
//                },
//                new Order()
//                {
//                    Email="ghjgh@com.com",
//                    Gender="Female",
//                    Passport ="BK34646",
//                    Phone =3752413,
//                    OrderId =4,
//                    TotalCosting =250,
//                    UserName ="User Name",
//                    BirthDay= new DateTime(2000,5,10),
//                    DepartureDate= new DateTime(2020, 4, 3, 0, 0, 0, 0),
//                    EntryDate=new DateTime(2020,4,5)
//                }
//            };
//            return orders;
//        }
//        public static List<User> GetUsers()
//        {
//            UserRoles userRoles = new UserRoles();
//            List<User> users = new List<User>()
//            {
//                new User()
//                {
//                    Login="1",
//                    Password="1",
//                    UserRole=0,
//                },
//                new User()
//                {
//                    Login="2",
//                    Password="2",
//                    UserRole=1,

//                },
//                 new User()
//                {
//                    Login="3",
//                    Password="3",
//                    UserRole=3,

//                }
//            };
//            return users;
//        }
//    }
//}

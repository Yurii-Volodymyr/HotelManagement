using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{/// <summary>
/// klasa reprezentująca zamawianie pokoju
/// </summary>
    public class Order
    {
        [Key, ForeignKey("UserOrder")]
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [Display(Name ="Client full name")]
        public string ClientName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public int Phone{ get; set; }
        public string Gender{ get; set; }
        public string Passport{ get; set; }
        [Display(Name = "Entry Date")]
        public DateTime EntryDate{ get; set; }
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate{ get; set; }
        public string RoomNumber { get; set; }
        public double TotalCosting { get; set; }
      public User UserOrder { get; set; }
    }
}

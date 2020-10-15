using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Model
{
    public class ServFoodOrder
    {
        public int ServFoodOrderId { get; set; }
        public string Burger { get; set; }
        public string Cake { get; set; }
        public string Pizza { get; set; }
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room Room{ get; set; }
    }
}

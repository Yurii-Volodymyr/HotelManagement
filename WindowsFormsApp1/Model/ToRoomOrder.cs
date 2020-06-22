using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class ToRoomOrder
    {
        public int ToRoomOrderId { get; set; }
        public string Burger { get; set; }
        public string Cake { get; set; }
        public string Pizza { get; set; }
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual ICollection<Room> Rooms{ get; set; }
    }
}

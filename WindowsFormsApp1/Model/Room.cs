using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Room
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string Description{ get; set; }
        public string RoomImage { get; set; }
        public double PricePerWeek{ get; set; }
    }
}

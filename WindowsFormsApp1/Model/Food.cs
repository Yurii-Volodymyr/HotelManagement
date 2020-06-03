using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodName{ get; set; }
        public double Price{ get; set; }
        public string Photo{ get; set; }
        [ScaffoldColumn(false)]
        [NotMapped]
        public Image Image
        {
            get
            {
                if (!string.IsNullOrEmpty(Photo))
                {
                    return Image.FromFile(Photo);
                }
                return null;
            }
        }
        public Room RoomFood { get; set; }
    }
}

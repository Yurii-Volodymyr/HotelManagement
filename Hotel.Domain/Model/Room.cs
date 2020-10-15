using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Domain.Model
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("UserRoom")]
        public int RoomId { get; set; }
        [ScaffoldColumn(false)]
        [NotMapped]
        public RoomTypes roomTypes { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public string Description { get; set; }
        public string RoomImage { get; set; }
        //[ScaffoldColumn(false)]
        //[NotMapped]
        //public Image image
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(RoomImage))
        //        {

        //            return Image.FromFile(RoomImage);
        //        }
        //        return null;
        //    }
        //}
        public double PricePerWeek { get; set; }
        public string IsAvailable { get; set; }
        //public int? UserRoomId{ get; set; }
        //public int? FoodRoomId { get; set; }
        //public int RoomOrderId { get; set; }

        //[ForeignKey("UserRoomId")]
        public virtual User UserRoom { get; set; }

        public virtual ICollection<ServFoodOrder> FoodOrder { get; set; }
        public virtual ICollection<ServRoomOrder> RoomOrder { get; set; }
    }
    public enum RoomTypes
    {

        Single,
        Double,
        Triple,
        Quad,
        Queen,
        King,
        Twin,
        Double_Double,
        Studio
    }
}

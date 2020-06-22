﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [ScaffoldColumn(false)]
        [NotMapped]
        public RoomTypes roomTypes { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public string Description { get; set; }
        public string RoomImage { get; set; }
        [ScaffoldColumn(false)]
        [NotMapped]
        public Image image
        {
            get
            {
                if (!string.IsNullOrEmpty(RoomImage))
                {
                    return Image.FromFile(RoomImage);
                }
                return null;
            }
        }
        public double PricePerWeek { get; set; }
        public string IsAvailable { get; set; }
        public int UserRoomId{ get; set; }
        public int FoodRoomId { get; set; }
        public int RoomOrderId { get; set; }

        [ForeignKey("FoodRoomId")]
        public virtual Food FoodRoom { get; set; }
        [ForeignKey("UserRoomId")]
        public virtual User UserRoom { get; set; }
        [ForeignKey("RoomOrderId")]
        public virtual ServFoodOrder RoomOrder { get; set; }
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

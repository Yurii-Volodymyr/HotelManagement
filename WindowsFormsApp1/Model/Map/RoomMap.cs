using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Map
{
    public class RoomMap:EntityTypeConfiguration<Room>
    {
        public RoomMap()
        {
            this.HasKey(t=>t.RoomId);
            this.Property(t => t.Description);
            this.Property(t => t.IsAvailable);
            this.Property(t => t.PricePerWeek);
            this.Property(t => t.RoomImage);
            this.Property(t => t.RoomNumber);
            this.Property(t => t.RoomType);

            this.HasRequired<ToRoomOrder>(s => s.RoomOrder)
                        .WithMany(g => g.Rooms)
                        .HasForeignKey<int>(s => s.RoomOrderId);

            this.ToTable("Rooms","dbo");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsAvailable).HasColumnName("IsAvailable");
            this.Property(t => t.PricePerWeek).HasColumnName("PricePerWeek");
            this.Property(t => t.RoomImage).HasColumnName("RoomImage");
            this.Property(t => t.RoomNumber).HasColumnName("RoomNumber");
            this.Property(t => t.RoomType).HasColumnName("RoomType");
        }
    }
}

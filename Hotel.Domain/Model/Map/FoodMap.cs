using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Model.Map
{
    public class FoodMap:EntityTypeConfiguration<Food>
    {
        public FoodMap()
        {
            this.HasKey(t => t.FoodId);
            this.Property(t => t.FoodName);
            this.Property(t => t.PhotoPath);
            this.Property(t => t.Price);

            this.ToTable("Foods");
            this.Property(t => t.FoodId).HasColumnName("FoodId");
            this.Property(t => t.FoodName).HasColumnName("FoodName");
            this.Property(t => t.PhotoPath).HasColumnName("Photo");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}

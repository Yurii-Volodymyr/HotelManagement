using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Map
{
    public class FoodMap:EntityTypeConfiguration<Food>
    {
        public FoodMap()
        {
            this.HasKey(t => t.FoodId);
            this.Property(t => t.FoodName);
            this.Property(t => t.Photo);
            this.Property(t => t.Price);

            this.Property(t => t.FoodId).HasColumnName("FoodId");
            this.Property(t => t.FoodName).HasColumnName("FoodName");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}

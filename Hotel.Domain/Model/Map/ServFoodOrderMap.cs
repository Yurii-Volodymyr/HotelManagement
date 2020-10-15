using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Model.Map
{
   public class ServFoodOrderMap: EntityTypeConfiguration<ServFoodOrder>
    {
        public ServFoodOrderMap()
        {
            this.HasKey(t => t.ServFoodOrderId);
       
            this.ToTable("ServFoodOrder", "dbo");
        }
    }
}

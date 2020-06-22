using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Map
{
   public class ServRoomOrderMap: EntityTypeConfiguration<ServFoodOrder>
    {
        public ServRoomOrderMap()
        {
            this.HasKey(t => t.ServFoodOrderId);
       
            this.ToTable("RoomOrder", "dbo");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Map
{
   public class ToRoomOrderMap: EntityTypeConfiguration<ToRoomOrder>
    {
        public ToRoomOrderMap()
        {
            this.HasKey(t => t.ToRoomOrderId);
       
            this.ToTable("ToRoomOrder","dbo");
        }
    }
}

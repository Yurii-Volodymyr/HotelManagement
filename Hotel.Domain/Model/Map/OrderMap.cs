using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Model.Map
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(t => t.OrderId);
            this.Property(t => t.BirthDay);
            this.Property(t => t.ClientName);
            this.Property(t => t.DepartureDate);
            this.Property(t => t.Email);
            this.Property(t => t.EntryDate);
            this.Property(t => t.Gender);
            this.Property(t => t.Passport);
            this.Property(t => t.Phone);
            this.Property(t => t.RoomNumber);
            this.Property(t => t.TotalCosting);

            //this.HasRequired(s => s.UserOrder)
            //    .WithRequiredPrincipal(g => g.OrderUser);

            this.ToTable("Orders", "dbo");
            this.Property(t => t.OrderId).HasColumnName("OrderId"); 
            this.Property(t => t.BirthDay).HasColumnName("BirthDay");
            this.Property(t => t.ClientName).HasColumnName("ClientName");
            this.Property(t => t.DepartureDate).HasColumnName("DepartureDate");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.EntryDate).HasColumnName("EntryDate");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Passport).HasColumnName("Passport");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.RoomNumber).HasColumnName("RoomNumber");
            this.Property(t => t.TotalCosting).HasColumnName("TotalCosting");
        }
    }
}

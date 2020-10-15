using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Model.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(t => t.UserId);
            this.Property(t => t.Login).IsRequired();
            this.Property(t => t.Password).IsRequired();
            this.Property(t => t.UserRoleId).IsRequired();

            this.HasOptional<Order>(s => s.OrderUser)
                .WithOptionalDependent(ou => ou.UserOrder);
            this.HasRequired<UserRole>(s => s.UserRole)
                .WithMany(g => g.Users)
                .HasForeignKey<int>(s => s.UserRoleId);
            this.HasOptional<Room>(s => s.RoomUser).WithOptionalDependent(ou => ou.UserRoom);

            this.ToTable("Users", "dbo");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleId");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Map
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            this.HasKey(t => t.UserRoleId);
            this.Property(t => t.UserRoleName).IsRequired();

            this.HasMany(g => g.Users)
                .WithRequired(s => s.UserRole)
                .HasForeignKey<int>(s=>s.UserRoleId);

            this.ToTable("UserRoles", "dbo");
            this.Property(x=>x.UserRoleId).HasColumnName("UserRoleId");
            this.Property(x=>x.UserRoleName).HasColumnName("UserRoleName");
        }
    }
}

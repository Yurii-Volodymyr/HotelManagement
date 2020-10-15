using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Login{ get; set; }
        public string Password{ get; set; }
        /// <summary>
        /// UserRole is a foreign key to UserRoles. Relation many(users)-to-one(role)
        /// </summary>
        public int UserRoleId { get; set; }
        public virtual UserRole UserRole { get; set; }

        public virtual Order OrderUser { get; set; }
        public virtual Room RoomUser { get; set; }

    }
}

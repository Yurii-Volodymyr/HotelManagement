using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        public int UserId { get; set; }
        public string Login{ get; set; }
        public string Password{ get; set; }
        /// <summary>
        /// UserRole is a foreign key to UserRoles. Relation many(users)-to-one(role)
        /// </summary>
        public int UserRole { get; set; }
        public UserRoles Roles { get; set; }

    }
}

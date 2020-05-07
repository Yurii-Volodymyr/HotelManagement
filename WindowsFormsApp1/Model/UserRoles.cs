using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class UserRoles
    {
        [Key]
        public int UserRolesId { get; set; }
        public string UserRole { get; set; }
        public List<User>Users { get; set; }
        
        

    }
   
}

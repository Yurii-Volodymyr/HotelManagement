﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Model
{
    public class UserRole
    {
        public UserRole()
        {
            this.Users = new HashSet<User>();
        }
        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }

}

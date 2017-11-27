using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserRoleExample.Models
{
    public class UserRoleViewModel
    {
        [HiddenInput]
        public string UserId { get; set; }
        //public string UserName { get; set; }
        //public string RoleId { get; set; }
        [HiddenInput]
        public string RoleName { get; internal set; }
    }
}

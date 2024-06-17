using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public int? Age { get; set; }
    }
}

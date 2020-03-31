using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Models
{
    public class AppUser : IdentityUser
    {
        // 1-* AppUser || Massage
        public AppUser()
        {
            Massages = new HashSet<Massage>();
        }

        public virtual ICollection<Massage> Massages { get; set; }
    }
    
}

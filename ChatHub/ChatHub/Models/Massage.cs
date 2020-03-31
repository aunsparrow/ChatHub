using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHub.Models
{
    public class Massage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get;  set; }
        public string UserMassage { get; set; }
        public DateTime TransactionTime { get; set; }

        public virtual AppUser AppUser { get; set; }

    }
}

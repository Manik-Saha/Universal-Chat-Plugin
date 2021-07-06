using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universal_Chat_Plugin.Models
{
    public class Organization
    {
        public Organization()
        {
            Payments = new HashSet<Payment>();
        }
        public int Id { get; set; }
        //navigation property
        public ICollection<Payment> Payments { get; set; }
    }
}
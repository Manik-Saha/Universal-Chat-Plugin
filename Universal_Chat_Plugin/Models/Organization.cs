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
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        //navigation property
        public ICollection<Payment> Payments { get; set; }
    }
}
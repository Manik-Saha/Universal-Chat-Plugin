using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Website is not valid.")]
        public string Website { get; set; }
        //navigation property
        public ICollection<Payment> Payments { get; set; }
    }
}
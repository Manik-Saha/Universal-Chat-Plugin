using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Universal_Chat_Plugin.Models
{
    public class User
    {
        public User()
        {
            Payments = new HashSet<Payment>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Universal_Chat_Plugin.Models
{
    public class UniversalChatPluginEntities : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }
}
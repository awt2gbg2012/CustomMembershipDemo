using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MembershipDemo.Models.Entities;

namespace MembershipDemo.Models.Contexts
{
    public class EFDbContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
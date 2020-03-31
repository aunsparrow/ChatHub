using System;
using System.Collections.Generic;
using System.Text;
using ChatHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatHub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Massage>()
                .HasOne<AppUser>(a => a.AppUser)
                .WithMany(d => d.Massages)
                .HasForeignKey(d => d.UserId);

        }
    }
}

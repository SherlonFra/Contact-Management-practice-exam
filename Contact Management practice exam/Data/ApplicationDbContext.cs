using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Contact_Management_practice_exam.Models;

namespace Contact_Management_practice_exam.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

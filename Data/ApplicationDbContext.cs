using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GeorgianFurniture.Models;

namespace GeorgianFurniture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GeorgianFurniture.Models.Category> Category { get; set; }
        public DbSet<GeorgianFurniture.Models.Store> Store { get; set; }
        public DbSet<GeorgianFurniture.Models.Furniture> Furniture { get; set; }
    }
}

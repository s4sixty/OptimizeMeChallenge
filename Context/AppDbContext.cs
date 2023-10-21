﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OptimizeMePlease.Entities;
using System;

namespace OptimizeMePlease.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-BS20MFF\\SQLEXPRESS;Database=OptimizeMePlease;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
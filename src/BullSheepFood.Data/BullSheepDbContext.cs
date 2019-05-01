﻿using BullSheepFood.Models;
using Microsoft.EntityFrameworkCore;

namespace BullSheepFood.Data
{
    public sealed class BullSheepDbContext : DbContext
    {
        public BullSheepDbContext(DbContextOptions<BullSheepDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
    }
}

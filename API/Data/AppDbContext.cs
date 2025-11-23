using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    //table name Users for entity AppUser
    public DbSet<AppUser> Users { get; set; }
}

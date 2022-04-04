#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab1DataAnnotations.Models;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Room> Rooms { get; set; }
}


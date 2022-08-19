using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagement.Models
{
    public class FurnitureDbContext:DbContext
    {
        public FurnitureDbContext(DbContextOptions<FurnitureDbContext> options) : base(options)
        {


        }
        public DbSet<Furniture> Furniture { get; set; }
    }
}

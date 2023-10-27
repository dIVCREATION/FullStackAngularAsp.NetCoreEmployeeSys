using FullStackApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackApi.Data


{
    public class FullStackDbContext :DbContext

    {
        public FullStackDbContext(DbContextOptions options): base (options)
        {

        }
         public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}

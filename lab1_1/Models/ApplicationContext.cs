using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace lab1_1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Sklad> Sklad { get; set; }
        public DbSet<Tovar> Tovars { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}

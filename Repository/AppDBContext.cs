using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels;
using DomainModels.EF_Models;

namespace Repository
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(
           new UserEntity { Id = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"), Name = "Mirna", UserName = "Mirna", Email = "Mirna@mail.com", PhoneNumber = "01000000", CreatedAt = DateTime.Now },
           new UserEntity { Id = new Guid("12223344-2566-7788-99AA-BBCCDDEEFF00"), Name = "Sam", UserName = "Sam", Email = "sam@mail.com", PhoneNumber = "01000000", CreatedAt = DateTime.Now },
           new UserEntity { Id = new Guid("13223344-3566-7788-99AA-BBCCDDEEFF00"), Name = "John", UserName = "John", Email = "John@mail.com", PhoneNumber = "01000000", CreatedAt = DateTime.Now }
       );


        }
    }
}

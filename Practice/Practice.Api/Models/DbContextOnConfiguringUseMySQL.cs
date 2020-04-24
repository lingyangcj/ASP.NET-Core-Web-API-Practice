using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Api.Models
{
    public class DbContextOnConfiguringUseMySQL : DbContext
    {
        public virtual DbSet<Person> Person { get; set; } //创建实体类添加Context中
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=123456");
            }
           
        }
    }
}

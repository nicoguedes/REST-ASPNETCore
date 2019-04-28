using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSkeleton.Model
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() {  }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options){}

        public DbSet<Person> Persons { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using RestSkeleton.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESTApi
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() {  }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options){}

        public DbSet<Person> Persons { get; set; }
    }
}

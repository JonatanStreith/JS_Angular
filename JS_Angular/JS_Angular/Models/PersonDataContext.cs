using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JS_Angular.Models
{
    public class PersonDataContext : DbContext
    {

        public DbSet<Person> People { get; set; }

    }
}
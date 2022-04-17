using MySql.Data.EntityFramework;
using PizzaOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaOrderingSystem.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PizzaDbContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }

        public PizzaDbContext() : base("dbConn")
        {

        }
    }
}
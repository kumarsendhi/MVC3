using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using AccountAtAGlance.Model;

namespace AccountAtGlance.Repository
{
    public class AccountAtGlance : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}

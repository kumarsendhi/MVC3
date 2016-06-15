using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MusicStore.Models
{
    public class MusicStoreDataContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
    }
}
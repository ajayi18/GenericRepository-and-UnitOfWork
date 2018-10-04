using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFContext")
        { }
        public DbSet<User> Users { get; set; }
    }
}

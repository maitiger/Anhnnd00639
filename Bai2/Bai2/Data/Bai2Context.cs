using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bai2.Models
{
    public class Bai2Context : DbContext
    {
        public Bai2Context (DbContextOptions<Bai2Context> options)
            : base(options)
        {
        }

        public DbSet<Bai2.Models.User> User { get; set; }
    }
}

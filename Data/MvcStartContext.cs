using Microsoft.EntityFrameworkCore;
using MvcStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStart.Data {
    public class MvcStartContext : DbContext {
        public MvcStartContext(DbContextOptions<MvcStartContext> options) : base(options) {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Board> Board { get; set; }
    }
}

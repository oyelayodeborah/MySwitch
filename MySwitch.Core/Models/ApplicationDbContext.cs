using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }


        public DbSet<Channel> Channels { get; set; }
        public DbSet<SinkNode> SinkNodes { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<SourceNode> SourceNodes { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Scheme> Schemes { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Route> Routes { get; set; }


    }
}

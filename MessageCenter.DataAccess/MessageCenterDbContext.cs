using JetBrains.Annotations;
using MessageCenter.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace MessageCenter.DataAccess
{
    public class MessageCenterDbContext : DbContext
    {
        public MessageCenterDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MessageCenterDbContext()
        {
        }

        public DbSet<EndPoint> EndPoints { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
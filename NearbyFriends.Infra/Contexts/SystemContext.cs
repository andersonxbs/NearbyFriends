using Microsoft.EntityFrameworkCore;
using NearbyFriends.Domain.Entities;

namespace NearbyFriends.Infra.Contexts
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Friend> Friends { get; set; }
    }
}

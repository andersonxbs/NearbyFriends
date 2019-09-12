using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NearbyFriends.Domain.Entities;

namespace NearbyFriends.Infra.Contexts
{
    public class SystemContext : IdentityDbContext
    {
        public SystemContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Friend> Friends { get; set; }
    }
}

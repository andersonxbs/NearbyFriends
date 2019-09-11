using Microsoft.EntityFrameworkCore;
using NearbyFriends.Domain.Contracts;
using NearbyFriends.Domain.Entities;
using NearbyFriends.Infra.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NearbyFriends.Infra.Repositories
{
    public class FriendRepository : IFriendRepository
    {
        private SystemContext _context;

        public FriendRepository(SystemContext context)
        {
            _context = context;
        }

        public async Task<Friend> CreateAsync(Friend entity)
        {
            return (await _context.Friends.AddAsync(entity)).Entity;
        }

        public async Task<IEnumerable<Friend>> GetAllAsync()
        {
            return await _context.Friends.ToListAsync();
        }

        public async Task<Friend> GetByCoordinatesAsync(int latitude, int longitude)
        {
            return await _context.Friends
                .FirstOrDefaultAsync(d => 
                    d.Latitude.Equals(latitude) &&
                    d.Longitude.Equals(longitude));
        }
    }
}

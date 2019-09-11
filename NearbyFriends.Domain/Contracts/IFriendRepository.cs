using NearbyFriends.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NearbyFriends.Domain.Contracts
{
    public interface IFriendRepository
    {
        Task<Friend> GetByCoordinatesAsync(int latitude, int longitude);
        Task<IEnumerable<Friend>> GetAllAsync();
        Task<Friend> CreateAsync(Friend entity);
    }
}

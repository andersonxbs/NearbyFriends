using System.Threading.Tasks;
using NearbyFriends.Domain.Contracts;
using NearbyFriends.Infra.Contexts;
using NearbyFriends.Infra.Repositories;

namespace NearbyFriends.Infra
{
    public class UnityOfWork : IUnityOfWork
    {
        private SystemContext _context;

        public UnityOfWork(
            SystemContext context)
        {
            _context = context;
        }

        private IFriendRepository _friendsRepository;

        public IFriendRepository Friends
        {
            get
            {
                if (_friendsRepository == null)
                    _friendsRepository = new FriendRepository(_context);

                return _friendsRepository;
            }
        }

        public async Task CommitChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

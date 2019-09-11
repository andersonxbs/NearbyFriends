using System.Threading.Tasks;

namespace NearbyFriends.Domain.Contracts
{
    public interface IUnityOfWork
    {
        Task CommitChangesAsync();

        IFriendRepository Friends { get; }
    }
}

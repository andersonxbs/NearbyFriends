using NearbyFriends.Domain.Entities.Abstractions;

namespace NearbyFriends.Domain.Entities
{
    public class Friend : EntityBase<int>
    {
        public string Name { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }
    }
}

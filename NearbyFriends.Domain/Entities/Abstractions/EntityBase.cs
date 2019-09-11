using System;

namespace NearbyFriends.Domain.Entities.Abstractions
{
    public abstract class EntityBase<TId>
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

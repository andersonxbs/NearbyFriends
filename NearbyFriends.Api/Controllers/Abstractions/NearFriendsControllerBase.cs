using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NearbyFriends.Api.Helpers.Filters;

namespace NearbyFriends.Api.Controllers.Abstractions
{
    [InjectCurrentUser]
    public abstract class NearFriendsControllerBase : ControllerBase
    {
        public IdentityUser CurrentUser { get; set; }
    }
}
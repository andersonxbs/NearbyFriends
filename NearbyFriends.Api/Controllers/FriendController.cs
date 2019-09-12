using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NearbyFriends.Api.Controllers.Abstractions;
using NearbyFriends.Domain.Contracts;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NearbyFriends.Api.Controllers
{
    [Authorize]
    [Route("api/friend")]
    public class FriendController : NearFriendsControllerBase
    {
        public FriendController(
            IUnityOfWork unityOfwork)
        {
            _repositories = unityOfwork;
        }

        private IUnityOfWork _repositories { get; set; }
            
        [HttpGet("")]
        public async Task<ActionResult> GetFriends()
        {
            var userId = CurrentUser;

            return Ok();
        }
    }
}
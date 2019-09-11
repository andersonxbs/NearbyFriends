using Microsoft.AspNetCore.Mvc;
using NearbyFriends.Domain.Contracts;

namespace NearbyFriends.Api.Controllers
{
    public class FriendController : Controller
    {
        public FriendController(
            IUnityOfWork unityOfwork)
        {
            _repositories = unityOfwork;
        }

        private IUnityOfWork _repositories { get; set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NearbyFriends.Api.Controllers.Abstractions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NearbyFriends.Api.Helpers.Filters
{
    public class InjectCurrentUserAttribute : TypeFilterAttribute
    {
        public InjectCurrentUserAttribute()
            : base(typeof(InjectCurrentUserImp))
        {
            
        }

        private class InjectCurrentUserImp : ActionFilterAttribute
        {
            private readonly UserManager<IdentityUser> _userManager;

            public InjectCurrentUserImp(
                UserManager<IdentityUser> userManager)
            {
                _userManager = userManager;
            }

            public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                var userId = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var user = await _userManager.FindByIdAsync(userId);

                if (context.Controller is NearFriendsControllerBase controller)
                    controller.CurrentUser = user;

                await next();
            }
        }
    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace PhotosExpressMVP
{
    [Route("/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //[HttpGet("microsoft")]
        [HttpGet("oidc")]
        public async Task Login(string RedirectUri)
        {
            var props = new AuthenticationProperties
            {
                RedirectUri = RedirectUri
            };

            //return Challenge(props, MicrosoftAccountDefaults.AuthenticationScheme);
            await HttpContext.ChallengeAsync("oidc", props);
        }

        [HttpGet("logout")]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}

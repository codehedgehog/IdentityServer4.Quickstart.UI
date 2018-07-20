
namespace IdentityServer4.QuickstartUI.Api.Controllers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;
	using System.Linq;


	[Route("identity")]
	[ApiController]
	[Authorize]
	public class IdentityController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
		}
	}

}
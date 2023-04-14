using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountUsersController : ControllerBase
	{
		private IAccountUserService _accountUserService;

		public AccountUsersController(IAccountUserService accountUserService)
		{
			_accountUserService = accountUserService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _accountUserService.GetList();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("add")]
		public IActionResult Add(AccountUser accountUser)
		{
			var result = _accountUserService.Add(accountUser);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("delete")]
		public IActionResult Delete(AccountUser accountUser)
		{
			var result = _accountUserService.Delete(accountUser);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}

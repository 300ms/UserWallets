using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserWalletsController : ControllerBase
	{
		private IUserWalletService _userWalletService;

		public UserWalletsController(IUserWalletService userWalletService)
		{
			_userWalletService = userWalletService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _userWalletService.GetList();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("add")]
		public IActionResult Add(UserWallet userWallet)
		{
			var result = _userWalletService.Add(userWallet);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("delete")]
		public IActionResult Delete(UserWallet userWallet)
		{
			var result = _userWalletService.Delete(userWallet);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}

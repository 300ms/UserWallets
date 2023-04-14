using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WalletsController : ControllerBase
	{
		private IWalletService _walletService;
		public WalletsController(IWalletService walletService)
		{
			_walletService = walletService;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _walletService.GetList();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			var result = _walletService.GetById(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("add")]
		public IActionResult Add(Wallet wallet)
		{
			var result = _walletService.Add(wallet);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Wallet wallet)
		{
			var result = _walletService.Update(wallet);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(Wallet wallet)
		{
			var result = _walletService.Delete(wallet);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}

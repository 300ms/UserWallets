using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private IAccountService _accountService;
		public AccountsController(IAccountService accountService)
		{
			_accountService = accountService;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _accountService.GetList();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			var result = _accountService.GetById(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("add")]
		public IActionResult Add(Account account)
		{
			var result = _accountService.Add(account);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Account account)
		{
			var result = _accountService.Update(account);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(Account account)
		{
			var result = _accountService.Delete(account);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}

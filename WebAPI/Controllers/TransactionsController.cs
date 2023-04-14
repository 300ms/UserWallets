using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransactionsController : ControllerBase
	{
		private ITransactionService _transactionService;
		public TransactionsController(ITransactionService transactionService)
		{
			_transactionService = transactionService;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _transactionService.GetList();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			var result = _transactionService.GetById(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("add")]
		public IActionResult Add(Transaction transaction)
		{
			var result = _transactionService.Add(transaction);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Transaction transaction)
		{
			var result = _transactionService.Update(transaction);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(Transaction transaction)
		{
			var result = _transactionService.Delete(transaction);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}

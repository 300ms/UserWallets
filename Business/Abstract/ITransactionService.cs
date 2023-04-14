using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ITransactionService
	{
		IDataResult<Transaction> GetById(int id);
		IDataResult<List<Transaction>> GetList();
		IResult Add(Transaction transaction);
		IResult Update(Transaction transaction);
		IResult Delete(Transaction transaction);
	}
}

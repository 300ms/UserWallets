using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IAccountService
	{
		IDataResult<Account> GetById(int id);
		IDataResult<List<Account>> GetList();
		IResult Add(Account account);
		IResult Update(Account account);
		IResult Delete(Account account);
	}
}

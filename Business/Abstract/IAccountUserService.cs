using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IAccountUserService
	{
		IDataResult<List<AccountUser>> GetList();
		IResult Add(AccountUser accountUser);
		IResult Delete(AccountUser accountUser);
	}
}

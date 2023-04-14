using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserWalletService
	{
		IDataResult<List<UserWallet>> GetList();
		IResult Add(UserWallet userWallet);
		IResult Delete(UserWallet userWallet);
	}
}

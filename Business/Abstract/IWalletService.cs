using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IWalletService
	{
		IDataResult<Wallet> GetById(int id);
		IDataResult<List<Wallet>> GetList();
		IResult Add(Wallet wallet);
		IResult Update(Wallet wallet);
		IResult Delete(Wallet wallet);
	}
}

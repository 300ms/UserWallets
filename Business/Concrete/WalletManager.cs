using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
	internal class WalletManager : IWalletService
	{
		private IWalletDal _walletDal;
		public WalletManager(IWalletDal walletDal)
		{
			_walletDal = walletDal;
		}
		public IDataResult<Wallet> GetById(int id)
		{
			return new SuccessDataResult<Wallet>(_walletDal.Get(wallet => wallet.Id == id));
		}
		public IDataResult<List<Wallet>> GetList()
		{
			return new SuccessDataResult<List<Wallet>>(_walletDal.GetList().ToList());
		}
		public IResult Add(Wallet wallet)
		{
			_walletDal.Add(wallet);
			return new SuccessResult(Messages.WalletAdded);
		}
		public IResult Delete(Wallet wallet)
		{
			_walletDal.Delete(wallet);
			return new SuccessResult(Messages.WalletDeleted);
		}
		public IResult Update(Wallet wallet)
		{
			_walletDal.Update(wallet);
			return new SuccessResult(Messages.WalletUpdated);
		}
	}
}

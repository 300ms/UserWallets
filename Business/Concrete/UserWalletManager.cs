using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
	internal class UserWalletManager : IUserWalletService
	{
		private IUserWalletDal _userWalletDal;
		public UserWalletManager(IUserWalletDal userWalletDal)
		{
			_userWalletDal = userWalletDal;
		}
		public IDataResult<List<UserWallet>> GetList()
		{
			return new SuccessDataResult<List<UserWallet>>(_userWalletDal.GetList().ToList());
		}
		public IResult Add(UserWallet userWallet)
		{
			_userWalletDal.Add(userWallet);
			return new SuccessResult(Messages.UserWalletAdded);
		}
		public IResult Delete(UserWallet userWallet)
		{
			_userWalletDal.Delete(userWallet);
			return new SuccessResult(Messages.UserWalletDeleted);
		}
	}
}

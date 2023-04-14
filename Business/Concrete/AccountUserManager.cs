using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class AccountUserManager : IAccountUserService
	{
		private IAccountUserDal _accountUserDal;
		public AccountUserManager(IAccountUserDal accountUserDal)
		{
			_accountUserDal = accountUserDal;
		}
		public IResult Add(AccountUser accountUser)
		{
			_accountUserDal.Add(accountUser);
			return new SuccessResult(Messages.AccountUserAdded);
		}
		public IResult Delete(AccountUser accountUser)
		{
			_accountUserDal.Delete(accountUser);
			return new SuccessResult(Messages.AccountUserDeleted);
		}
		public IDataResult<List<AccountUser>> GetList()
		{
			return new SuccessDataResult<List<AccountUser>>(_accountUserDal.GetList().ToList());
		}
	}
}

using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Business.Constants;

namespace Business.Concrete
{
	public class AccountManager : IAccountService
	{
		private IAccountDal _accountDal;
		public AccountManager(IAccountDal accountDal)
		{
			_accountDal = accountDal;
		}

		public IDataResult<Account> GetById(int id)
		{
			return new SuccessDataResult<Account>(_accountDal.Get(account => account.Id == id));
		}

		public IDataResult<List<Account>> GetList()
		{
			return new SuccessDataResult<List<Account>>(_accountDal.GetList().ToList());
		}

		public IResult Add(Account account)
		{
			_accountDal.Add(account);
			return new SuccessResult(Messages.AccountAdded);
		}

		public IResult Delete(Account account)
		{
			_accountDal.Delete(account);
			return new SuccessResult(Messages.AccountDeleted);
		}

		public IResult Update(Account account)
		{
			_accountDal.Update(account);
			return new SuccessResult(Messages.AccountUpdated);
		}
	}
}

using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
	public class AccountManager : IAccountService
	{
		private IAccountDal _accountDal;
		public AccountManager(IAccountDal accountDal)
		{
			_accountDal = accountDal;
		}

		public void Add(Account account)
		{
			_accountDal.Add(account);
		}

		public void Delete(Account account)
		{
			_accountDal.Delete(account);
		}

		public Account GetById(int id)
		{
			return _accountDal.Get(account => account.Id == id);
		}

		public List<Account> GetList()
		{
			return _accountDal.GetList().ToList();
		}

		public void Update(Account account)
		{
			_accountDal.Update(account);
		}
	}
}

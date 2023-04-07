using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
	public interface IAccountService
	{
		Account GetById(int id);
		List<Account> GetList();
		void Add(Account account);
		void Update(Account account);
		void Delete(Account account);
	}
}

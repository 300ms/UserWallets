using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Business.Constants;
namespace Business.Concrete
{
	public class UserManager : IUserService
	{
		private IUserDal _userDal;
		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}
		public IDataResult<User> GetById(int id)
		{
			return new SuccessDataResult<User>(_userDal.Get(user => user.Id == id));
		}
		public IDataResult<List<User>> GetList()
		{
			return new SuccessDataResult<List<User>>(_userDal.GetList().ToList());
		}
		public IResult Add(User user)
		{
			_userDal.Add(user);
			return new SuccessResult(Messages.UserAdded);
		}
		public IResult Delete(User user)
		{
			_userDal.Delete(user);
			return new SuccessResult(Messages.UserDeleted);
		}
		public IResult Update(User user)
		{
			_userDal.Update(user);
			return new SuccessResult(Messages.UserUpdated);
		}
	}
}

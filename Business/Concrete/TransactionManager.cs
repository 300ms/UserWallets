using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
	public class TransactionManager : ITransactionService
	{
		private ITransactionDal _transactionDal;
		public TransactionManager(ITransactionDal transactionDal)
		{
			_transactionDal = transactionDal;
		}
		public IDataResult<Transaction> GetById(int id)
		{
			return new SuccessDataResult<Transaction>(_transactionDal.Get(transaction => transaction.Id == id));
		}
		public IDataResult<List<Transaction>> GetByUserId(int id)
		{
			return new SuccessDataResult<List<Transaction>>(_transactionDal.GetList(transaction => transaction.UserId == id).ToList());
		}
		public IDataResult<List<Transaction>> GetByWalletId(int id)
		{
			return new SuccessDataResult<List<Transaction>>(_transactionDal.GetList(transaction => transaction.WalletId == id).ToList());
		}
		public IDataResult<List<Transaction>> GetList()
		{
			return new SuccessDataResult<List<Transaction>>(_transactionDal.GetList().ToList());
		}
		public IResult Add(Transaction transaction)
		{
			_transactionDal.Add(transaction);
			return new SuccessResult(Messages.TransactionAdded);
		}
		public IResult Update(Transaction transaction)
		{
			_transactionDal.Update(transaction);
			return new SuccessResult(Messages.TransactionUpdated);
		}
		public IResult Delete(Transaction transaction)
		{
			_transactionDal.Delete(transaction);
			return new SuccessResult(Messages.TransactionDeleted);
		}
	}
}

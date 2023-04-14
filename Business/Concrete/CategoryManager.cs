using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}
		public IDataResult<Category> GetById(int id)
		{
			return new SuccessDataResult<Category>(_categoryDal.Get(category => category.Id == id));
		}
		public IDataResult<List<Category>> GetList()
		{
			return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
		}
		public IResult Add(Category category)
		{
			_categoryDal.Add(category);
			return new SuccessResult(Messages.CategoryAdded);
		}
		public IResult Delete(Category category)
		{
			_categoryDal.Delete(category);
			return new SuccessResult(Messages.CategoryDeleted);
		}
		public IResult Update(Category category)
		{
			_categoryDal.Update(category);
			return new SuccessResult(Messages.CategoryUpdated);
		}
	}
}

using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<AccountManager>().As<IAccountService>().SingleInstance();
			builder.RegisterType<EfAccountDal>().As<IAccountDal>().SingleInstance();

			builder.RegisterType<AccountUserManager>().As<IAccountUserService>().SingleInstance();
			builder.RegisterType<EfAccountUserDal>().As<IAccountUserDal>().SingleInstance();

			builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
			builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

			builder.RegisterType<TransactionManager>().As<ITransactionService>().SingleInstance();
			builder.RegisterType<EfTransactionDal>().As<ITransactionDal>().SingleInstance();

			builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
			builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

			builder.RegisterType<UserWalletManager>().As<IUserWalletService>().SingleInstance();
			builder.RegisterType<EfUserWalletDal>().As<IUserWalletDal>().SingleInstance();

			builder.RegisterType<WalletManager>().As<IWalletService>().SingleInstance();
			builder.RegisterType<EfWalletDal>().As<IWalletDal>().SingleInstance();
		}
	}
}

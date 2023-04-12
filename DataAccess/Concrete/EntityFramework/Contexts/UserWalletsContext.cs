using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
	public class UserWalletsContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-1MJ92GE;Database=UserWallets;Integrated Security=True;TrustServerCertificate=true");
		}

		public DbSet<Account> Account { get; set; }
		//public DbSet<AccountUser> AccountUsers { get; set; }
		//public DbSet<User> Users { get; set; }
		//public DbSet<UserWallet> UserWallets { get; set; }
		//public DbSet<Wallet> Wallets { get; set; }
		//public DbSet<Transaction> Transactions { get; set; }
		//public DbSet<Category> Categories { get; set; }
	}
}

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
		public DbSet<AccountUser> AccountUser { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<UserWallet> UserWallet { get; set; }
		public DbSet<Wallet> Wallet { get; set; }
		public DbSet<Transaction> Transaction { get; set; }
		public DbSet<Category> Category { get; set; }
	}
}

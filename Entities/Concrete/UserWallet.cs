using Core.Entities;

namespace Entities.Concrete
{
	public class UserWallet : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int WalletId { get; set; }
	}
}

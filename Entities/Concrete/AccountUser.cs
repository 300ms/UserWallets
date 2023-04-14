using Core.Entities;

namespace Entities.Concrete
{
	public class AccountUser : IEntity
	{
		public int Id { get; set; }
		public int AccountId { get; set; }
		public int UserId { get; set; }
	}
}

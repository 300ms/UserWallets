using Core.Entities;

namespace Entities.Concrete
{
	public class Wallet : IEntity
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public decimal Balance { get; set; }
	}
}

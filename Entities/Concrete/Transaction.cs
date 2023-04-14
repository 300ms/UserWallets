using Core.Entities;

namespace Entities.Concrete
{
	public class Transaction : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int WalletId { get; set; }
		public decimal Amount { get; set; }
		public int CategoryId { get; set; }
		public string Description { get; set; }
		public DateTime CreatedOn { get; set; }
		public int CreatedBy { get; set; }
		public DateTime ModifiedOn { get; set;}
		public int ModifiedBy { get; set; }
	}
}

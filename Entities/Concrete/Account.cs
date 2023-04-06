using Core.Entities;

namespace Entities.Concrete
{
	public class Account:IEntity
	{
		public int OwnerUserId { get; set; }
		public string AccountName { get; set; }
	}
}

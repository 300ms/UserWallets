using Core.Entities;

namespace Entities.Concrete
{
	public class Category : IEntity
	{
		public int Id { get; set; }
		public int AccountId { get; set; }
		public string Description { get; set; }
	}
}

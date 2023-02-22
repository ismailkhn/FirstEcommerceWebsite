using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class TagToBlog
	{
		public int Id { get; set; }
		public int BlogId { get; set; }
		public int TagId { get; set; }

		public virtual BlogTag Tag { get; set; }
	}
}

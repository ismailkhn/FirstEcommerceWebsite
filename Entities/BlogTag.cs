using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class BlogTag
	{
		public int Id { get; set; }
		[MaxLength(200)]
		public string Name { get; set; } = null!;

		public bool IsDeleted { get; set; }

	}
}

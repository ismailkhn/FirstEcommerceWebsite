using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Blog

	{
		public int Id { get; set; }

		[MaxLength(500)]
		public string? Title { get; set; }
		[MaxLength(1000)]
		public string? Description { get; set; }
		public bool IsDeleted { get; set; }
		public string? PhotoUrl { get; set; }

		public DateTime PublishedTime { get; set; }
		public DateTime? ModifiedTime { get; set; }
		public int? AuthorId { get; set; }

		public virtual Author? Author { get; set; }
		public virtual BlogCategory? BlogCategory { get; set; }
		public virtual List<TagToBlog>? TagToBlogs { get; set; }
	}
}

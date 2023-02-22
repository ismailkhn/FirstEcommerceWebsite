using Entities;
using System.Diagnostics.Contracts;

namespace EcommerceWeb.Models
{
	public class ProductFilterVM
	{
		public List<Product>? ProductList { get; set; }
		public List<Category>? CategoryList { get; set; }
		public string? SearchText { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
	public static class DomHelperClass
	{
		public static TextPosition findClassNameForPosition(string pos)
		{
			string textParent = "";
			string textAlign = "";

			switch(pos)
			{
				case "center":
					textParent = "justify-content-md-center";
					textAlign = "text-center";
					break;
				case "left":
					textParent = "justify-content-md-start";
					break;
				case "right":
					textParent = "justify-content-md-end";
					textAlign = "text-end";
					break;

			}
			return new TextPosition { textParent= textParent, textAlign = textAlign };
		}
	}
}

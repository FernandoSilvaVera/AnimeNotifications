using System.Collections.Generic;
using ConsoleApp1;


namespace ConsoleApp1
{

	public struct Pages
	{
		public List<string> Href { get; set; }
		public List<string> Image { get; set; }
	}

	public class Manga
	{
		public string Href { get; set; }
		public string Chapter { get; set; }
		public Pages Page;

		public Manga(string href, string chapter)
		{
			Href = href;
			Chapter = chapter;
			Page = new Pages
			{
				Href = new List<string>(),
				Image = new List<string>()
			};
		}

	}

}

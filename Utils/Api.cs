using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace IronWebScraperConsole
{

	class Program
	{

		private static List<Manga> Manga;

		static void Main(string[] args)
		{

			Manga = new List<Manga>();
			new NineManga("http://es.ninemanga.com/manga/Nomi+Joshi.html", new NineManga(ref Manga).MangaChapters).Start();
			Manga.ForEach(pageLink => new NineManga(pageLink.Href, new NineManga(ref Manga).ImageLinks).Start());
			Manga.ForEach(pageLink => pageLink.Page.Href.ForEach(s => new NineManga(s, new NineManga(ref Manga).ImageSrc, pageLink.Href).Start()));

			Console.ReadKey();
		}

	}

}

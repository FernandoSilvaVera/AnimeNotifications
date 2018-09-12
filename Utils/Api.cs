using IronWebScraper;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IronWebScraperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var scraper = new NineManga();
            scraper.Start();
        }
    }

	public class Manga
	{

		public string Href { get; set; }
		public string Chapter { get; set; }

		public Manga(string href, string chapter)
		{
			Href = href;
			Chapter = chapter;
		}

	}


    public class NineManga : WebScraper
    {

		private List<Manga> Manga { get; set; }

		public NineManga() => Manga = new List<Manga>();

        public override void Init()
        {
            LoggingLevel = LogLevel.All;
            Request("http://es.ninemanga.com/manga/Boku+no+Hero+Academia.html", Parse);
        }

        public override void Parse(Response response)
        {
			foreach (var attribute in response.Css("li").CSS("a.chapter_list_a"))
				Manga.Add(new Manga(attribute.Attributes["href"], Regex.Match(attribute.Attributes["title"], @"\d+").Value));
			
			foreach (var manga in Manga)
			{
				Console.Write(manga.Chapter);
				Console.Write(" - ");
				Console.WriteLine(manga.Href);
			}
			Console.ReadKey();
        }
    }
}

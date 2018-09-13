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
            new NineManga("http://es.ninemanga.com/manga/Boku+no+Hero+Academia.html", new NineManga().MangaChapters).Start();
			new NineManga("http://es.ninemanga.com/chapter/Boku%20no%20Hero%20Academia/196978.html", new NineManga().ChapterLinks).Start();
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

		private static List<Manga> Manga { get; set; }
		private static List<string> Chapter { get; set; }
		public static string Href { get; set; }
		public static Action<Response> Function { get; set; }

		public NineManga(string href, Action<Response> function)
		{
			Manga = new List<Manga>();
			Chapter = new List<string>();
			Href = href;
			Function = function;
		}

		public NineManga()
		{
		}

        public override void Init()
        {
            LoggingLevel = LogLevel.All;
            Request(Href, Function);
        }

        public void MangaChapters(Response response)
        {
			foreach (var attribute in response.Css("li").CSS("a.chapter_list_a"))
				Manga.Add(new Manga(attribute.Attributes["href"], Regex.Match(attribute.Attributes["title"], @"\d+").Value));
			
			foreach (var manga in Manga)
			{
				Console.Write(manga.Chapter);
				Console.Write(" - ");
				Console.WriteLine(manga.Href);
			}
			//Console.ReadKey();

			//GenerateChapter("as");

        }

		public void ChapterLinks(Response response)
		{
			int index = Href.IndexOf(".html");
			for (int i = 0; i < response.Css("div.changepage").CSS("select").CSS("option").Length/2; i++)
				Chapter.Add(Href.Insert(index , "-"+ i.ToString()));

			Console.ReadKey();
		}

		public override void Parse(Response response) => throw new NotImplementedException();
	}
}

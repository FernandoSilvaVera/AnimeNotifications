using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime.ViewModels
{
	using Models;


	class ShowMangaViewModel : BaseViewModel
	{

		private List<string> urlManga;


		private Anime Anime { get; set; }
		public List<string> UrlManga {
			get => urlManga;
			set => SetValue(ref urlManga, value);
		}


		public ShowMangaViewModel(Anime anime)
		{
			Anime = anime;
			LoadManga();
		}

		private void LoadManga()
		{
			UrlManga = new List<string>
			{
				"http://c7.ninemanga.com/es_manga/pic5/34/18530/737805/2324d269629f81b27cfa212c566dca7f.jpg",
				"http://c7.ninemanga.com/es_manga/pic5/34/18530/737805/2324d269629f81b27cfa212c566dca7f.jpg",
				"http://c7.ninemanga.com/es_manga/pic5/34/18530/737805/2324d269629f81b27cfa212c566dca7f.jpg",
				"http://c7.ninemanga.com/es_manga/pic5/34/18530/737805/2324d269629f81b27cfa212c566dca7f.jpg",
				"http://c7.ninemanga.com/es_manga/pic5/34/18530/737805/2324d269629f81b27cfa212c566dca7f.jpg"
			};
		}


	}
}

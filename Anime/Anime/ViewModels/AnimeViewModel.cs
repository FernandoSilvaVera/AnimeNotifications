using System;
using System.Collections.Generic;
using System.Text;

namespace Anime.ViewModels
{
	using Models;

	class AnimeViewModel
	{
		#region Properties
		public Anime Anime { get; set; }
		#endregion

		public AnimeViewModel(Anime anime) => Anime = anime;
	}
}

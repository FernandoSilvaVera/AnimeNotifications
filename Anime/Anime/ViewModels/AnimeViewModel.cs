using System;
using System.Collections.Generic;
using System.Text;

namespace Anime.ViewModels
{
	using Models;

	class ItemViewModel
	{
		#region Properties
		public Anime Anime { get; set; }
		#endregion

		public ItemViewModel(Anime anime) => Anime = anime;
	}
}

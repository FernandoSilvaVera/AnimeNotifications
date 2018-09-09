using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Anime.ViewModels
{
	using Models;

	class ListMangaViewModel : ListOtakuViewModel
	{
		#region Constructors
		public ListMangaViewModel() => LoadAnimeList();
		#endregion

		#region Commands
		public ICommand RefreshCommand	=> new RelayCommand(LoadAnimeList);
		#endregion

		#region Methods

		private void LoadAnimeList()
		{
			IsRefreshing = true;
			#region futureDataBase
			animesList = new List<Anime>
			{
				new Anime() { Nombre = "Happy Sugar Life", Descripcion = "Rosa y loli", Capitulos = 20 },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = 5 },
				new Anime() { Nombre = "One Piece", Descripcion = "Luffy", Capitulos = 10 }
			};
			#endregion
			Animes = new ObservableCollection<Anime>(list: animesList);
			IsRefreshing = false;
		}

		#endregion

	}

}


using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Anime.ViewModels
{

	using Models;

	class ListMangasViewModel : ListOtakuViewModel
	{
		#region Constructors
		public ListMangasViewModel() => LoadAnimeList();
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
				new Anime() { Nombre = "Happy Sugar Life", Descripcion = "Rosa y loli", Capitulos = "50" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "Boku No Hero", Descripcion = "Deku", Capitulos = "500" },
				new Anime() { Nombre = "One Piece", Descripcion = "Luffy", Capitulos = "10" }
			};
			#endregion
			Animes = new ObservableCollection<Anime>(animesList);
			IsRefreshing = false;
		}

		#endregion

	}

}


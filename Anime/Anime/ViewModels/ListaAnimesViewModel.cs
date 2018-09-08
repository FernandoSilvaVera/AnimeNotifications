using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Input;

namespace Anime.ViewModels
{

	using Models;

	class ListaAnimesViewModel : ListOtakuViewModel
	{
		#region Constructors
		public ListaAnimesViewModel() => LoadMangaList();
		#endregion

		#region Commands
		public ICommand RefreshCommand	=> new RelayCommand(LoadMangaList);
		#endregion

		#region Methods

		private void LoadMangaList()
		{
			IsRefreshing = true;
			#region futureDataBase
			animesList = new List<Anime>
			{
				new Anime() { Nombre = "Dragon ball", Descripcion = "Goku y Vegeta", Capitulos = "50" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" },
				new Anime() { Nombre = "Death Note", Descripcion = "L y Kira", Capitulos = "10" }
			};
			#endregion
			Animes = new ObservableCollection<Anime>(animesList);
			IsRefreshing = false;
		}

		#endregion
	}
}

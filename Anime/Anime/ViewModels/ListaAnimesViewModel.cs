using System.Collections.ObjectModel;

namespace Anime.ViewModels
{
	using GalaSoft.MvvmLight.Command;
	using Models;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Input;

	class ListaAnimesViewModel : BaseViewModel
	{

		#region Attributes
		private ObservableCollection<Anime> animes;
		private bool isRefreshing;
		private List<Anime> animesList;
		private string filter;
		#endregion

		#region Properties
		public string Filter {
			get => filter;
			set {
				SetValue(ref filter, value);
				Search();
			}
		}
		public bool IsRefreshing {
			get => isRefreshing;
			set => SetValue(ref isRefreshing, value);
		}
		public ObservableCollection<Anime> Animes {
			get => animes;
			set => SetValue(ref animes, value);
		}
		#endregion

		#region Constructors
		public ListaAnimesViewModel() => LoadAnimes();
		#endregion

		#region Methods
		private void LoadAnimes()
		{
			IsRefreshing = true;
			#region futureDataBase
			animesList = new List<Anime>();
			animesList.Add(new Anime() { Nombre = "Dragon ball", Descripcion = "Goku y Vegeta", Capitulos = "50" });
			animesList.Add(new Anime() { Nombre = "Naruto", Descripcion = "Naruto y Sasuke", Capitulos = "500" });
			animesList.Add(new Anime() { Nombre = "Happy Sugar Life", Descripcion = "Rosa y no rosa", Capitulos = "10" });
			#endregion
			Animes = new ObservableCollection<Anime>(animesList);
			IsRefreshing = false;
		}
		#endregion

		#region Commands

		#endregion
		public ICommand RefreshCommand	=> new RelayCommand(LoadAnimes);
		public ICommand SearchCommand	=> new RelayCommand(Search);

		public void Search() => Animes = string.IsNullOrEmpty(Filter) ? new ObservableCollection<Anime>(animesList) : ApplyFilter();

		private ObservableCollection<Anime> ApplyFilter()
		{	
			return new ObservableCollection<Anime>(
				animesList.Where(
					a => a.Nombre.ToLower().Contains(Filter.ToLower())
				)
			);
		}


	}
}

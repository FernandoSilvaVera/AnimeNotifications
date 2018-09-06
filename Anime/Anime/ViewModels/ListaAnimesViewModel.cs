using System.Collections.ObjectModel;

namespace Anime.ViewModels
{

	using Models;
	using Services;

	class ListaAnimesViewModel : BaseViewModel
    {
		#region Services
		private ApiService apiService;
		#endregion

		#region Attributes
		private ObservableCollection <Anime> animes;
		#endregion

		#region Properties
		public ObservableCollection <Anime> Animes {
			get => animes;
			set => SetValue(ref animes, value);
		}
		#endregion

		#region Constructors
		public ListaAnimesViewModel() => apiService = new ApiService();
		#endregion

		#region Methods
		private void LoadAnimes() { }
		#endregion

	}
}

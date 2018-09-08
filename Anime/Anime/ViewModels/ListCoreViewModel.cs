using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Anime.ViewModels
{

	using Models;
	using Views;

	class ListOtakuViewModel : BaseViewModel
    {
		#region Attributes
		private ObservableCollection<ListItemViewModel> animes;
		private bool isRefreshing;
		private string filter;
		protected List<Anime> animesList;
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
		public ObservableCollection<ListItemViewModel> Animes {
			get => animes;
			set => SetValue(ref animes, value);
		}
		#endregion

		#region Commands
		public ICommand SearchCommand	=> new RelayCommand(Search);
		#endregion


		#region Methods
		private ObservableCollection<ListItemViewModel> ApplyFilter()
		{	
			return new ObservableCollection<ListItemViewModel>(
				GetListItemViewModel().Where(
					a => a.Nombre.ToLower().Contains(Filter.ToLower())
				)
			);
		}

		private void Search() => Animes = string.IsNullOrEmpty(Filter) ? new ObservableCollection<ListItemViewModel>(GetListItemViewModel()) : ApplyFilter();

		protected IEnumerable<ListItemViewModel> GetListItemViewModel()
		{
			return animesList.Select(a => new ListItemViewModel
			{
				Capitulos		= a.Capitulos,
				Descripcion		= a.Descripcion,
				Nombre			= a.Nombre
			});
		}

		#endregion
    }

	class ListItemViewModel : Anime
    {
		#region Commands
		public ICommand SelectItemListCommand => new RelayCommand(ListItem);
		#endregion

		#region Methods
		public async void ListItem()
		{
			MainViewModel.Instance.Item = new ItemViewModel(this);
			await Application.Current.MainPage.Navigation.PushAsync(new ItemPage());
		}
		#endregion
	}

}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Linq;
using System.Windows.Input;

namespace Anime.ViewModels
{

	using Models;

	class ListOtakuViewModel : BaseViewModel
    {
		#region Attributes
		private ObservableCollection<Anime> animes;
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
		public ObservableCollection<Anime> Animes {
			get => animes;
			set => SetValue(ref animes, value);
		}
		#endregion

		#region Commands
		public ICommand SearchCommand	=> new RelayCommand(Search);
		#endregion


		#region Methods
		private ObservableCollection<Anime> ApplyFilter()
		{	
			return new ObservableCollection<Anime>(
				animesList.Where(
					a => a.Nombre.ToLower().Contains(Filter.ToLower())
				)
			);
		}

		private void Search() => Animes = string.IsNullOrEmpty(Filter) ? new ObservableCollection<Anime>(animesList) : ApplyFilter();
		#endregion
    }
}

using System.Collections.Generic;

namespace Anime.ViewModels
{
	using Anime.Views;
	using GalaSoft.MvvmLight.Command;
	using Models;
	using System.Windows.Input;
	using Xamarin.Forms;


	class AnimeViewModel
	{
		#region Attributes
		#endregion

		#region Properties
		public Anime Anime { get; set; }
		#endregion

		public AnimeViewModel(Anime anime)
		{
			Anime = anime;
			LoadChapters();
		}

		private void LoadChapters()
		{
			Anime.Chapters = new List<Chapter>();
			for (int i = Anime.Capitulos; i > 0; i--)
				Anime.Chapters.Add(new Chapter(i));
		}

		public ICommand SelectChapterListCommand => new RelayCommand(SelectChapter);

		private void SelectChapter()
		{
			Xamarin.Forms.Application.Current.MainPage = new NavigationPage( new ListCoreTabbedPage() );
		}

	}

}
﻿namespace Anime.ViewModels
{
    class MainViewModel
    {
		#region ViewModels
		public LoginViewModel Login { get; set; }
		public ListAnimeViewModel ListaAnimes { get; set; }
		public ListMangaViewModel ListMangas { get; set; }
		public ItemViewModel Item { get; set; }
		#endregion

		#region Constructors
		public MainViewModel()
		{
			instance	= this;
			Login		= new LoginViewModel();
		}
		#endregion

		#region Methods
		#endregion
		
		#region Singleton
		private static MainViewModel instance;
		public static MainViewModel Instance => instance is null ? new MainViewModel() : instance;
		#endregion
	}
}
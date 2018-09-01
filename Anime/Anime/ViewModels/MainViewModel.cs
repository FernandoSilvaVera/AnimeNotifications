namespace Anime.ViewModels
{
    class MainViewModel
    {

		#region ViewModels
		public LoginViewModel Login { get; set; }
		#endregion

		#region Constructors
		public MainViewModel()
		{
			Login = new LoginViewModel();
		}
		#endregion

		#region Methods

		#endregion
	}
}

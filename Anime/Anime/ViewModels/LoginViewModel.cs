namespace Anime.ViewModels
{
	using System.Windows.Input;

    class LoginViewModel
    {
		#region Properties
		public string User { get; set; }

		public string Pass { get; set; }

		public string IsRunning { get; set; }
		#endregion

		#region Constructors
		public LoginViewModel()
		{

		}
		#endregion

		#region Commands
		public ICommand LoginCommand { get; set; }


		#endregion

		#region Methods

		#endregion

	}
}

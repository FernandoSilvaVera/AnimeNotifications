namespace Anime.ViewModels
{
	using GalaSoft.MvvmLight.Command;
	using System.Threading.Tasks;
	using System.Windows.Input;
	using Xamarin.Forms;
	using Views;

	class LoginViewModel : BaseViewModel
	{
		#region Attributes
		private string pass;
		private bool isRunning;
		private bool isEnabled;
		#endregion

		#region Properties
		public string User { get; set; }

		public string Pass {
			get { return pass; }
			set { SetValue(ref pass, value); }
		}

		public bool IsRunning {
			get { return isRunning; }
			set { SetValue(ref isRunning, value); }
		}

		public bool IsEnabled {
			get { return isEnabled; }
			set { SetValue(ref isEnabled, value); }
		}
		#endregion

		#region Constructors
		public LoginViewModel()
		{
			User = "Vents";
			Pass = "admin";
			isEnabled = true;
			IsRunning = false;

		}
		#endregion

		#region Commands
		public ICommand LoginCommand {
			get {
				return new RelayCommand(Login);
			}
		}
		#endregion



		#region Methods
		private async void Login()
		{
			if (!await camposValidos())
				return;
			MainViewModel.Instance.ListaAnimes = new ListaAnimesViewModel();
			await Application.Current.MainPage.Navigation.PushAsync(new ListaAnimesPage());
		}

		private async Task<bool> camposValidos()
		{
			if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Pass))
			{
				await Application.Current.MainPage.DisplayAlert(
					"Error",
					"No has introducido usuario/contraseña",
					"Aceptar"
				);
				Pass = string.Empty;
				return false;
			}
			return true;
		}
		#endregion

	}
}

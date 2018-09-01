using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Anime
{
	public partial class App : Application
	{
		#region Constructors
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage( new Views.LoginPage() );
		}
		#endregion

		#region Methods
		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
		#endregion
	}
}

using Anime.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Anime.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OtakuTabbedPage : TabbedPage
	{
		public OtakuTabbedPage ()
		{
			MainViewModel.Instance.ListaAnimes = new ListAnimeViewModel();
			InitializeComponent ();
		}
	}
}
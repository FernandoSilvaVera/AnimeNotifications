using Anime.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Anime.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OtakuTabbedPage : TabbedPage
	{
		public OtakuTabbedPage ()
		{
			MainViewModel.Instance.ListaAnimes = new ListaAnimesViewModel();
			InitializeComponent ();
		}
	}
}
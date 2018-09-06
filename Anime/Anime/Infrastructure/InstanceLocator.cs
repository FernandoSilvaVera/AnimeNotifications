namespace Anime.Infrastructure
{
	using ViewModels;

    class InstanceLocator
    {

		#region Properties
		public MainViewModel Main { get; set; }
		#endregion

		#region Constructors
		public InstanceLocator() => Main = new MainViewModel();
		#endregion

	}
}

namespace Anime.ViewModels
{
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;

	public class BaseViewModel : INotifyPropertyChanged
    {
		#region Events
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		#region Methods
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(backingField, value))
				return;

			backingField = value;
			OnPropertyChanged(propertyName);
		}
		#endregion

	}
}

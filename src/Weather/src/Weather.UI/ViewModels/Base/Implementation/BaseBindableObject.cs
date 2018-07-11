using System.ComponentModel;
using System.Runtime.CompilerServices;
using Weather.UI.Annotations;

namespace Weather.UI.ViewModels.Base.Implementation
{
    public class BaseBindableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

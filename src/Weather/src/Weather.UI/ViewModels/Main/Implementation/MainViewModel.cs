using System.Windows.Input;
using PropertyChanged;
using Weather.Core.Services;
using Weather.UI.ViewModels.Base.Implementation;

namespace Weather.UI.ViewModels.Main.Implementation
{
    [AddINotifyPropertyChangedInterface]
    internal class MainViewModel : BaseBindableObject, IMainViewModel
    {
        public MainViewModel(IWeatherService weatherService)
        {
            LoadCommand = new LoadWeatherCommand(this, weatherService);
        }

        public ICommand LoadCommand { get; }
        public Core.Models.Weather Weather { get; internal set; }
    }
}
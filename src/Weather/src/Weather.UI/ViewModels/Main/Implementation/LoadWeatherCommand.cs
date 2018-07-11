using Weather.Core.Services;
using Weather.UI.ViewModels.Base.Implementation;

namespace Weather.UI.ViewModels.Main.Implementation
{
    internal class LoadWeatherCommand : Command
    {
        private readonly MainViewModel _viewModel;
        private readonly IWeatherService _weatherService;

        public LoadWeatherCommand(MainViewModel viewModel, IWeatherService weatherService)
        {
            _viewModel = viewModel;
            _weatherService = weatherService;
        }

        public override async void Execute(object parameter)
        {
            _viewModel.Weather = await _weatherService.GetWeatherAsync("Yerevan");
        }
    }
}
using System.ComponentModel;
using System.Windows.Input;

namespace Weather.UI.ViewModels.Main
{
    public interface IMainViewModel : INotifyPropertyChanged
    {
        ICommand LoadCommand { get; }
        Core.Models.Weather Weather { get; }
    }
}
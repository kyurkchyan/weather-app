using Weather.UI.ViewModels.Main;

namespace Weather.Forms
{
    public partial class MainPage
    {
        private readonly IMainViewModel _viewModel;

        public MainPage(IMainViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadCommand.Execute(null);
        }
    }
}
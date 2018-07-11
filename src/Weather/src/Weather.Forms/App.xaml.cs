using Grace.DependencyInjection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]

namespace Weather.Forms
{
    public partial class App
    {
        private readonly DependencyInjectionContainer _container;

        public App(DependencyInjectionContainer container)
        {
            _container = container;
            InitializeComponent();

            MainPage = new NavigationPage(_container.Locate<MainPage>());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
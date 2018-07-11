using Android.App;
using Android.Content.PM;
using Android.OS;
using Grace.DependencyInjection;
using Weather.Core;
using Weather.Forms;
using Weather.UI;

namespace Weather.Droid
{
    [Activity(Label = "Weather", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private DependencyInjectionContainer _container;

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            _container = new DependencyInjectionContainer();
            _container.RegisterCoreDependencies()
                      .RegisterUIDependencies()
                      .RegisterFormsDependencies()
                      .RegisterDroidDependencies();

            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(_container));
        }
    }
}
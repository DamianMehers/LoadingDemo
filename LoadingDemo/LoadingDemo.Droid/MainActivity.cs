using Android.App;
using Android.Content.PM;
using Android.OS;
using LoadingDemo.Shared;

namespace LoadingDemo.Droid {
    [Activity(Label = "LoadingDemo", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity {
        protected override void OnCreate(Bundle bundle) {
            // Reference to ensure it gets brought into the app
            System.Diagnostics.Debug.Write(Locator.MyViewModel);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}


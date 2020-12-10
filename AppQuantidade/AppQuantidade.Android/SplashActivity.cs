using Android.App;
using Android.OS;

namespace AppQuantidade.Droid
{
    [Activity(Label = "App Matur", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            OverridePendingTransition(10,10);
            
        }
    }
}
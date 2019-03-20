using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FilmsXamarin.Droid
{
    [Activity(Label = "Films", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            System.Diagnostics.Debug.WriteLine("OnCreate");
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        protected override void OnStart()
        {
            base.OnStart();
            System.Diagnostics.Debug.WriteLine("OnStart", "OnCreate called, App is OnStart");
        }

        protected override void OnResume()
        {
            base.OnResume();
            System.Diagnostics.Debug.WriteLine("OnResume", "OnCreate called, App is OnResume");
        }

        protected override void OnPause()
        {
            base.OnPause();
            System.Diagnostics.Debug.WriteLine("OnPause", "OnCreate called, App is OnPause");
        }

        protected override void OnStop()
        {
            base.OnStop();
            System.Diagnostics.Debug.WriteLine("OnStop", "OnCreate called, App is OnStop");
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            System.Diagnostics.Debug.WriteLine("OnDestroy", "OnCreate called, App is OnStop");
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            System.Diagnostics.Debug.WriteLine("{0}OnSaveInstanceState ", "OnCreate called, App is Create");
        }
    }
}
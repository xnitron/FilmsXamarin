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

            System.Diagnostics.Debug.WriteLine("OnCreate");
            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        protected override void OnStart()
        {
            System.Diagnostics.Debug.WriteLine("OnStart", "OnCreate called, App is OnStart");
            base.OnStart();
        }

        protected override void OnResume()
        {
            System.Diagnostics.Debug.WriteLine("OnResume", "OnCreate called, App is OnResume");
            base.OnResume();
        }

        protected override void OnPause()
        {
            System.Diagnostics.Debug.WriteLine("OnPause", "OnCreate called, App is OnPause");
            base.OnPause();
        }

        protected override void OnStop()
        {
            System.Diagnostics.Debug.WriteLine("OnStop", "OnCreate called, App is OnStop");
            base.OnStop();
        }

        protected override void OnDestroy()
        {
            System.Diagnostics.Debug.WriteLine("OnDestroy", "OnCreate called, App is OnStop");
            base.OnDestroy();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            System.Diagnostics.Debug.WriteLine("{0}OnSaveInstanceState ", "OnCreate called, App is Create");
            base.OnSaveInstanceState(outState);
        }
    }
}
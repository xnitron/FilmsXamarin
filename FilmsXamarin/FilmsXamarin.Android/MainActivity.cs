using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Content;
using Android.OS;
using Android.Hardware;
using System;

namespace FilmsXamarin.Droid
{
    [Activity(Label = "Films", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ISensorEventListener 
    {
        private SensorManager _sensorManager;
        private Sensor sensor;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            System.Diagnostics.Debug.WriteLine("OnCreate");

            _sensorManager = (SensorManager)GetSystemService(Context.SensorService);

            sensor = _sensorManager.GetDefaultSensor(SensorType.Light);

            _sensorManager.RegisterListener(this, sensor, Android.Hardware.SensorDelay.Game);

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

            System.Diagnostics.Debug.WriteLine("OnSaveInstanceState ", "OnCreate called, App is Create");
        }


        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            throw new NotImplementedException();
        }

        public void OnSensorChanged(SensorEvent e)
        {
            e.Sensor = _sensorManager.GetDefaultSensor(SensorType.Light);
             
            if (e.Values[0] < 20000)
            {
                Window.Attributes.ScreenBrightness = 0.2f;
            }
            else
            {
                Window.Attributes.ScreenBrightness = 0.8f;
            }
        }
    }
}
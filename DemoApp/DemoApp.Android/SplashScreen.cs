using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading;

namespace DemoApp.Droid
{
    [Activity(Label = "DemoApp", Icon = "@mipmap/icon", Theme = "@style/SplashTheme",
           MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen:Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            
            Finish();
            OverridePendingTransition(0, 0);

                
        }

    }
}
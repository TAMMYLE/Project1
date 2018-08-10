using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace Project
{
    [Activity(Label = "Project", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private Button Btn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Btn = FindViewById<Button>(Resource.Id.mainbutton);
            Btn.Click += GoToSecondPage;
        }

        private void GoToSecondPage(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SecondActivity));
            this.StartActivity(intent);
        }
    }
}


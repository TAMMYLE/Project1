
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        private Button BtnMeaning;
        private Button BtnIdeas;
        private Button BtnBack;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Second);

            BtnMeaning = FindViewById<Button>(Resource.Id.buttonMeaning);
            BtnIdeas = FindViewById<Button>(Resource.Id.buttonIdeas);
            BtnBack = FindViewById<Button>(Resource.Id.buttonBack);


            BtnMeaning.Click += GoToNextPage;
            BtnIdeas.Click += GoToNextPage;
            BtnBack.Click += GoToNextPage;
        }
        private void GoToNextPage(object sender, EventArgs e)
        {
            var mybtn = (Button)sender;

            if (mybtn == BtnBack)
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                this.StartActivity(intent);
            }

            if (mybtn == BtnMeaning)
            {
                Intent intent = new Intent(this, typeof(MeaningActivity));
                this.StartActivity(intent);
            }



            //if(mybtn == BtnArrangement)
            //{
            //    Intent intent = new Intent(this, typeof(IdeasActivity));
            //    this.StartActivity(intent);
            //}

            //if(mybtn == BtnBack)
            //{
            //    Intent intent = new Intent(this, typeof(BackActivity));
            //    this.StartActivity(intent);
            //}
        }
    }
}

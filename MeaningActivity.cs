
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
    [Activity(Label = "MeaningActivity")]
    public class MeaningActivity : Activity
    {
        private Button BtnBack;
        private ImageButton Rose;
        private ImageButton Peonies;
        private ImageButton Carnation;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Meaning);


            BtnBack = FindViewById<Button>(Resource.Id.buttonB);
            Rose = FindViewById<ImageButton>(Resource.Id.buttonRose);
            Carnation = FindViewById<ImageButton>(Resource.Id.buttonCarnation);
            Peonies = FindViewById<ImageButton>(Resource.Id.buttonPeonies);

            BtnBack.Click += GoToNextPage;
            Rose.Click += FlowersClicked;
            Carnation.Click += FlowersClicked;
            Peonies.Click += FlowersClicked;
        }
        private void GoToNextPage(object sender, EventArgs e)
        {
            var mybtn = (Button)sender;

            if (mybtn == BtnBack)
            {
                Intent intent = new Intent(this, typeof(SecondActivity));
                this.StartActivity(intent);
            }
        }
        private void FlowersClicked(object sender, EventArgs e)
        {
            var flowerbtn = (ImageButton)sender;

            if (flowerbtn == Rose)
            {
                Toast.MakeText(this, "You have looked at Rose", ToastLength.Short).Show();
            }
            else if (flowerbtn == Peonies)
            {
                Toast.MakeText(this, "You have looked at Peonies", ToastLength.Short).Show();
            }
            else if(flowerbtn == Carnation)
            {
                Toast.MakeText(this, "You have looked at Carnation", ToastLength.Short).Show();
            }
        }

    }
}
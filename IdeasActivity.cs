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
    [Activity(Label = "IdeasActivity")]
    public class IdeasActivity : Activity
    {
        private Button btnBack;
        private ListView listname;
        List<string> decorlist;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Ideas);

            btnBack = FindViewById<Button>(Resource.Id.buttonB);
            listname = FindViewById<ListView>(Resource.Id.listDecor);

            decorlist = new List<string>();
            decorlist.Add("Bridal Shower Decor'");
            decorlist.Add("Bachelorette Party Decor");
            decorlist.Add("Engagement Party Decor");
            decorlist.Add("Floral Arrangement");
            decorlist.Add("Spotlight Decor");
            decorlist.Add("Classic Wedding Decor");
            decorlist.Add("Rustic Modern Wedding");
            decorlist.Add("Summer Wedding");
            decorlist.Add("Al Freso Fall Wedding");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, decorlist);

            listname.Adapter = adapter;
            listname.ItemClick += DecorClicked;

            btnBack.Click += Back_Clicked;
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            var mybtn = (Button)sender;

            if (mybtn == btnBack)
            {
                Intent intent = new Intent(this, typeof(SecondActivity));
                this.StartActivity(intent);
            }

        }

        private void DecorClicked(object sender, AdapterView.ItemClickEventArgs e)
        {
            var selectedDecor = listname.GetItemAtPosition(e.Position).ToString();
            Toast.MakeText(ApplicationContext, selectedDecor, ToastLength.Short).Show();

        }


    }
}

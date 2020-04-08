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

namespace Assignment
{
    [Activity(Label = "DescriptionActivity")]
    public class DescriptionActivity : Activity
    {
        private GoogleMap mMap;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_description);
            // Create your application here
            setUpMap();
        }

        private void setUpMap()
        {
            if (mMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map);

            }
        }
    }
}
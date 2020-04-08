using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Java.Util;

namespace Assignment
{
    [Activity(Label = "ItemsActivity")]
    public class ItemsActivity : AppCompatActivity
    {
        RecyclerView recyclerView;

        List<string> dataSource;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.item_loader);
            // Create your application here
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.HasFixedSize = true;
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));


            InitData();

            MyAdapter adapter = new MyAdapter(dataSource);
            recyclerView.SetAdapter(adapter);


        }

        private void InitData()
        {
            //create random strings
            for(int i = 0; i<3; i++)
            {
                dataSource.Add(UUID.RandomUUID().ToString());
            }
        }
    }
}
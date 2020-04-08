using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Assignment
{
    public class MyAdapter : RecyclerView.Adapter
    {
        List<string> dataSource;

        public MyAdapter(List<string> dataSource)
        {
            this.dataSource = dataSource;
        }

        public override int ItemCount => dataSource.Count;

        public class MyViewHolder : RecyclerView.ViewHolder
        {
            public TextView textView;

            public MyViewHolder(View itemView) : base(itemView)
            {
                textView = itemView.FindViewById<TextView>(Resource.Id.text);
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyViewHolder h = (MyViewHolder)holder;
            h.textView.Text = dataSource[position];
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.activity_items, parent, false);
            return new MyViewHolder(v);
        }
    }
}
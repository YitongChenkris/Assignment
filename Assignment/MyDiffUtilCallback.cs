using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Util;
using Android.Views;
using Android.Widget;

namespace Assignment
{
    public class MyDiffUtilCallback : DiffUtil.Callback
    {
        private List<string> oldList;
        private List<string> newList;

        public MyDiffUtilCallback(List<string> oldList, List<string> newList)
        {
            this.oldList = oldList;
            this.newList = newList;

        }
        public override int NewListSize => newList.Count;

        public override int OldListSize => oldList.Count;

        public override bool AreContentsTheSame(int oldItemPosition, int newItemPosition)
        {
            return oldItemPosition == newItemPosition;
        }

        public override bool AreItemsTheSame(int oldItemPosition, int newItemPosition)
        {
            return oldList[oldItemPosition] == newList[newItemPosition];
        }
    }
}
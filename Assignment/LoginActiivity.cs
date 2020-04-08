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
    [Activity(Label = "@string/app_name", MainLauncher = false)]
    public class LoginActiivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_login);
            //btnRegister = FindViewById<Button>(Resource.Id.notregistered);
            //btnRegister.Click += BtnRegister_Clicked;
            

            Button btnRegister = FindViewById<Button>(Resource.Id.notregistered);
            btnRegister.Click += (s, e) =>
            {
                Intent registerActivity = new Intent(this, typeof(RegisterActivity));
                StartActivity(registerActivity);
            }; 

        }

        private void BtnRegister_Clicked(object sender, EventArgs e)
        {
            StartActivity(new Intent(this, typeof(RegisterActivity)));
        }
    }
}
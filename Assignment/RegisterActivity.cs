using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;

namespace Assignment
{
    [Activity(Label = "RegisterActivity", MainLauncher = true)]
    public class RegisterActivity : Activity
    {
        EditText txtusername, txtfName, txtlName, txtphone, txtemail, txtcountry, txtPass, txtCpass;
        private Button btnRegister;
        string url = "http://192.168.8.100/Assignment/register.php";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_register);

            // Create your application here
            btnRegister = FindViewById<Button>(Resource.Id.register);
            btnRegister.Click += BtnRegister_Clicked;
        }

        void BtnRegister_Clicked(Object sender, EventArgs e)
        {
            txtusername = FindViewById<EditText>(Resource.Id.username);
            txtfName = FindViewById<EditText>(Resource.Id.firstName);
            txtlName = FindViewById<EditText>(Resource.Id.lastname);
            txtphone = FindViewById<EditText>(Resource.Id.phone);
            txtemail = FindViewById<EditText>(Resource.Id.email);
            txtcountry = FindViewById<EditText>(Resource.Id.country);
            txtPass = FindViewById<EditText>(Resource.Id.pass);
            txtCpass = FindViewById<EditText>(Resource.Id.cPass);
            WebClient client = new WebClient();
            Uri uri = new Uri(url);
            NameValueCollection parameters = new NameValueCollection();

            parameters.Add("username", txtusername.Text);
            parameters.Add("fistName", txtfName.Text);
            parameters.Add("lastName", txtlName.Text);
            parameters.Add("emailAddress", txtemail.Text);
            parameters.Add("phone", txtphone.Text);
            parameters.Add("country", txtcountry.Text);
            parameters.Add("password", txtPass.Text);

            client.UploadValuesAsync(uri, parameters);

            client.UploadValuesCompleted += client_UploadValuesCompleted;
            
        }

        private void client_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            StartActivity(new Intent(this, typeof(LauncherActivity)));
            //Toast.MakeText(this, e.ToString, Toast.Lengthlong()).show();
        }
    }
}
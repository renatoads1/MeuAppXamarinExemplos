using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppQuantidade.XamarinForms.Controles.NavegadorControler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly:Xamarin.Forms.Dependency(typeof(AppQuantidade.Droid.BaseUrl_Android))]
namespace AppQuantidade.Droid
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/wwwbot/index.html";
        }
    }
}
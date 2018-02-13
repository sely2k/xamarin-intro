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
using DependencyInjectionDemo.Droid.Model;
using DependencyInjectionDemo.Model;

[assembly: Xamarin.Forms.Dependency(typeof(Hello))]

namespace DependencyInjectionDemo.Droid.Model
{
    public class Hello : IHello
    {
        public string SayHello()
        {
            return "Hello Droid";
        }
    }
}
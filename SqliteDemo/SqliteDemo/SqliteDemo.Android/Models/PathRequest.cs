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
using SqliteDemo.Droid.Models;
using SqliteDemo.Models;

[assembly: Xamarin.Forms.Dependency(typeof(PathRequest))]
namespace SqliteDemo.Droid.Models
{
    public class PathRequest : IPathRequest
    {
        public string GetDocumentPath()
        {
            return System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        }
    }
}
using SqliteDemo.Droid.Models;
using SqliteDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly: Xamarin.Forms.Dependency(typeof(PathRequest))]
namespace SqliteDemo.Droid.Models
{
    public class PathRequest : IPathRequest
    {
        public string GetDocumentPath()
        {
            return Windows.Storage.ApplicationData.Current.LocalFolder.Path;
        }
    }
}
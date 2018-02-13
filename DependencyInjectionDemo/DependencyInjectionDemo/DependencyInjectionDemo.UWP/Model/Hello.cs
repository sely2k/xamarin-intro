using DependencyInjectionDemo.Model;
using DependencyInjectionDemo.UWP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(Hello))]
namespace DependencyInjectionDemo.UWP.Model
{
    public class Hello : IHello
    {
        public string SayHello()
        {
            return "RIP Windows Phone";
        }
    }
}

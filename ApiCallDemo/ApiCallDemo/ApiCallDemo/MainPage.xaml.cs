using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApiCallDemo
{
	public partial class MainPage : ContentPage
	{
        #region api url
        public string ApiUrl { get; set; } = "http://**NOMEDELWEBSITE**.azurewebsites.net";
        #endregion

        public MainPage()
		{
			InitializeComponent();

            btnCallAutorest.Clicked += async delegate
            {
                var client = new ApiCallDemo.resclient.MyAPI(new Uri(ApiUrl));
                var values = await client.ApiValuesGetWithHttpMessagesAsync();
                Console.WriteLine(string.Join(",", values.Body));
            
            };

            btnCallApi.Clicked += async delegate
            {
                string Uri = ApiUrl+"/api/values";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(Uri);
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);

            };

        }

    }
}

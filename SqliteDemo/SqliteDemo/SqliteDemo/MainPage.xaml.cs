using SqliteDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SqliteDemo
{
	public partial class MainPage : ContentPage
	{
        public string DbPath { get; set; }
        public MainPage()
		{
			InitializeComponent();
            var path = DependencyService.Get<IPathRequest>().GetDocumentPath();
            DbPath = Path.Combine(path, "db_sqlnet.db");

            try
            {
                var status = Sqlite.createDatabase(DbPath);

                txtStatus.Text = status;


                txtItems.Text = $"ci sono {Sqlite.findNumberRecords(DbPath)} righe";
            }
            catch(Exception ex)
            {
                txtStatus.Text = ex.Message;
            }
            

           

        }

        void OnAddButtonClicked(object sender, EventArgs args)
        {

            var insertAction= Sqlite.insertUpdateData(new Person() { FirstName = "test" }, DbPath);

            txtItems.Text = $"ci sono {Sqlite.findNumberRecords(DbPath)} righe";
        }
    }
}

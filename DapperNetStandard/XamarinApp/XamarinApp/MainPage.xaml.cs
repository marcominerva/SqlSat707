using DapperNetStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
	public partial class MainPage : ContentPage
	{
        private const string ConnectionString = @"";

        public MainPage()
		{
			InitializeComponent();
		}

        private async void FindPlacesButton_Clicked(object sender, EventArgs e)
        {
            var db = new Places(ConnectionString);
            var data = await db.SearchAsync(QueryTextBox.Text);
            PlacesListView.ItemsSource = data;
        }
    }
}

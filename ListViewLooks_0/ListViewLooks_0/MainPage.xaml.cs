using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewLooks_0
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var names = new List<string>
            { "Jaime", "Steph", "Sophie", "Denise", "Caroline" };

            // create 2 ListViews:
            // items are highlited when selected on myListView2
            // and not on myListView
            myListView.ItemsSource = names;
            myListView2.ItemsSource = names;

            //myListView.HeightRequest(40 * 5);
            //myListView.MinimumHeightRequest(200);
            //myListView.MinimumHeightRequest(40 * 5);
            
        }

        private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // To deselect the item (otherwise it's highlighted when clicked on)
            myListView.SelectedItem = null;
        }
    }
}

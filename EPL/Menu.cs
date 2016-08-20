using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;

namespace EPL {
	class Menu : MasterDetailPage {
		public Menu() {
			// Create ListView for the master page.
			ListView listView = new ListView {
			//	ItemsSource = 
			};

			 // Create the master page with the ListView.
			this.Master = new ContentPage {
				Title = "Color List",       // Title required!
				Content = new StackLayout {
					Children = {
						listView
					}
				}
			};

			Canvas detailPage = new Canvas();
			this.Detail = detailPage;
		}
	}
}

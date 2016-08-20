using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;

namespace EPL {
	public class Canvas : ContentPage {
		public Canvas() {
			Content = new StackLayout {
				BackgroundColor = Color.FromRgb(246,246,246),
				Padding = new Thickness(170, 300, 0, 0),
				Children = {
					new Label { Text = "캔버스" }


				}

			};
		}

	}

}



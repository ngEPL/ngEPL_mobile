using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EPL {
	public partial class sideList : ContentPage {
		public sideList() {
			InitializeComponent();
			listView.ItemsSource = Data.blockList;
		}
	}
}


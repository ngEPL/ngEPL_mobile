using System;

using Xamarin.Forms;

//사이드바 control 페이지

namespace EPL {
	public class MasterPage : MasterDetailPage {
		public MasterPage() {
			Title = "Blocks";


			//Sidebar
			Master = new sideList();


			//Main Page
			Detail = new Canvas();

		}
	}
}


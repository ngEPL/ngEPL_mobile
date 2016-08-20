using System;

using Xamarin.Forms;

namespace EPL {
	public class MasterPage : MasterDetailPage {
		public MasterPage() {
			Title = "Blocks";

			Master = new sideList();
			Detail = new Canvas();

		}
	}
}


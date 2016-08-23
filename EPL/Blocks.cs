using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace EPL {


	public class Blocks {
		public string Name { get; set; }
		public string Category { get; set; }
		public int Height { get; set; }
		public Blocks(){
		}

	}

	public class GroupedBlocks : ObservableCollection<Blocks> {
		public string LongName { get; set; }
		public string ShortName { get; set; }
	}

	//public class PersonDataTemplateSelector : DataTemplateSelector {
	//	public DataTemplate ValidTemplate { get; set; }
	//	public DataTemplate InvalidTemplate { get; set; }

	//	protected override DataTemplate OnSelectTemplate(object item, BindableObject container) {
	//		return item.Blocks.Category == "일반" ? ValidTemplate : InvalidTemplate;
	//	}
	//}
}




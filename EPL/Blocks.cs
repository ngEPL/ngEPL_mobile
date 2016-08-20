using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EPL {


	public class Blocks {
		public string Name { get; set; }
		public string Category { get; set; }
		public int Height { get; set; }

	}

	public class Data {
		#region blockList

		public static ObservableCollection<Blocks> blockList = new ObservableCollection<Blocks>{
			new Blocks { Name="loop", Category="반복", Height=130 },
			new Blocks { Name="if", Category="조건", Height=130 },
			new Blocks { Name="elif", Category="조건", Height=200 },
			new Blocks { Name="sound", Category="일반", Height=60 },
			new Blocks { Name="move", Category="일반", Height=60 },
			new Blocks { Name="turn", Category="일반", Height=60 }
		};
		#endregion
	}




}
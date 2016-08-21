using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EPL {


	public class Blocks {
		public string Name { get; set; }
		public string Category { get; set; }
		public int Type { get; set; }

	}

	public class Data {
		#region blockList

		public static ObservableCollection<Blocks> blockList = new ObservableCollection<Blocks>{
			new Blocks { Name="loop", Category="반복", Type=2 },
			new Blocks { Name="i_f", Category="조건", Type=2 },
			new Blocks { Name="elif", Category="조건", Type=3 },
			new Blocks { Name="sound", Category="일반", Type=1 },
			new Blocks { Name="move", Category="일반", Type=1 },
			new Blocks { Name="turn", Category="일반", Type=1 }
		};
		#endregion
	}




}
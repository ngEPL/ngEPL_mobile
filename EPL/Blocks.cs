using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EPL {
	public class Data {
		#region BlockList
		public static ObservableCollection<Blocks> BlockList = new ObservableCollection<Blocks>{
			new Blocks { BlockName="loop", Category="loop" },
			new Blocks { BlockName="if", Category="if" },
			new Blocks { BlockName="elif", Category="if" },
			new Blocks { BlockName="sound", Category="default" },
			new Blocks { BlockName="move", Category="default" },
			new Blocks { BlockName="turn", Category="dafault" },
		};
		#endregion
	}

	public class Blocks {
		public string BlockName { get; set; }
		public string Category { get; set; }
	}


}
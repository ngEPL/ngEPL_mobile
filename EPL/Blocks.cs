using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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




	////블록 리스트
	//public class Data {


	//	#region inputList
	//	public static ObservableCollection<Blocks> inputList = new ObservableCollection<Blocks>{
	//		new Blocks { Name="block_loop", Category="반복",Height =124 },
			                 
	//		new Blocks { Name="block_if", Category="조건", Height=124 },
	//		new Blocks { Name="block_elif", Category="조건", Height=212 },
	//		new Blocks { Name="block_sound", Category="일반", Height=60 },
	//		new Blocks { Name="block_move", Category="일반", Height=60 },
	//		new Blocks { Name="block_turn", Category="일반", Height=60 },
	//		new Blocks { Name="block_start_click", Category="시작", Height=72 },
	//		new Blocks { Name="block_start_press", Category="시작", Height=72 }
	//	};

	//	#endregion

	//}
}




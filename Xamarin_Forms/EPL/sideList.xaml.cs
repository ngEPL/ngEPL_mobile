using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace EPL {
	public partial class sideList : ContentPage {
		private ObservableCollection<GroupedBlocks> grouped { get; set; }
		public sideList() {
			InitializeComponent();




			grouped = new ObservableCollection<GroupedBlocks>();


			var Group1 = new GroupedBlocks() { LongName = "반복" };
			var Group2 = new GroupedBlocks() { LongName = "조건" };
			var Group3 = new GroupedBlocks() { LongName = "이동" };
			var Group4 = new GroupedBlocks() { LongName = "시작" };

			//Sample blocks
			Group1.Add(new Blocks { Name = "block_loop", Category = "반복", Height = 124 });
			Group2.Add(new Blocks { Name = "block_if", Category = "조건", Height = 124 });
			Group2.Add(new Blocks { Name = "block_elif", Category = "조건", Height = 212 });
			Group3.Add(new Blocks { Name = "block_move", Category = "이동", Height = 60 });
			Group3.Add(new Blocks { Name = "block_turn", Category = "이동", Height = 60 });
			Group4.Add(new Blocks { Name = "block_start_click", Category = "시작", Height = 72 });
			Group4.Add(new Blocks { Name = "block_start_press", Category = "시작", Height = 72 });

			//Add group
			grouped.Add(Group1);
			grouped.Add(Group2);
			grouped.Add(Group3);
			grouped.Add(Group4);

			//Freeing image size
			blockList.HasUnevenRows = true;

			//Make unvisible separator
			blockList.SeparatorVisibility = SeparatorVisibility.None;

			blockList.ItemsSource = grouped;
		}

	}
}


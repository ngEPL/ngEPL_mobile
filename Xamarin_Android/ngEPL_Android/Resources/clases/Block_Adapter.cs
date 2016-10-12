using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ngEPL_Android {
	
	class Block_Adapter : BaseAdapter<Block_Assets> {

		List<Block_Assets> items;

		Activity context;

		public Block_Adapter(Activity context, List<Block_Assets> items)
			: base() {
			this.context = context;
			this.items = items;
		}



		public override long GetItemId(int position) {
			return position;
		}


		public override View GetView(int position, View convertView, ViewGroup parent) {
			var item = items[position];

			View view = convertView;

			if (view == null)
				view = context.LayoutInflater.Inflate(Resource.Layout.item_permission, null);



			int id_img = context.Resources.GetIdentifier(item.Icon, "drawable", context.PackageName);
			view.FindViewById<ImageView>(Resource.Id.imvIcon).SetImageResource(id_img);

			return view;
		}

		public override int Count {
			get {
				return items.Count;
			}
		}




		public override Block_Assets this[int index] {
			get {
				return items[index];
			}
		}




		public override void NotifyDataSetChanged() {
			base.NotifyDataSetChanged();
		}


		public void add(Block_Assets p) {
			items.Add(p);
			NotifyDataSetChanged();
		}

		public void remove(int index) {
			items.RemoveAt(index);
			NotifyDataSetChanged();
		}


		public Block_Assets Search(int index) {
			return items[index];
		}



	}
}


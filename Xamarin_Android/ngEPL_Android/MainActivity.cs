using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace ngEPL_Android {
	
	[Activity(Label = "EPL", MainLauncher = true)]


	public class MainActivity : Activity {
		
		List<Block_Assets> Permission = new List<Block_Assets>();
		ListView lvCanvas;
		Block_Adapter adap_Permission;


		List<Block_Assets> Block_List = new List<Block_Assets>();
		ListView lvBlock_List;
		Block_Adapter adap_Block_List;

		protected override void OnCreate(Bundle bundle) {
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);




			/*임의블록*/
			Block_List.Add(new Block_Assets("block1", "ic_2"));
			Block_List.Add(new Block_Assets("block2", "ic_3"));
			Block_List.Add(new Block_Assets("block3", "ic_4"));




			/*왼쪽 리스트뷰*/
			lvCanvas = FindViewById<ListView>(Resource.Id.lvCanvas);

			adap_Permission = new Block_Adapter(this, Permission);

			lvCanvas.Adapter = adap_Permission;

			lvCanvas.ItemLongClick += (s, args) => {

				ClipData data = ClipData.NewPlainText("canvas", args.Position.ToString());

				MyDragShadowBuilder my_shadown_screen = new MyDragShadowBuilder(args.View);

				args.View.StartDrag(data, my_shadown_screen, null, 0);

			};

			lvCanvas.Drag += (s, args) => {

				switch (args.Event.Action) {

					case DragAction.Started:
					args.Handled = true;
					break;


					case DragAction.Entered:
					args.Handled = true;
					break;


					case DragAction.Exited:
					args.Handled = true;
					break;


					case DragAction.Drop:
					args.Handled = true;

					if (args.Event.ClipDescription.Label.Equals("Block_List")) {

						int posicion = int.Parse(args.Event.ClipData.GetItemAt(0).Text);

						adap_Permission.add(adap_Block_List.Search(posicion));


					}

					break;

					case DragAction.Ended:
					args.Handled = true;
					break;
				}


			};

			//TODO : "같은 ListView일때" 추가

			/*오른쪽 리스트뷰*/
			lvBlock_List = FindViewById<ListView>(Resource.Id.lvBlock_List);

			adap_Block_List = new Block_Adapter(this, Block_List);

			lvBlock_List.Adapter = adap_Block_List;


			lvBlock_List.ItemLongClick += (s, args) => {

				ClipData data = ClipData.NewPlainText("Block_List", args.Position.ToString());

				MyDragShadowBuilder my_shadown_screen = new MyDragShadowBuilder(args.View);

				args.View.StartDrag(data, my_shadown_screen, null, 0);

			};


			lvBlock_List.Drag += (s, args) => {

				switch (args.Event.Action) {

					case DragAction.Started:
					args.Handled = true;
					break;


					case DragAction.Entered:
					args.Handled = true;
					break;


					case DragAction.Exited:
					args.Handled = true;
					break;

					case DragAction.Drop:
					args.Handled = true;

					if (args.Event.ClipDescription.Label.Equals("canvas")) {

						int posicion = int.Parse(args.Event.ClipData.GetItemAt(0).Text);

						adap_Permission.remove(posicion);
					}

					break;
						
					case DragAction.Ended:
					args.Handled = true;
					break;
				}
			};
		}

		//TODO : "같은 ListView일때" 추가



		/*  드래그할때 생기는 그림자  */
		private class MyDragShadowBuilder : View.DragShadowBuilder {
			private Drawable shadow;

			public MyDragShadowBuilder(View v) : base(v) {
				
				v.DrawingCacheEnabled = true;
				Bitmap bm = v.DrawingCache;
				shadow = new BitmapDrawable(bm);
				shadow.SetColorFilter(Color.ParseColor("#111111"), PorterDuff.Mode.Multiply);


			}

			public override void OnProvideShadowMetrics(Point size, Point touch) {
				int width = View.Width;
				int height = View.Height;
				shadow.SetBounds(0, 0, width, height);
				size.Set(width, height);
				touch.Set(width / 2, height / 2);

			}

			public override void OnDrawShadow(Canvas canvas) {
				base.OnDrawShadow(canvas);
				shadow.Draw(canvas);
			}
		}

	}
}



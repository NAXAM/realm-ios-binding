using System;
using Foundation;
using NxRealm;
using UIKit;
using Masonry;
using CoreGraphics;

namespace RealmQs
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var label = new UILabel();
            label.Text = "Realm Sample";
            label.Font = UIFont.SystemFontOfSize(32);
            label.TextColor = UIColor.Magenta;

            View.AddSubview(label);

            label.MakeConstraints(mk =>
            {
                mk.CenterX.EqualTo(View.CenterX());
                mk.Top.EqualTo(View.TopAnchor).Offset(144);
            });

            var btn = new UIButton(new CGRect(0, 0, 320, 44));
			btn.SetTitle("Insert Todos", UIControlState.Normal);
            btn.SetTitleColor(UIColor.Magenta, UIControlState.Normal);
            btn.TouchUpInside += delegate
            {
                var realm = RLMRealm.DefaultRealm();

                realm.TransactionWithBlock(() =>
                {
                    realm.AddObject(new TodoModel
                    {
                        Title = "Sample 1",
                        Done = false
                    });

                    realm.AddObject(new TodoModel
                    {
                        Title = "Sample 2",
                        Done = false
                    });
                });
            };
            View.AddSubview(btn);
            btn.MakeConstraints(mk => {
                mk.CenterX.EqualTo(label.CenterX());
				mk.Top.EqualTo(label.Bottom()).Offset(40);
            });

			var btn2 = new UIButton(new CGRect(0, 0, 320, 44));
			btn2.SetTitle("Query Todos", UIControlState.Normal);
            btn2.SetTitleColor(UIColor.Magenta, UIControlState.Normal);
			btn2.TouchUpInside += delegate
			{
				var realm = RLMRealm.DefaultRealm();

                var objs = realm.AllObjects(nameof(TodoModel));

                System.Diagnostics.Debug.WriteLine(objs);
			};
			View.AddSubview(btn2);
			btn2.MakeConstraints(mk =>
			{
				mk.CenterX.EqualTo(btn.CenterX());
				mk.Top.EqualTo(btn.Bottom()).Offset(16);
			});
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    [Register(nameof(TodoModel))]
    public class TodoModel : RLMObject
    {
        [Export("done", ObjCRuntime.ArgumentSemantic.Assign)]
        public bool Done { get; set; }

        [Export("title", ObjCRuntime.ArgumentSemantic.Strong)]
        public string Title { get; set; }
    }
}

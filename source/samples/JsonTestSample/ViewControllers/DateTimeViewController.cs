using System;
using System.CodeDom.Compiler;

#if __UNIFIED__
using Foundation;
using UIKit;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif

namespace JsonTestSample
{
	partial class DateTimeViewController : UIViewController
	{
		public DateTimeViewController (IntPtr handle) : base (handle)
		{
		}

		public override async void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var result = await JsonTest.Client.FetchDateTime (true);
			DateResult.Text = result.ToLongDateString ();
			TimeResult.Text = result.ToLongTimeString ();
		}
	}
}

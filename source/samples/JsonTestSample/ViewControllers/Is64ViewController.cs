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
	partial class Is64ViewController : UIViewController
	{
		public Is64ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Is64Result.Text = IntPtr.Size == 8 ? "Yes" : "No";
		}
	}
}

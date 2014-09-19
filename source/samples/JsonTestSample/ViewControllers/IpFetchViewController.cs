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
	partial class IpFetchViewController : UIViewController
	{
		public IpFetchViewController (IntPtr handle) : base (handle)
		{
		}

		public override async void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var ipAddress = await JsonTest.Client.FetchIp ();
			ResultText.Text = ipAddress.ToString ();
		}
	}
}

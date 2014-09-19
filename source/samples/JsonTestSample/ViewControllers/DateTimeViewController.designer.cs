// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
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
	[Register ("DateTimeViewController")]
	partial class DateTimeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel DateResult { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TimeResult { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (DateResult != null) {
				DateResult.Dispose ();
				DateResult = null;
			}
			if (TimeResult != null) {
				TimeResult.Dispose ();
				TimeResult = null;
			}
		}
	}
}

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
	[Register ("Is64ViewController")]
	partial class Is64ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Is64Result { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Is64Result != null) {
				Is64Result.Dispose ();
				Is64Result = null;
			}
		}
	}
}

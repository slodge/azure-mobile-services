// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SixSteps.UI.Touch.Views
{
	[Register ("HomeView")]
	partial class HomeView
	{
		[Outlet]
		MonoTouch.UIKit.UITableView Table { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Edit { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton Go { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Table != null) {
				Table.Dispose ();
				Table = null;
			}

			if (Edit != null) {
				Edit.Dispose ();
				Edit = null;
			}

			if (Go != null) {
				Go.Dispose ();
				Go = null;
			}
		}
	}
}

// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;

namespace NSImageNameSample
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSTextField imageLabel { get; set; }

		[Outlet]
		MonoMac.AppKit.NSImageView image { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton previousButton { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton nextButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imageLabel != null) {
				imageLabel.Dispose ();
				imageLabel = null;
			}

			if (image != null) {
				image.Dispose ();
				image = null;
			}

			if (previousButton != null) {
				previousButton.Dispose ();
				previousButton = null;
			}

			if (nextButton != null) {
				nextButton.Dispose ();
				nextButton = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}

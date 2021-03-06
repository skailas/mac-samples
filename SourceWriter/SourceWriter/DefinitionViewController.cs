// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using AppKit.TextKit.Formatter;

namespace SourceWriter
{
	/// <summary>
	/// Controls the window used to display information about the selected keyword in the editor.
	/// </summary>
	/// <remarks>This section uses Data Binding and Key-Value Coding to bind
	/// preference values to UI Controls on the Storyboard. For more information
	/// see: http://developer.xamarin.com/guides/mac/application_fundamentals/databinding/</remarks>
	public partial class DefinitionViewController : NSViewController
	{
		#region Private Variables
		/// <summary>
		/// The keyword being defined.
		/// </summary>
		private string _keyword = "";

		/// <summary>
		/// Information about the keyword being defined.
		/// </summary>
		private KeywordDescriptor _keywordInfo = new KeywordDescriptor ();

		/// <summary>
		/// The View Controller presenting the definition
		/// </summary>
		private NSViewController _presentor;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the keyword.
		/// </summary>
		/// <value>The keyword.</value>
		public string Keyword {
			get { return _keyword; }
			set { _keyword = value; }
		}

		/// <summary>
		/// Gets or sets the keyword info.
		/// </summary>
		/// <value>The keyword info.</value>
		public KeywordDescriptor KeywordInfo {
			get { return _keywordInfo; }
			set { _keywordInfo = value; }
		}

		/// <summary>
		/// Gets or sets the presentor.
		/// </summary>
		/// <value>The presentor.</value>
		public NSViewController Presentor {
			get { return _presentor; }
			set { _presentor = value; }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="SourceWriter.DefinitionViewController"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public DefinitionViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Called before the view is displayed to the user.
		/// </summary>
		public override void ViewWillAppear ()
		{
			base.ViewWillAppear ();

			// Display values
			DefinitionTitle.StringValue = string.Format("{0}: {1}", KeywordInfo.Type, Keyword);
			DefinitionTitle.TextColor = KeywordInfo.Color;
			DefinitionDescription.StringValue = KeywordInfo.Tooltip;
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Closes the sheet.
		/// </summary>
		private void CloseSheet() {
			Presentor.DismissViewController (this);
		}
		#endregion

		#region Actions
		/// <summary>
		/// Respond to the user clicking the OK button by closing the definition sheet.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void CloseDefinition (Foundation.NSObject sender) {
			CloseSheet();
		}
		#endregion
	}
}

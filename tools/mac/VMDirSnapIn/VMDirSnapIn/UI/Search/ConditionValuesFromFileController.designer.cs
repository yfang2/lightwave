// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace VMDirSnapIn.UI
{
	[Register ("ConditionValuesFromFileController")]
	partial class ConditionValuesFromFileController
	{
		[Outlet]
		AppKit.NSComboBox AttributeComboBox { get; set; }

		[Outlet]
		AppKit.NSComboBox ConditionComboBox { get; set; }

		[Outlet]
		AppKit.NSTextField ValuesTextField { get; set; }

		[Action ("OnApply:")]
		partial void OnApply (Foundation.NSObject sender);

		[Action ("OnBrowse:")]
		partial void OnBrowse (Foundation.NSObject sender);

		[Action ("OnCancel:")]
		partial void OnCancel (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AttributeComboBox != null) {
				AttributeComboBox.Dispose ();
				AttributeComboBox = null;
			}

			if (ConditionComboBox != null) {
				ConditionComboBox.Dispose ();
				ConditionComboBox = null;
			}

			if (ValuesTextField != null) {
				ValuesTextField.Dispose ();
				ValuesTextField = null;
			}
		}
	}
}

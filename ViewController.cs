using System;

using AppKit;
using Foundation;

namespace ChromeSpeechProxy
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.

            OnClickStop(null);

		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        partial void OnClickStart (Foundation.NSObject sender)
        {
            _mButtonStart.Enabled = false;
            _mButtonStop.Enabled = true;
        }

        partial void OnClickStop (Foundation.NSObject sender)
        {
            _mButtonStart.Enabled = true;
            _mButtonStop.Enabled = false;
        }
	}
}

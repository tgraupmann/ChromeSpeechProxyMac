// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ChromeSpeechProxy
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSButtonCell _mButtonCloseChromeProxyTab { get; set; }

        [Outlet]
        AppKit.NSButtonCell _mButtonOpenChromeProxyTab { get; set; }

        [Outlet]
        AppKit.NSButtonCell _mButtonStart { get; set; }

        [Outlet]
        AppKit.NSButtonCell _mButtonStop { get; set; }

        [Outlet]
        AppKit.NSTextField _mTextChromeConnected { get; set; }

        [Outlet]
        AppKit.NSTextField _mTextPort { get; set; }

        [Outlet]
        AppKit.NSTextField _mTextStatus { get; set; }

        [Outlet]
        AppKit.NSTextField _mTextUnityConnected { get; set; }

        [Action ("OnClickCloseChromeProxyTab:")]
        partial void OnClickCloseChromeProxyTab (Foundation.NSObject sender);

        [Action ("OnClickOpenChromeProxyTab:")]
        partial void OnClickOpenChromeProxyTab (Foundation.NSObject sender);

        [Action ("OnClickStart:")]
        partial void OnClickStart (Foundation.NSObject sender);

        [Action ("OnClickStop:")]
        partial void OnClickStop (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (_mButtonCloseChromeProxyTab != null) {
                _mButtonCloseChromeProxyTab.Dispose ();
                _mButtonCloseChromeProxyTab = null;
            }

            if (_mButtonOpenChromeProxyTab != null) {
                _mButtonOpenChromeProxyTab.Dispose ();
                _mButtonOpenChromeProxyTab = null;
            }

            if (_mButtonStart != null) {
                _mButtonStart.Dispose ();
                _mButtonStart = null;
            }

            if (_mButtonStop != null) {
                _mButtonStop.Dispose ();
                _mButtonStop = null;
            }

            if (_mTextChromeConnected != null) {
                _mTextChromeConnected.Dispose ();
                _mTextChromeConnected = null;
            }

            if (_mTextPort != null) {
                _mTextPort.Dispose ();
                _mTextPort = null;
            }

            if (_mTextStatus != null) {
                _mTextStatus.Dispose ();
                _mTextStatus = null;
            }

            if (_mTextUnityConnected != null) {
                _mTextUnityConnected.Dispose ();
                _mTextUnityConnected = null;
            }
        }
    }
}

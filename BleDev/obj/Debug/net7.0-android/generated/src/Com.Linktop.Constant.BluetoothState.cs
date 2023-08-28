using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Constant {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']"
	[global::Android.Runtime.Register ("com/linktop/constant/BluetoothState", DoNotGenerateAcw=true)]
	public sealed partial class BluetoothState : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']/field[@name='BLE_CLOSED']"
		[Register ("BLE_CLOSED")]
		public const int BleClosed = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']/field[@name='BLE_CONNECTED_DEVICE']"
		[Register ("BLE_CONNECTED_DEVICE")]
		public const int BleConnectedDevice = (int) 103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']/field[@name='BLE_CONNECTING_DEVICE']"
		[Register ("BLE_CONNECTING_DEVICE")]
		public const int BleConnectingDevice = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']/field[@name='BLE_NOTIFICATION_DISABLED']"
		[Register ("BLE_NOTIFICATION_DISABLED")]
		public const int BleNotificationDisabled = (int) 105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']/field[@name='BLE_NOTIFICATION_ENABLED']"
		[Register ("BLE_NOTIFICATION_ENABLED")]
		public const int BleNotificationEnabled = (int) 104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']/field[@name='BLE_OPENED_AND_DISCONNECT']"
		[Register ("BLE_OPENED_AND_DISCONNECT")]
		public const int BleOpenedAndDisconnect = (int) 101;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/constant/BluetoothState", typeof (BluetoothState));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal BluetoothState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.constant']/class[@name='BluetoothState']/constructor[@name='BluetoothState' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothState () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/ThermometerTask", DoNotGenerateAcw=true)]
	public sealed partial class ThermometerTask : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']/field[@name='l']"
		[Register ("l")]
		public static IList<byte>? L {
			get {
				const string __id = "l.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/ThermometerTask", typeof (ThermometerTask));

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

		internal ThermometerTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']/constructor[@name='ThermometerTask' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.OnBLEService']]"
		[Register (".ctor", "(Lcom/linktop/whealthService/OnBLEService;)V", "")]
		public unsafe ThermometerTask (global::Com.Linktop.WhealthService.OnBLEService? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/linktop/whealthService/OnBLEService;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public unsafe bool A ()
		{
			const string __id = "a.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='com.linktop.infs.OnScanTempListener']]"
		[Register ("a", "(Landroid/bluetooth/BluetoothDevice;Lcom/linktop/infs/OnScanTempListener;)V", "")]
		public unsafe void A (global::Android.Bluetooth.BluetoothDevice? p0, global::Com.Linktop.Infs.IOnScanTempListener? p1)
		{
			const string __id = "a.(Landroid/bluetooth/BluetoothDevice;Lcom/linktop/infs/OnScanTempListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnThermInfoListener']]"
		[Register ("a", "(Lcom/linktop/infs/OnThermInfoListener;)V", "")]
		public unsafe void A (global::Com.Linktop.Infs.IOnThermInfoListener? p0)
		{
			const string __id = "a.(Lcom/linktop/infs/OnThermInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.linktop.whealthService.util.ParseByte'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("a", "(Lcom/linktop/whealthService/util/ParseByte;Landroid/bluetooth/BluetoothDevice;)V", "")]
		public unsafe void A (global::Com.Linktop.WhealthService.Util.ParseByte? p0, global::Android.Bluetooth.BluetoothDevice? p1)
		{
			const string __id = "a.(Lcom/linktop/whealthService/util/ParseByte;Landroid/bluetooth/BluetoothDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ThermometerTask']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public unsafe void A (string? p0)
		{
			const string __id = "a.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

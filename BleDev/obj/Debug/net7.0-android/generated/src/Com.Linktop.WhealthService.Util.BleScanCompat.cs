using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='BleScanCompat']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/util/BleScanCompat", DoNotGenerateAcw=true)]
	public sealed partial class BleScanCompat : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='BleScanCompat.BleScanCallback']"
		[Register ("com/linktop/whealthService/util/BleScanCompat$BleScanCallback", "", "Com.Linktop.WhealthService.Util.BleScanCompat/IBleScanCallbackInvoker")]
		public partial interface IBleScanCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='BleScanCompat.BleScanCallback']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register ("a", "(Landroid/bluetooth/BluetoothDevice;I[B)V", "GetA_Landroid_bluetooth_BluetoothDevice_IarrayBHandler:Com.Linktop.WhealthService.Util.BleScanCompat/IBleScanCallbackInvoker, BleDev")]
			void A (global::Android.Bluetooth.BluetoothDevice? p0, int p1, byte[]? p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='BleScanCompat.BleScanCallback']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("a", "(I)V", "GetA_IHandler:Com.Linktop.WhealthService.Util.BleScanCompat/IBleScanCallbackInvoker, BleDev")]
			void A (int p0);

		}

		[global::Android.Runtime.Register ("com/linktop/whealthService/util/BleScanCompat$BleScanCallback", DoNotGenerateAcw=true)]
		internal partial class IBleScanCallbackInvoker : global::Java.Lang.Object, IBleScanCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/util/BleScanCompat$BleScanCallback", typeof (IBleScanCallbackInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IBleScanCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBleScanCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.whealthService.util.BleScanCompat.BleScanCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBleScanCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB;
#pragma warning disable 0169
			static Delegate GetA_Landroid_bluetooth_BluetoothDevice_IarrayBHandler ()
			{
				if (cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB == null)
					cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_A_Landroid_bluetooth_BluetoothDevice_IarrayB);
				return cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB;
			}

			static void n_A_Landroid_bluetooth_BluetoothDevice_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.BleScanCompat.IBleScanCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.A (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			IntPtr id_a_Landroid_bluetooth_BluetoothDevice_IarrayB;
			public unsafe void A (global::Android.Bluetooth.BluetoothDevice? p0, int p1, byte[]? p2)
			{
				if (id_a_Landroid_bluetooth_BluetoothDevice_IarrayB == IntPtr.Zero)
					id_a_Landroid_bluetooth_BluetoothDevice_IarrayB = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/bluetooth/BluetoothDevice;I[B)V");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_bluetooth_BluetoothDevice_IarrayB, __args);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate? cb_a_I;
#pragma warning disable 0169
			static Delegate GetA_IHandler ()
			{
				if (cb_a_I == null)
					cb_a_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_A_I);
				return cb_a_I;
			}

			static void n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.BleScanCompat.IBleScanCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_I;
			public unsafe void A (int p0)
			{
				if (id_a_I == IntPtr.Zero)
					id_a_I = JNIEnv.GetMethodID (class_ref, "a", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_I, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/util/BleScanCompat", typeof (BleScanCompat));

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

		internal BleScanCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='BleScanCompat']/constructor[@name='BleScanCompat' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothAdapter']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothAdapter;)V", "")]
		public unsafe BleScanCompat (global::Android.Bluetooth.BluetoothAdapter? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/bluetooth/BluetoothAdapter;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='BleScanCompat']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.util.BleScanCompat.BleScanCallback']]"
		[Register ("a", "(Lcom/linktop/whealthService/util/BleScanCompat$BleScanCallback;)V", "")]
		public unsafe void A (global::Com.Linktop.WhealthService.Util.BleScanCompat.IBleScanCallback? p0)
		{
			const string __id = "a.(Lcom/linktop/whealthService/util/BleScanCompat$BleScanCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='BleScanCompat']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("a", "([Ljava/lang/String;)V", "")]
		public unsafe void A (params string[]? p0)
		{
			const string __id = "a.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='BleScanCompat']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public unsafe void C ()
		{
			const string __id = "c.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='BleScanCompat']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public unsafe void F ()
		{
			const string __id = "f.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}

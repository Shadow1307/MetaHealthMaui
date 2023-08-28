using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/OnBLEService", DoNotGenerateAcw=true)]
	public sealed partial class OnBLEService : global::Android.App.Service, global::Com.Linktop.WhealthService.Util.BleScanCompat.IBleScanCallback, global::Com.Linktop.WhealthService.Util.IBleDev {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/field[@name='j']"
		[Register ("j")]
		public bool J {
			get {
				const string __id = "j.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "j.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/field[@name='P']"
		[Register ("P")]
		public static long P {
			get {
				const string __id = "P.J";

				var __v = _members.StaticFields.GetInt64Value (__id);
				return __v;
			}
			set {
				const string __id = "P.J";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.DeviceSort']"
		[global::Android.Runtime.Register ("com/linktop/whealthService/OnBLEService$DeviceSort", DoNotGenerateAcw=true)]
		public partial class DeviceSort : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.DeviceSort']/field[@name='bleDevice']"
			[Register ("bleDevice")]
			public global::Android.Bluetooth.BluetoothDevice? BleDevice {
				get {
					const string __id = "bleDevice.Landroid/bluetooth/BluetoothDevice;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "bleDevice.Landroid/bluetooth/BluetoothDevice;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.DeviceSort']/field[@name='rssi']"
			[Register ("rssi")]
			public int Rssi {
				get {
					const string __id = "rssi.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "rssi.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/OnBLEService$DeviceSort", typeof (DeviceSort));

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

			protected DeviceSort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.LocalBinder']"
		[global::Android.Runtime.Register ("com/linktop/whealthService/OnBLEService$LocalBinder", DoNotGenerateAcw=true)]
		public partial class LocalBinder : global::Android.OS.Binder {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/OnBLEService$LocalBinder", typeof (LocalBinder));

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

			protected LocalBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.LocalBinder']/constructor[@name='OnBLEService.LocalBinder' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.OnBLEService']]"
			[Register (".ctor", "(Lcom/linktop/whealthService/OnBLEService;)V", "")]
			public unsafe LocalBinder (global::Com.Linktop.WhealthService.OnBLEService? __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType!) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate? cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_A);
				return cb_a;
			}

			static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.OnBLEService.LocalBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.A ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.LocalBinder']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Lcom/linktop/whealthService/OnBLEService;", "GetAHandler")]
			public virtual unsafe global::Com.Linktop.WhealthService.OnBLEService? A ()
			{
				const string __id = "a.()Lcom/linktop/whealthService/OnBLEService;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.OnBLEService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.OnBLEInnerService']"
		[global::Android.Runtime.Register ("com/linktop/whealthService/OnBLEService$OnBLEInnerService", DoNotGenerateAcw=true)]
		public partial class OnBLEInnerService : global::Android.App.Service {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/OnBLEService$OnBLEInnerService", typeof (OnBLEInnerService));

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

			protected OnBLEInnerService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.OnBLEInnerService']/constructor[@name='OnBLEService.OnBLEInnerService' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OnBLEInnerService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate? cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnBind_Landroid_content_Intent_Handler ()
			{
				if (cb_onBind_Landroid_content_Intent_ == null)
					cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnBind_Landroid_content_Intent_);
				return cb_onBind_Landroid_content_Intent_;
			}

			static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.OnBLEService.OnBLEInnerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService.OnBLEInnerService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
			[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
			public override unsafe global::Android.OS.IBinder? OnBind (global::Android.Content.Intent? p0)
			{
				const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='OnBLEService.OnSDKThrowableCallback']"
		[Register ("com/linktop/whealthService/OnBLEService$OnSDKThrowableCallback", "", "Com.Linktop.WhealthService.OnBLEService/IOnSDKThrowableCallbackInvoker")]
		public partial interface IOnSDKThrowableCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='OnBLEService.OnSDKThrowableCallback']/method[@name='onSDKThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onSDKThrowable", "(Ljava/lang/Throwable;)V", "GetOnSDKThrowable_Ljava_lang_Throwable_Handler:Com.Linktop.WhealthService.OnBLEService/IOnSDKThrowableCallbackInvoker, BleDev")]
			void OnSDKThrowable (global::Java.Lang.Throwable? p0);

		}

		[global::Android.Runtime.Register ("com/linktop/whealthService/OnBLEService$OnSDKThrowableCallback", DoNotGenerateAcw=true)]
		internal partial class IOnSDKThrowableCallbackInvoker : global::Java.Lang.Object, IOnSDKThrowableCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/OnBLEService$OnSDKThrowableCallback", typeof (IOnSDKThrowableCallbackInvoker));

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

			public static IOnSDKThrowableCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSDKThrowableCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.whealthService.OnBLEService.OnSDKThrowableCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSDKThrowableCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onSDKThrowable_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnSDKThrowable_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onSDKThrowable_Ljava_lang_Throwable_ == null)
					cb_onSDKThrowable_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSDKThrowable_Ljava_lang_Throwable_);
				return cb_onSDKThrowable_Ljava_lang_Throwable_;
			}

			static void n_OnSDKThrowable_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.OnBLEService.IOnSDKThrowableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSDKThrowable (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSDKThrowable_Ljava_lang_Throwable_;
			public unsafe void OnSDKThrowable (global::Java.Lang.Throwable? p0)
			{
				if (id_onSDKThrowable_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onSDKThrowable_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onSDKThrowable", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSDKThrowable_Ljava_lang_Throwable_, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/OnBLEService", typeof (OnBLEService));

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

		internal OnBLEService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/constructor[@name='OnBLEService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OnBLEService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Com.Linktop.WhealthService.Task.AckTask? AckTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getAckTask' and count(parameter)=0]"
			[Register ("getAckTask", "()Lcom/linktop/whealthService/task/AckTask;", "")]
			get {
				const string __id = "getAckTask.()Lcom/linktop/whealthService/task/AckTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.AckTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.BatteryTask? BatteryTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getBatteryTask' and count(parameter)=0]"
			[Register ("getBatteryTask", "()Lcom/linktop/whealthService/task/BatteryTask;", "")]
			get {
				const string __id = "getBatteryTask.()Lcom/linktop/whealthService/task/BatteryTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BatteryTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.BpTask? BpTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getBpTask' and count(parameter)=0]"
			[Register ("getBpTask", "()Lcom/linktop/whealthService/task/BpTask;", "")]
			get {
				const string __id = "getBpTask.()Lcom/linktop/whealthService/task/BpTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BpTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.BtTask? BtTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getBtTask' and count(parameter)=0]"
			[Register ("getBtTask", "()Lcom/linktop/whealthService/task/BtTask;", "")]
			get {
				const string __id = "getBtTask.()Lcom/linktop/whealthService/task/BtTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BtTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Util.Communicate? Communicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getCommunicate' and count(parameter)=0]"
			[Register ("getCommunicate", "()Lcom/linktop/whealthService/util/Communicate;", "")]
			get {
				const string __id = "getCommunicate.()Lcom/linktop/whealthService/util/Communicate;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.DeviceTask? DeviceTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getDeviceTask' and count(parameter)=0]"
			[Register ("getDeviceTask", "()Lcom/linktop/whealthService/task/DeviceTask;", "")]
			get {
				const string __id = "getDeviceTask.()Lcom/linktop/whealthService/task/DeviceTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.DeviceTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.EcgTask? EcgTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getEcgTask' and count(parameter)=0]"
			[Register ("getEcgTask", "()Lcom/linktop/whealthService/task/EcgTask;", "")]
			get {
				const string __id = "getEcgTask.()Lcom/linktop/whealthService/task/EcgTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.EcgTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool Measuring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='isMeasuring' and count(parameter)=0]"
			[Register ("isMeasuring", "()Z", "")]
			get {
				const string __id = "isMeasuring.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='setMeasuring' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMeasuring", "(Z)V", "")]
			set {
				const string __id = "setMeasuring.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.OxTask? OxTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getOxTask' and count(parameter)=0]"
			[Register ("getOxTask", "()Lcom/linktop/whealthService/task/OxTask;", "")]
			get {
				const string __id = "getOxTask.()Lcom/linktop/whealthService/task/OxTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.OxTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.SysErrorTask? SysErrorTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getSysErrorTask' and count(parameter)=0]"
			[Register ("getSysErrorTask", "()Lcom/linktop/whealthService/task/SysErrorTask;", "")]
			get {
				const string __id = "getSysErrorTask.()Lcom/linktop/whealthService/task/SysErrorTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.SysErrorTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.TestPaperTask? TestPaperTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getTestPaperTask' and count(parameter)=0]"
			[Register ("getTestPaperTask", "()Lcom/linktop/whealthService/task/TestPaperTask;", "")]
			get {
				const string __id = "getTestPaperTask.()Lcom/linktop/whealthService/task/TestPaperTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.Constant.IUserProfile? UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/linktop/constant/IUserProfile;", "")]
			get {
				const string __id = "getUserProfile.()Lcom/linktop/constant/IUserProfile;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='setUserProfile' and count(parameter)=1 and parameter[1][@type='com.linktop.constant.IUserProfile']]"
			[Register ("setUserProfile", "(Lcom/linktop/constant/IUserProfile;)V", "")]
			set {
				const string __id = "setUserProfile.(Lcom/linktop/constant/IUserProfile;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("a", "(Landroid/bluetooth/BluetoothDevice;)V", "")]
		public unsafe void A (global::Android.Bluetooth.BluetoothDevice? p0)
		{
			const string __id = "a.(Landroid/bluetooth/BluetoothDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("a", "(Landroid/bluetooth/BluetoothDevice;I[B)V", "")]
		public unsafe void A (global::Android.Bluetooth.BluetoothDevice? p0, int p1, byte[]? p2)
		{
			const string __id = "a.(Landroid/bluetooth/BluetoothDevice;I[B)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[2][@type='boolean']]"
		[Register ("a", "(Landroid/bluetooth/BluetoothGattCharacteristic;Z)Z", "")]
		public unsafe bool A (global::Android.Bluetooth.BluetoothGattCharacteristic? p0, bool p1)
		{
			const string __id = "a.(Landroid/bluetooth/BluetoothGattCharacteristic;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public unsafe void A (bool p0)
		{
			const string __id = "a.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("a", "(ZZ)V", "")]
		public unsafe void A (bool p0, bool p1)
		{
			const string __id = "a.(ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBleConnectListener']]"
		[Register ("a", "(Lcom/linktop/infs/OnBleConnectListener;)V", "")]
		public unsafe void A (global::Com.Linktop.Infs.IOnBleConnectListener? p0)
		{
			const string __id = "a.(Lcom/linktop/infs/OnBleConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnDeviceInfoListener']]"
		[Register ("a", "(Lcom/linktop/infs/OnDeviceInfoListener;)V", "")]
		public unsafe void A (global::Com.Linktop.Infs.IOnDeviceInfoListener? p0)
		{
			const string __id = "a.(Lcom/linktop/infs/OnDeviceInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnDeviceVersionListener']]"
		[Register ("a", "(Lcom/linktop/infs/OnDeviceVersionListener;)V", "")]
		public unsafe void A (global::Com.Linktop.Infs.IOnDeviceVersionListener? p0)
		{
			const string __id = "a.(Lcom/linktop/infs/OnDeviceVersionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "")]
		public unsafe void A (int p0)
		{
			const string __id = "a.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.linktop.whealthService.OnBLEService.OnSDKThrowableCallback']]"
		[Register ("a", "(Ljava/lang/String;Lcom/linktop/whealthService/OnBLEService$OnSDKThrowableCallback;)V", "")]
		public unsafe void A (string p0, global::Com.Linktop.WhealthService.OnBLEService.IOnSDKThrowableCallback? p1)
		{
			const string __id = "a.(Ljava/lang/String;Lcom/linktop/whealthService/OnBLEService$OnSDKThrowableCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)V", "")]
		public unsafe void A (long p0)
		{
			const string __id = "a.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public unsafe void B ()
		{
			const string __id = "b.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='clearCmdToSend' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("clearCmdToSend", "(BB)V", "")]
		public unsafe void ClearCmdToSend (sbyte p0, sbyte p1)
		{
			const string __id = "clearCmdToSend.(BB)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='cmdToSend' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("cmdToSend", "([B)V", "")]
		public unsafe void CmdToSend (byte[]? p0)
		{
			const string __id = "cmdToSend.([B)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		public unsafe void D ()
		{
			const string __id = "d.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='d' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("d", "(I)V", "")]
		public unsafe void D (int p0)
		{
			const string __id = "d.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public unsafe void F ()
		{
			const string __id = "f.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()I", "")]
		public unsafe int H ()
		{
			const string __id = "h.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Landroid/bluetooth/BluetoothDevice;", "")]
		public unsafe global::Android.Bluetooth.BluetoothDevice? I ()
		{
			const string __id = "i.()Landroid/bluetooth/BluetoothDevice;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Ljava/util/TimerTask;", "")]
		public unsafe global::Java.Util.TimerTask? L ()
		{
			const string __id = "l.()Ljava/util/TimerTask;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimerTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()Z", "")]
		public unsafe bool M ()
		{
			const string __id = "m.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "")]
		public override unsafe global::Android.OS.IBinder? OnBind (global::Android.Content.Intent? p0)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='onInnerThrowableCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onInnerThrowableCallback", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void OnInnerThrowableCallback (global::Java.Lang.Throwable? p0)
		{
			const string __id = "onInnerThrowableCallback.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='OnBLEService']/method[@name='updateBleConnectIntervalFailed' and count(parameter)=0]"
		[Register ("updateBleConnectIntervalFailed", "()V", "")]
		public unsafe void UpdateBleConnectIntervalFailed ()
		{
			const string __id = "updateBleConnectIntervalFailed.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}

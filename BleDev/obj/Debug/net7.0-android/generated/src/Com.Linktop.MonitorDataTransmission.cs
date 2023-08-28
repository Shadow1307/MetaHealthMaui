using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']"
	[global::Android.Runtime.Register ("com/linktop/MonitorDataTransmission", DoNotGenerateAcw=true)]
	public partial class MonitorDataTransmission : global::Java.Lang.Object, global::Android.Content.IServiceConnection, global::Com.Linktop.WhealthService.OnBLEService.IOnSDKThrowableCallback {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/field[@name='d']"
		[Register ("d")]
		protected int D {
			get {
				const string __id = "d.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "d.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/field[@name='e']"
		[Register ("e")]
		protected string? E {
			get {
				const string __id = "e.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/field[@name='f']"
		[Register ("f")]
		protected global::Com.Linktop.WhealthService.Util.IBleDev? F {
			get {
				const string __id = "f.Lcom/linktop/whealthService/util/IBleDev;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Lcom/linktop/whealthService/util/IBleDev;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop']/interface[@name='MonitorDataTransmission.OnServiceBindListener']"
		[Register ("com/linktop/MonitorDataTransmission$OnServiceBindListener", "", "Com.Linktop.MonitorDataTransmission/IOnServiceBindListenerInvoker")]
		public partial interface IOnServiceBindListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/interface[@name='MonitorDataTransmission.OnServiceBindListener']/method[@name='onSDKThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onSDKThrowable", "(Ljava/lang/Throwable;)V", "GetOnSDKThrowable_Ljava_lang_Throwable_Handler:Com.Linktop.MonitorDataTransmission/IOnServiceBindListenerInvoker, BleDev")]
			void OnSDKThrowable (global::Java.Lang.Throwable? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/interface[@name='MonitorDataTransmission.OnServiceBindListener']/method[@name='onServiceBind' and count(parameter)=0]"
			[Register ("onServiceBind", "()V", "GetOnServiceBindHandler:Com.Linktop.MonitorDataTransmission/IOnServiceBindListenerInvoker, BleDev")]
			void OnServiceBind ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/interface[@name='MonitorDataTransmission.OnServiceBindListener']/method[@name='onServiceUnbind' and count(parameter)=0]"
			[Register ("onServiceUnbind", "()V", "GetOnServiceUnbindHandler:Com.Linktop.MonitorDataTransmission/IOnServiceBindListenerInvoker, BleDev")]
			void OnServiceUnbind ();

		}

		[global::Android.Runtime.Register ("com/linktop/MonitorDataTransmission$OnServiceBindListener", DoNotGenerateAcw=true)]
		internal partial class IOnServiceBindListenerInvoker : global::Java.Lang.Object, IOnServiceBindListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/MonitorDataTransmission$OnServiceBindListener", typeof (IOnServiceBindListenerInvoker));

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

			public static IOnServiceBindListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnServiceBindListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.MonitorDataTransmission.OnServiceBindListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnServiceBindListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission.IOnServiceBindListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

			static Delegate? cb_onServiceBind;
#pragma warning disable 0169
			static Delegate GetOnServiceBindHandler ()
			{
				if (cb_onServiceBind == null)
					cb_onServiceBind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnServiceBind);
				return cb_onServiceBind;
			}

			static void n_OnServiceBind (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission.IOnServiceBindListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnServiceBind ();
			}
#pragma warning restore 0169

			IntPtr id_onServiceBind;
			public unsafe void OnServiceBind ()
			{
				if (id_onServiceBind == IntPtr.Zero)
					id_onServiceBind = JNIEnv.GetMethodID (class_ref, "onServiceBind", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onServiceBind);
			}

			static Delegate? cb_onServiceUnbind;
#pragma warning disable 0169
			static Delegate GetOnServiceUnbindHandler ()
			{
				if (cb_onServiceUnbind == null)
					cb_onServiceUnbind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnServiceUnbind);
				return cb_onServiceUnbind;
			}

			static void n_OnServiceUnbind (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission.IOnServiceBindListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnServiceUnbind ();
			}
#pragma warning restore 0169

			IntPtr id_onServiceUnbind;
			public unsafe void OnServiceUnbind ()
			{
				if (id_onServiceUnbind == IntPtr.Zero)
					id_onServiceUnbind = JNIEnv.GetMethodID (class_ref, "onServiceUnbind", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onServiceUnbind);
			}

		}

		// event args for com.linktop.MonitorDataTransmission.OnServiceBindListener.onSDKThrowable
		public partial class SDKThrowableEventArgs : global::System.EventArgs {
			public SDKThrowableEventArgs (global::Java.Lang.Throwable? p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Throwable? p0;

			public global::Java.Lang.Throwable? P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/linktop/MonitorDataTransmission_OnServiceBindListenerImplementor")]
		internal sealed partial class IOnServiceBindListenerImplementor : global::Java.Lang.Object, IOnServiceBindListener {

			object sender;

			public IOnServiceBindListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/MonitorDataTransmission_OnServiceBindListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<SDKThrowableEventArgs>? OnSDKThrowableHandler;
			#pragma warning restore 0649

			public void OnSDKThrowable (global::Java.Lang.Throwable? p0)
			{
				var __h = OnSDKThrowableHandler;
				if (__h != null)
					__h (sender, new SDKThrowableEventArgs (p0));
			}

			#pragma warning disable 0649
			public EventHandler? OnServiceBindHandler;
			#pragma warning restore 0649

			public void OnServiceBind ()
			{
				var __h = OnServiceBindHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			#pragma warning disable 0649
			public EventHandler? OnServiceUnbindHandler;
			#pragma warning restore 0649

			public void OnServiceUnbind ()
			{
				var __h = OnServiceUnbindHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnServiceBindListenerImplementor value)
			{
				return value.OnSDKThrowableHandler == null && value.OnServiceBindHandler == null && value.OnServiceUnbindHandler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/MonitorDataTransmission", typeof (MonitorDataTransmission));

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

		protected MonitorDataTransmission (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getBatteryValue;
#pragma warning disable 0169
		static Delegate GetGetBatteryValueHandler ()
		{
			if (cb_getBatteryValue == null)
				cb_getBatteryValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBatteryValue);
			return cb_getBatteryValue;
		}

		static int n_GetBatteryValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.BatteryValue;
		}
#pragma warning restore 0169

		public virtual unsafe int BatteryValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='getBatteryValue' and count(parameter)=0]"
			[Register ("getBatteryValue", "()I", "GetGetBatteryValueHandler")]
			get {
				const string __id = "getBatteryValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getBleState;
#pragma warning disable 0169
		static Delegate GetGetBleStateHandler ()
		{
			if (cb_getBleState == null)
				cb_getBleState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBleState);
			return cb_getBleState;
		}

		static int n_GetBleState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.BleState;
		}
#pragma warning restore 0169

		public virtual unsafe int BleState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='getBleState' and count(parameter)=0]"
			[Register ("getBleState", "()I", "GetGetBleStateHandler")]
			get {
				const string __id = "getBleState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getBluetoothDevice;
#pragma warning disable 0169
		static Delegate GetGetBluetoothDeviceHandler ()
		{
			if (cb_getBluetoothDevice == null)
				cb_getBluetoothDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBluetoothDevice);
			return cb_getBluetoothDevice;
		}

		static IntPtr n_GetBluetoothDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.BluetoothDevice);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Bluetooth.BluetoothDevice? BluetoothDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='getBluetoothDevice' and count(parameter)=0]"
			[Register ("getBluetoothDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetBluetoothDeviceHandler")]
			get {
				const string __id = "getBluetoothDevice.()Landroid/bluetooth/BluetoothDevice;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getDeviceList;
#pragma warning disable 0169
		static Delegate GetGetDeviceListHandler ()
		{
			if (cb_getDeviceList == null)
				cb_getDeviceList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceList);
			return cb_getDeviceList;
		}

		static IntPtr n_GetDeviceList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Linktop.WhealthService.OnBLEService.DeviceSort>.ToLocalJniHandle (__this.DeviceList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Linktop.WhealthService.OnBLEService.DeviceSort>? DeviceList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='getDeviceList' and count(parameter)=0]"
			[Register ("getDeviceList", "()Ljava/util/List;", "GetGetDeviceListHandler")]
			get {
				const string __id = "getDeviceList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Linktop.WhealthService.OnBLEService.DeviceSort>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_isCharging;
#pragma warning disable 0169
		static Delegate GetIsChargingHandler ()
		{
			if (cb_isCharging == null)
				cb_isCharging = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCharging);
			return cb_isCharging;
		}

		static bool n_IsCharging (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsCharging;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isCharging' and count(parameter)=0]"
			[Register ("isCharging", "()Z", "GetIsChargingHandler")]
			get {
				const string __id = "isCharging.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isEcgModuleExist;
#pragma warning disable 0169
		static Delegate GetIsEcgModuleExistHandler ()
		{
			if (cb_isEcgModuleExist == null)
				cb_isEcgModuleExist = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEcgModuleExist);
			return cb_isEcgModuleExist;
		}

		static bool n_IsEcgModuleExist (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsEcgModuleExist;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEcgModuleExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isEcgModuleExist' and count(parameter)=0]"
			[Register ("isEcgModuleExist", "()Z", "GetIsEcgModuleExistHandler")]
			get {
				const string __id = "isEcgModuleExist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isMeasureWrist;
#pragma warning disable 0169
		static Delegate GetIsMeasureWristHandler ()
		{
			if (cb_isMeasureWrist == null)
				cb_isMeasureWrist = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMeasureWrist);
			return cb_isMeasureWrist;
		}

		static bool n_IsMeasureWrist (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsMeasureWrist;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMeasureWrist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isMeasureWrist' and count(parameter)=0]"
			[Register ("isMeasureWrist", "()Z", "GetIsMeasureWristHandler")]
			get {
				const string __id = "isMeasureWrist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isMeasuring;
#pragma warning disable 0169
		static Delegate GetIsMeasuringHandler ()
		{
			if (cb_isMeasuring == null)
				cb_isMeasuring = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMeasuring);
			return cb_isMeasuring;
		}

		static bool n_IsMeasuring (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsMeasuring;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMeasuring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isMeasuring' and count(parameter)=0]"
			[Register ("isMeasuring", "()Z", "GetIsMeasuringHandler")]
			get {
				const string __id = "isMeasuring.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isScanning;
#pragma warning disable 0169
		static Delegate GetIsScanningHandler ()
		{
			if (cb_isScanning == null)
				cb_isScanning = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsScanning);
			return cb_isScanning;
		}

		static bool n_IsScanning (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsScanning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsScanning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isScanning' and count(parameter)=0]"
			[Register ("isScanning", "()Z", "GetIsScanningHandler")]
			get {
				const string __id = "isScanning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isTestPaperModuleDoubleADC;
#pragma warning disable 0169
		static Delegate GetIsTestPaperModuleDoubleADCHandler ()
		{
			if (cb_isTestPaperModuleDoubleADC == null)
				cb_isTestPaperModuleDoubleADC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTestPaperModuleDoubleADC);
			return cb_isTestPaperModuleDoubleADC;
		}

		static bool n_IsTestPaperModuleDoubleADC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsTestPaperModuleDoubleADC;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTestPaperModuleDoubleADC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isTestPaperModuleDoubleADC' and count(parameter)=0]"
			[Register ("isTestPaperModuleDoubleADC", "()Z", "GetIsTestPaperModuleDoubleADCHandler")]
			get {
				const string __id = "isTestPaperModuleDoubleADC.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isTestPaperModuleExist;
#pragma warning disable 0169
		static Delegate GetIsTestPaperModuleExistHandler ()
		{
			if (cb_isTestPaperModuleExist == null)
				cb_isTestPaperModuleExist = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTestPaperModuleExist);
			return cb_isTestPaperModuleExist;
		}

		static bool n_IsTestPaperModuleExist (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsTestPaperModuleExist;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTestPaperModuleExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='isTestPaperModuleExist' and count(parameter)=0]"
			[Register ("isTestPaperModuleExist", "()Z", "GetIsTestPaperModuleExistHandler")]
			get {
				const string __id = "isTestPaperModuleExist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getUserProfile;
#pragma warning disable 0169
		static Delegate GetGetUserProfileHandler ()
		{
			if (cb_getUserProfile == null)
				cb_getUserProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserProfile);
			return cb_getUserProfile;
		}

		static IntPtr n_GetUserProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.UserProfile);
		}
#pragma warning restore 0169

		static Delegate? cb_setUserProfile_Lcom_linktop_constant_IUserProfile_;
#pragma warning disable 0169
		static Delegate GetSetUserProfile_Lcom_linktop_constant_IUserProfile_Handler ()
		{
			if (cb_setUserProfile_Lcom_linktop_constant_IUserProfile_ == null)
				cb_setUserProfile_Lcom_linktop_constant_IUserProfile_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUserProfile_Lcom_linktop_constant_IUserProfile_);
			return cb_setUserProfile_Lcom_linktop_constant_IUserProfile_;
		}

		static void n_SetUserProfile_Lcom_linktop_constant_IUserProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Constant.IUserProfile?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserProfile = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Linktop.Constant.IUserProfile? UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/linktop/constant/IUserProfile;", "GetGetUserProfileHandler")]
			get {
				const string __id = "getUserProfile.()Lcom/linktop/constant/IUserProfile;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setUserProfile' and count(parameter)=1 and parameter[1][@type='com.linktop.constant.IUserProfile']]"
			[Register ("setUserProfile", "(Lcom/linktop/constant/IUserProfile;)V", "GetSetUserProfile_Lcom_linktop_constant_IUserProfile_Handler")]
			set {
				const string __id = "setUserProfile.(Lcom/linktop/constant/IUserProfile;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_a_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_A_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_;
		}

		static bool n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Z", "GetA_Ljava_lang_String_Handler")]
		protected virtual unsafe bool A (string? p0)
		{
			const string __id = "a.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_autoScan_Z;
#pragma warning disable 0169
		static Delegate GetAutoScan_ZHandler ()
		{
			if (cb_autoScan_Z == null)
				cb_autoScan_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_AutoScan_Z);
			return cb_autoScan_Z;
		}

		static void n_AutoScan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.AutoScan (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='autoScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("autoScan", "(Z)V", "GetAutoScan_ZHandler")]
		public virtual unsafe void AutoScan (bool p0)
		{
			const string __id = "autoScan.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_bind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_;
#pragma warning disable 0169
		static Delegate GetBind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_Handler ()
		{
			if (cb_bind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_ == null)
				cb_bind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Bind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_);
			return cb_bind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_;
		}

		static void n_Bind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Linktop.MonitorDataTransmission.IOnServiceBindListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission.IOnServiceBindListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Bind (p0, p1!, p2!);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='bind' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.linktop.MonitorDataTransmission.OnServiceBindListener']]"
		[Register ("bind", "(Ljava/lang/String;Landroid/content/Context;Lcom/linktop/MonitorDataTransmission$OnServiceBindListener;)V", "GetBind_Ljava_lang_String_Landroid_content_Context_Lcom_linktop_MonitorDataTransmission_OnServiceBindListener_Handler")]
		public virtual unsafe void Bind ([global::Android.Runtime.StringDef (Type = "Com.Linktop.IDeviceType", Fields = new string [] {"HealthMonitor", "Thermometer"})][global::Android.Runtime.StringDef (Type = "Com.Linktop.IDeviceType", Fields = new string [] {"HealthMonitor", "Thermometer"})]
		string? p0, global::Android.Content.Context p1, global::Com.Linktop.MonitorDataTransmission.IOnServiceBindListener p2)
		{
			const string __id = "bind.(Ljava/lang/String;Landroid/content/Context;Lcom/linktop/MonitorDataTransmission$OnServiceBindListener;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate? cb_bleCheckOpen;
#pragma warning disable 0169
		static Delegate GetBleCheckOpenHandler ()
		{
			if (cb_bleCheckOpen == null)
				cb_bleCheckOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_BleCheckOpen);
			return cb_bleCheckOpen;
		}

		static void n_BleCheckOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.BleCheckOpen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='bleCheckOpen' and count(parameter)=0]"
		[Register ("bleCheckOpen", "()V", "GetBleCheckOpenHandler")]
		public virtual unsafe void BleCheckOpen ()
		{
			const string __id = "bleCheckOpen.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_connectToBle_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetConnectToBle_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_connectToBle_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_connectToBle_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ConnectToBle_Landroid_bluetooth_BluetoothDevice_);
			return cb_connectToBle_Landroid_bluetooth_BluetoothDevice_;
		}

		static void n_ConnectToBle_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectToBle (p0!);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='connectToBle' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("connectToBle", "(Landroid/bluetooth/BluetoothDevice;)V", "GetConnectToBle_Landroid_bluetooth_BluetoothDevice_Handler")]
		public virtual unsafe void ConnectToBle (global::Android.Bluetooth.BluetoothDevice p0)
		{
			const string __id = "connectToBle.(Landroid/bluetooth/BluetoothDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_disConnectBle;
#pragma warning disable 0169
		static Delegate GetDisConnectBleHandler ()
		{
			if (cb_disConnectBle == null)
				cb_disConnectBle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisConnectBle);
			return cb_disConnectBle;
		}

		static void n_DisConnectBle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.DisConnectBle ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='disConnectBle' and count(parameter)=0]"
		[Register ("disConnectBle", "()V", "GetDisConnectBleHandler")]
		public virtual unsafe void DisConnectBle ()
		{
			const string __id = "disConnectBle.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_getDevInfo_Lcom_linktop_infs_OnThermInfoListener_;
#pragma warning disable 0169
		static Delegate GetGetDevInfo_Lcom_linktop_infs_OnThermInfoListener_Handler ()
		{
			if (cb_getDevInfo_Lcom_linktop_infs_OnThermInfoListener_ == null)
				cb_getDevInfo_Lcom_linktop_infs_OnThermInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetDevInfo_Lcom_linktop_infs_OnThermInfoListener_);
			return cb_getDevInfo_Lcom_linktop_infs_OnThermInfoListener_;
		}

		static void n_GetDevInfo_Lcom_linktop_infs_OnThermInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnThermInfoListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnThermInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDevInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='getDevInfo' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnThermInfoListener']]"
		[Register ("getDevInfo", "(Lcom/linktop/infs/OnThermInfoListener;)V", "GetGetDevInfo_Lcom_linktop_infs_OnThermInfoListener_Handler")]
		public virtual unsafe void GetDevInfo (global::Com.Linktop.Infs.IOnThermInfoListener? p0)
		{
			const string __id = "getDevInfo.(Lcom/linktop/infs/OnThermInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_getTestPaperCalibration;
#pragma warning disable 0169
		static Delegate GetGetTestPaperCalibrationHandler ()
		{
			if (cb_getTestPaperCalibration == null)
				cb_getTestPaperCalibration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_GetTestPaperCalibration);
			return cb_getTestPaperCalibration;
		}

		static void n_GetTestPaperCalibration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.GetTestPaperCalibration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='getTestPaperCalibration' and count(parameter)=0]"
		[Register ("getTestPaperCalibration", "()V", "GetGetTestPaperCalibrationHandler")]
		public virtual unsafe void GetTestPaperCalibration ()
		{
			const string __id = "getTestPaperCalibration.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_;
#pragma warning disable 0169
		static Delegate GetNeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_Handler ()
		{
			if (cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_ == null)
				cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_NeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_);
			return cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_;
		}

		static void n_NeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IAuthCheckResult?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IAuthCheckResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NeedDeviceAuthCheck (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='needDeviceAuthCheck' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.AuthCheckResult']]"
		[Register ("needDeviceAuthCheck", "(Lcom/linktop/infs/AuthCheckResult;)V", "GetNeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_Handler")]
		public virtual unsafe void NeedDeviceAuthCheck (global::Com.Linktop.Infs.IAuthCheckResult? p0)
		{
			const string __id = "needDeviceAuthCheck.(Lcom/linktop/infs/AuthCheckResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSDKThrowable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='onSDKThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onSDKThrowable", "(Ljava/lang/Throwable;)V", "GetOnSDKThrowable_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnSDKThrowable (global::Java.Lang.Throwable? p0)
		{
			const string __id = "onSDKThrowable.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
		{
			if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
				cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
			return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		}

		static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.OS.IBinder?)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceConnected (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
		[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
		public virtual unsafe void OnServiceConnected (global::Android.Content.ComponentName? p0, global::Android.OS.IBinder? p1)
		{
			const string __id = "onServiceConnected.(Landroid/content/ComponentName;Landroid/os/IBinder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
				cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnServiceDisconnected_Landroid_content_ComponentName_);
			return cb_onServiceDisconnected_Landroid_content_ComponentName_;
		}

		static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceDisconnected (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
		public virtual unsafe void OnServiceDisconnected (global::Android.Content.ComponentName? p0)
		{
			const string __id = "onServiceDisconnected.(Landroid/content/ComponentName;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_pressureFromData_ZI;
#pragma warning disable 0169
		static Delegate GetPressureFromData_ZIHandler ()
		{
			if (cb_pressureFromData_ZI == null)
				cb_pressureFromData_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZI_V) n_PressureFromData_ZI);
			return cb_pressureFromData_ZI;
		}

		static void n_PressureFromData_ZI (IntPtr jnienv, IntPtr native__this, bool p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.PressureFromData (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='pressureFromData' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("pressureFromData", "(ZI)V", "GetPressureFromData_ZIHandler")]
		public virtual unsafe void PressureFromData (bool p0, int p1)
		{
			const string __id = "pressureFromData.(ZI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_scan_Z;
#pragma warning disable 0169
		static Delegate GetScan_ZHandler ()
		{
			if (cb_scan_Z == null)
				cb_scan_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Scan_Z);
			return cb_scan_Z;
		}

		static void n_Scan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Scan (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='scan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scan", "(Z)V", "GetScan_ZHandler")]
		public virtual unsafe void Scan (bool p0)
		{
			const string __id = "scan.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_setAutoScanPeriod_J;
#pragma warning disable 0169
		static Delegate GetSetAutoScanPeriod_JHandler ()
		{
			if (cb_setAutoScanPeriod_J == null)
				cb_setAutoScanPeriod_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetAutoScanPeriod_J);
			return cb_setAutoScanPeriod_J;
		}

		static void n_SetAutoScanPeriod_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetAutoScanPeriod (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setAutoScanPeriod' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAutoScanPeriod", "(J)V", "GetSetAutoScanPeriod_JHandler")]
		public virtual unsafe void SetAutoScanPeriod (long p0)
		{
			const string __id = "setAutoScanPeriod.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_setBgVer;
#pragma warning disable 0169
		static Delegate GetSetBgVerHandler ()
		{
			if (cb_setBgVer == null)
				cb_setBgVer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetBgVer);
			return cb_setBgVer;
		}

		static void n_SetBgVer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetBgVer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setBgVer' and count(parameter)=0]"
		[Register ("setBgVer", "()V", "GetSetBgVerHandler")]
		public virtual unsafe void SetBgVer ()
		{
			const string __id = "setBgVer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_setMeasurePosition_Z;
#pragma warning disable 0169
		static Delegate GetSetMeasurePosition_ZHandler ()
		{
			if (cb_setMeasurePosition_Z == null)
				cb_setMeasurePosition_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMeasurePosition_Z);
			return cb_setMeasurePosition_Z;
		}

		static void n_SetMeasurePosition_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetMeasurePosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setMeasurePosition' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMeasurePosition", "(Z)V", "GetSetMeasurePosition_ZHandler")]
		public virtual unsafe void SetMeasurePosition (bool p0)
		{
			const string __id = "setMeasurePosition.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_setOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_Handler ()
		{
			if (cb_setOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_ == null)
				cb_setOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_);
			return cb_setOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_;
		}

		static void n_SetOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnBatteryListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBatteryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBatteryListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnBatteryListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBatteryListener']]"
		[Register ("setOnBatteryListener", "(Lcom/linktop/infs/OnBatteryListener;)V", "GetSetOnBatteryListener_Lcom_linktop_infs_OnBatteryListener_Handler")]
		public virtual unsafe void SetOnBatteryListener (global::Com.Linktop.Infs.IOnBatteryListener? p0)
		{
			const string __id = "setOnBatteryListener.(Lcom/linktop/infs/OnBatteryListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_Handler ()
		{
			if (cb_setOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_ == null)
				cb_setOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_);
			return cb_setOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_;
		}

		static void n_SetOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnBleConnectListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBleConnectListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBleConnectListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnBleConnectListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBleConnectListener']]"
		[Register ("setOnBleConnectListener", "(Lcom/linktop/infs/OnBleConnectListener;)V", "GetSetOnBleConnectListener_Lcom_linktop_infs_OnBleConnectListener_Handler")]
		public virtual unsafe void SetOnBleConnectListener (global::Com.Linktop.Infs.IOnBleConnectListener? p0)
		{
			const string __id = "setOnBleConnectListener.(Lcom/linktop/infs/OnBleConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_Handler ()
		{
			if (cb_setOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_ == null)
				cb_setOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_);
			return cb_setOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_;
		}

		static void n_SetOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnBpDataListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBpDataListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBpDataListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnBpDataListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBpDataListener']]"
		[Register ("setOnBpDataListener", "(Lcom/linktop/infs/OnBpDataListener;)V", "GetSetOnBpDataListener_Lcom_linktop_infs_OnBpDataListener_Handler")]
		public virtual unsafe void SetOnBpDataListener (global::Com.Linktop.Infs.IOnBpDataListener? p0)
		{
			const string __id = "setOnBpDataListener.(Lcom/linktop/infs/OnBpDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_Handler ()
		{
			if (cb_setOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_ == null)
				cb_setOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_);
			return cb_setOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_;
		}

		static void n_SetOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnBpResultListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBpResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBpResultListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnBpResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBpResultListener']]"
		[Register ("setOnBpResultListener", "(Lcom/linktop/infs/OnBpResultListener;)V", "GetSetOnBpResultListener_Lcom_linktop_infs_OnBpResultListener_Handler")]
		public virtual unsafe void SetOnBpResultListener (global::Com.Linktop.Infs.IOnBpResultListener? p0)
		{
			const string __id = "setOnBpResultListener.(Lcom/linktop/infs/OnBpResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_Handler ()
		{
			if (cb_setOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_ == null)
				cb_setOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_);
			return cb_setOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_;
		}

		static void n_SetOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnBtResultListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBtResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBtResultListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnBtResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBtResultListener']]"
		[Register ("setOnBtResultListener", "(Lcom/linktop/infs/OnBtResultListener;)V", "GetSetOnBtResultListener_Lcom_linktop_infs_OnBtResultListener_Handler")]
		public virtual unsafe void SetOnBtResultListener (global::Com.Linktop.Infs.IOnBtResultListener? p0)
		{
			const string __id = "setOnBtResultListener.(Lcom/linktop/infs/OnBtResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_Handler ()
		{
			if (cb_setOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_ == null)
				cb_setOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_);
			return cb_setOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_;
		}

		static void n_SetOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnDeviceInfoListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnDeviceInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDevIdAndKeyListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnDevIdAndKeyListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnDeviceInfoListener']]"
		[Register ("setOnDevIdAndKeyListener", "(Lcom/linktop/infs/OnDeviceInfoListener;)V", "GetSetOnDevIdAndKeyListener_Lcom_linktop_infs_OnDeviceInfoListener_Handler")]
		public virtual unsafe void SetOnDevIdAndKeyListener (global::Com.Linktop.Infs.IOnDeviceInfoListener? p0)
		{
			const string __id = "setOnDevIdAndKeyListener.(Lcom/linktop/infs/OnDeviceInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_Handler ()
		{
			if (cb_setOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_ == null)
				cb_setOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_);
			return cb_setOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_;
		}

		static void n_SetOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnDeviceVersionListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnDeviceVersionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDeviceVersionListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnDeviceVersionListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnDeviceVersionListener']]"
		[Register ("setOnDeviceVersionListener", "(Lcom/linktop/infs/OnDeviceVersionListener;)V", "GetSetOnDeviceVersionListener_Lcom_linktop_infs_OnDeviceVersionListener_Handler")]
		public virtual unsafe void SetOnDeviceVersionListener (global::Com.Linktop.Infs.IOnDeviceVersionListener? p0)
		{
			const string __id = "setOnDeviceVersionListener.(Lcom/linktop/infs/OnDeviceVersionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_Handler ()
		{
			if (cb_setOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_ == null)
				cb_setOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_);
			return cb_setOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_;
		}

		static void n_SetOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnEcgResultListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnEcgResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnEcgResultListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnEcgResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnEcgResultListener']]"
		[Register ("setOnEcgResultListener", "(Lcom/linktop/infs/OnEcgResultListener;)V", "GetSetOnEcgResultListener_Lcom_linktop_infs_OnEcgResultListener_Handler")]
		public virtual unsafe void SetOnEcgResultListener (global::Com.Linktop.Infs.IOnEcgResultListener? p0)
		{
			const string __id = "setOnEcgResultListener.(Lcom/linktop/infs/OnEcgResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_Handler ()
		{
			if (cb_setOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_ == null)
				cb_setOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_);
			return cb_setOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_;
		}

		static void n_SetOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnHRVResultListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnHRVResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnHrvResultListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnHrvResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnHRVResultListener']]"
		[Register ("setOnHrvResultListener", "(Lcom/linktop/infs/OnHRVResultListener;)V", "GetSetOnHrvResultListener_Lcom_linktop_infs_OnHRVResultListener_Handler")]
		public virtual unsafe void SetOnHrvResultListener (global::Com.Linktop.Infs.IOnHRVResultListener? p0)
		{
			const string __id = "setOnHrvResultListener.(Lcom/linktop/infs/OnHRVResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_Handler ()
		{
			if (cb_setOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_ == null)
				cb_setOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_);
			return cb_setOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_;
		}

		static void n_SetOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnSpO2ResultListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnSpO2ResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSpO2ResultListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setOnSpO2ResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnSpO2ResultListener']]"
		[Register ("setOnSpO2ResultListener", "(Lcom/linktop/infs/OnSpO2ResultListener;)V", "GetSetOnSpO2ResultListener_Lcom_linktop_infs_OnSpO2ResultListener_Handler")]
		public virtual unsafe void SetOnSpO2ResultListener (global::Com.Linktop.Infs.IOnSpO2ResultListener? p0)
		{
			const string __id = "setOnSpO2ResultListener.(Lcom/linktop/infs/OnSpO2ResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setScanDevNamePrefixWhiteList_I;
#pragma warning disable 0169
		static Delegate GetSetScanDevNamePrefixWhiteList_IHandler ()
		{
			if (cb_setScanDevNamePrefixWhiteList_I == null)
				cb_setScanDevNamePrefixWhiteList_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetScanDevNamePrefixWhiteList_I);
			return cb_setScanDevNamePrefixWhiteList_I;
		}

		static void n_SetScanDevNamePrefixWhiteList_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetScanDevNamePrefixWhiteList (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setScanDevNamePrefixWhiteList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScanDevNamePrefixWhiteList", "(I)V", "GetSetScanDevNamePrefixWhiteList_IHandler")]
		public virtual unsafe void SetScanDevNamePrefixWhiteList (int p0)
		{
			const string __id = "setScanDevNamePrefixWhiteList.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_setTestPaper_ILcom_linktop_constant_TestPaper_;
#pragma warning disable 0169
		static Delegate GetSetTestPaper_ILcom_linktop_constant_TestPaper_Handler ()
		{
			if (cb_setTestPaper_ILcom_linktop_constant_TestPaper_ == null)
				cb_setTestPaper_ILcom_linktop_constant_TestPaper_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetTestPaper_ILcom_linktop_constant_TestPaper_);
			return cb_setTestPaper_ILcom_linktop_constant_TestPaper_;
		}

		static void n_SetTestPaper_ILcom_linktop_constant_TestPaper_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.TestPaper> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTestPaper (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='setTestPaper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.linktop.constant.TestPaper']]"
		[Register ("setTestPaper", "(ILcom/linktop/constant/TestPaper;)V", "GetSetTestPaper_ILcom_linktop_constant_TestPaper_Handler")]
		public virtual unsafe void SetTestPaper ([global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})][global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})]
		int p0, global::Com.Linktop.Constant.TestPaper? p1)
		{
			const string __id = "setTestPaper.(ILcom/linktop/constant/TestPaper;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_startScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_;
#pragma warning disable 0169
		static Delegate GetStartScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_Handler ()
		{
			if (cb_startScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_ == null)
				cb_startScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_);
			return cb_startScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_;
		}

		static void n_StartScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Linktop.Infs.IOnScanTempListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnScanTempListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartScanTemp (p0!, p1!);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='startScanTemp' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='com.linktop.infs.OnScanTempListener']]"
		[Register ("startScanTemp", "(Landroid/bluetooth/BluetoothDevice;Lcom/linktop/infs/OnScanTempListener;)V", "GetStartScanTemp_Landroid_bluetooth_BluetoothDevice_Lcom_linktop_infs_OnScanTempListener_Handler")]
		public virtual unsafe void StartScanTemp (global::Android.Bluetooth.BluetoothDevice p0, global::Com.Linktop.Infs.IOnScanTempListener p1)
		{
			const string __id = "startScanTemp.(Landroid/bluetooth/BluetoothDevice;Lcom/linktop/infs/OnScanTempListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_stopMeasure;
#pragma warning disable 0169
		static Delegate GetStopMeasureHandler ()
		{
			if (cb_stopMeasure == null)
				cb_stopMeasure = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopMeasure);
			return cb_stopMeasure;
		}

		static void n_StopMeasure (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.StopMeasure ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='stopMeasure' and count(parameter)=0]"
		[Register ("stopMeasure", "()V", "GetStopMeasureHandler")]
		public virtual unsafe void StopMeasure ()
		{
			const string __id = "stopMeasure.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_stopScanTemp;
#pragma warning disable 0169
		static Delegate GetStopScanTempHandler ()
		{
			if (cb_stopScanTemp == null)
				cb_stopScanTemp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopScanTemp);
			return cb_stopScanTemp;
		}

		static void n_StopScanTemp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.StopScanTemp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='stopScanTemp' and count(parameter)=0]"
		[Register ("stopScanTemp", "()V", "GetStopScanTempHandler")]
		public virtual unsafe void StopScanTemp ()
		{
			const string __id = "stopScanTemp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_unBind;
#pragma warning disable 0169
		static Delegate GetUnBindHandler ()
		{
			if (cb_unBind == null)
				cb_unBind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnBind);
			return cb_unBind;
		}

		static void n_UnBind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmission> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.UnBind ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmission']/method[@name='unBind' and count(parameter)=0]"
		[Register ("unBind", "()V", "GetUnBindHandler")]
		public virtual unsafe void UnBind ()
		{
			const string __id = "unBind.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		#region "Event implementation for Com.Linktop.Infs.IOnBatteryListener"

		public event EventHandler BatteryCharging {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetOnBatteryListener,
				__CreateIOnBatteryListenerImplementor,
				SetOnBatteryListener,
				__h => __h.OnBatteryChargingHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetOnBatteryListener,
				global::Com.Linktop.Infs.IOnBatteryListenerImplementor.__IsEmpty,
				__v => SetOnBatteryListener (null),
				__h => __h.OnBatteryChargingHandler -= value);
			}
		}

		public event EventHandler BatteryFull {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetOnBatteryListener,
				__CreateIOnBatteryListenerImplementor,
				SetOnBatteryListener,
				__h => __h.OnBatteryFullHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetOnBatteryListener,
				global::Com.Linktop.Infs.IOnBatteryListenerImplementor.__IsEmpty,
				__v => SetOnBatteryListener (null),
				__h => __h.OnBatteryFullHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.BatteryQueryEventArgs> BatteryQuery {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetOnBatteryListener,
				__CreateIOnBatteryListenerImplementor,
				SetOnBatteryListener,
				__h => __h.OnBatteryQueryHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetOnBatteryListener,
				global::Com.Linktop.Infs.IOnBatteryListenerImplementor.__IsEmpty,
				__v => SetOnBatteryListener (null),
				__h => __h.OnBatteryQueryHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBatteryListener;

		global::Com.Linktop.Infs.IOnBatteryListenerImplementor __CreateIOnBatteryListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBatteryListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnBleConnectListener"

		public event EventHandler BLENoSupported {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				__CreateIOnBleConnectListenerImplementor,
				SetOnBleConnectListener,
				__h => __h.OnBLENoSupportedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				global::Com.Linktop.Infs.IOnBleConnectListenerImplementor.__IsEmpty,
				__v => SetOnBleConnectListener (null),
				__h => __h.OnBLENoSupportedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.BleStateEventArgs> BleStateEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				__CreateIOnBleConnectListenerImplementor,
				SetOnBleConnectListener,
				__h => __h.OnBleStateHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				global::Com.Linktop.Infs.IOnBleConnectListenerImplementor.__IsEmpty,
				__v => SetOnBleConnectListener (null),
				__h => __h.OnBleStateHandler -= value);
			}
		}

		public event EventHandler OpenBLE {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				__CreateIOnBleConnectListenerImplementor,
				SetOnBleConnectListener,
				__h => __h.OnOpenBLEHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				global::Com.Linktop.Infs.IOnBleConnectListenerImplementor.__IsEmpty,
				__v => SetOnBleConnectListener (null),
				__h => __h.OnOpenBLEHandler -= value);
			}
		}

		public event EventHandler UpdateDialogBleList {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				__CreateIOnBleConnectListenerImplementor,
				SetOnBleConnectListener,
				__h => __h.OnUpdateDialogBleListHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBleConnectListener, global::Com.Linktop.Infs.IOnBleConnectListenerImplementor>(
				ref weak_implementor_SetOnBleConnectListener,
				global::Com.Linktop.Infs.IOnBleConnectListenerImplementor.__IsEmpty,
				__v => SetOnBleConnectListener (null),
				__h => __h.OnUpdateDialogBleListHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBleConnectListener;

		global::Com.Linktop.Infs.IOnBleConnectListenerImplementor __CreateIOnBleConnectListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBleConnectListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnBpDataListener"

		public event EventHandler<global::Com.Linktop.Infs.FIRAvgFilterEventArgs> FIRAvgFilter {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				__CreateIOnBpDataListenerImplementor,
				SetOnBpDataListener,
				__h => __h.OnFIRAvgFilterHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				global::Com.Linktop.Infs.IOnBpDataListenerImplementor.__IsEmpty,
				__v => SetOnBpDataListener (null),
				__h => __h.OnFIRAvgFilterHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.RcvPressureEventArgs> RcvPressure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				__CreateIOnBpDataListenerImplementor,
				SetOnBpDataListener,
				__h => __h.OnRcvPressureHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				global::Com.Linktop.Infs.IOnBpDataListenerImplementor.__IsEmpty,
				__v => SetOnBpDataListener (null),
				__h => __h.OnRcvPressureHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBpDataListener;

		global::Com.Linktop.Infs.IOnBpDataListenerImplementor __CreateIOnBpDataListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBpDataListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnBpResultListener"

		public event EventHandler<global::Com.Linktop.Infs.BpResultEventArgs> BpResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				__CreateIOnBpResultListenerImplementor,
				SetOnBpResultListener,
				__h => __h.OnBpResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				global::Com.Linktop.Infs.IOnBpResultListenerImplementor.__IsEmpty,
				__v => SetOnBpResultListener (null),
				__h => __h.OnBpResultHandler -= value);
			}
		}

		public event EventHandler BpResultError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				__CreateIOnBpResultListenerImplementor,
				SetOnBpResultListener,
				__h => __h.OnBpResultErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				global::Com.Linktop.Infs.IOnBpResultListenerImplementor.__IsEmpty,
				__v => SetOnBpResultListener (null),
				__h => __h.OnBpResultErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.LeakErrorEventArgs> LeakError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				__CreateIOnBpResultListenerImplementor,
				SetOnBpResultListener,
				__h => __h.OnLeakErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				global::Com.Linktop.Infs.IOnBpResultListenerImplementor.__IsEmpty,
				__v => SetOnBpResultListener (null),
				__h => __h.OnLeakErrorHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBpResultListener;

		global::Com.Linktop.Infs.IOnBpResultListenerImplementor __CreateIOnBpResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBpResultListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnBtResultListener"

		public event EventHandler<global::Com.Linktop.Infs.BtResultEventArgs> BtResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBtResultListener, global::Com.Linktop.Infs.IOnBtResultListenerImplementor>(
				ref weak_implementor_SetOnBtResultListener,
				__CreateIOnBtResultListenerImplementor,
				SetOnBtResultListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBtResultListener, global::Com.Linktop.Infs.IOnBtResultListenerImplementor>(
				ref weak_implementor_SetOnBtResultListener,
				global::Com.Linktop.Infs.IOnBtResultListenerImplementor.__IsEmpty,
				__v => SetOnBtResultListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBtResultListener;

		global::Com.Linktop.Infs.IOnBtResultListenerImplementor __CreateIOnBtResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBtResultListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnDeviceInfoListener"

		public event EventHandler<global::Com.Linktop.Infs.DeviceInfoEventArgs> DeviceInfo {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDevIdAndKeyListener,
				__CreateIOnDeviceInfoListenerImplementor,
				SetOnDevIdAndKeyListener,
				__h => __h.OnDeviceInfoHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDevIdAndKeyListener,
				global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor.__IsEmpty,
				__v => SetOnDevIdAndKeyListener (null),
				__h => __h.OnDeviceInfoHandler -= value);
			}
		}

		public event EventHandler ReadDeviceInfoFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDevIdAndKeyListener,
				__CreateIOnDeviceInfoListenerImplementor,
				SetOnDevIdAndKeyListener,
				__h => __h.OnReadDeviceInfoFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDevIdAndKeyListener,
				global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor.__IsEmpty,
				__v => SetOnDevIdAndKeyListener (null),
				__h => __h.OnReadDeviceInfoFailedHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnDevIdAndKeyListener;

		global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor __CreateIOnDeviceInfoListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnDeviceVersionListener"

		public event EventHandler<global::Com.Linktop.Infs.DeviceVersionEventArgs> DeviceVersion {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnDeviceVersionListener, global::Com.Linktop.Infs.IOnDeviceVersionListenerImplementor>(
				ref weak_implementor_SetOnDeviceVersionListener,
				__CreateIOnDeviceVersionListenerImplementor,
				SetOnDeviceVersionListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnDeviceVersionListener, global::Com.Linktop.Infs.IOnDeviceVersionListenerImplementor>(
				ref weak_implementor_SetOnDeviceVersionListener,
				global::Com.Linktop.Infs.IOnDeviceVersionListenerImplementor.__IsEmpty,
				__v => SetOnDeviceVersionListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnDeviceVersionListener;

		global::Com.Linktop.Infs.IOnDeviceVersionListenerImplementor __CreateIOnDeviceVersionListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnDeviceVersionListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnHRVResultListener"

		public event EventHandler<global::Com.Linktop.Infs.HRVResultEventArgs> HRVResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				__CreateIOnHRVResultListenerImplementor,
				SetOnHrvResultListener,
				__h => __h.OnHRVResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				global::Com.Linktop.Infs.IOnHRVResultListenerImplementor.__IsEmpty,
				__v => SetOnHrvResultListener (null),
				__h => __h.OnHRVResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.SignalDataEventArgs> SignalData {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				__CreateIOnHRVResultListenerImplementor,
				SetOnHrvResultListener,
				__h => __h.OnSignalDataHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				global::Com.Linktop.Infs.IOnHRVResultListenerImplementor.__IsEmpty,
				__v => SetOnHrvResultListener (null),
				__h => __h.OnSignalDataHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnHrvResultListener;

		global::Com.Linktop.Infs.IOnHRVResultListenerImplementor __CreateIOnHRVResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnHRVResultListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnSpO2ResultListener"

		public event EventHandler SpO2End {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				__CreateIOnSpO2ResultListenerImplementor,
				SetOnSpO2ResultListener,
				__h => __h.OnSpO2EndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor.__IsEmpty,
				__v => SetOnSpO2ResultListener (null),
				__h => __h.OnSpO2EndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.SpO2ResultEventArgs> SpO2Result {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				__CreateIOnSpO2ResultListenerImplementor,
				SetOnSpO2ResultListener,
				__h => __h.OnSpO2ResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor.__IsEmpty,
				__v => SetOnSpO2ResultListener (null),
				__h => __h.OnSpO2ResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.SpO2WaveEventArgs> SpO2Wave {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				__CreateIOnSpO2ResultListenerImplementor,
				SetOnSpO2ResultListener,
				__h => __h.OnSpO2WaveHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor.__IsEmpty,
				__v => SetOnSpO2ResultListener (null),
				__h => __h.OnSpO2WaveHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnSpO2ResultListener;

		global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor __CreateIOnSpO2ResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor (this);
		}

		#endregion

	}
}

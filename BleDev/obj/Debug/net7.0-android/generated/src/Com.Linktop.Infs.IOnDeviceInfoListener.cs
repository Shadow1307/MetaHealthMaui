using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnDeviceInfoListener']"
	[Register ("com/linktop/infs/OnDeviceInfoListener", "", "Com.Linktop.Infs.IOnDeviceInfoListenerInvoker")]
	public partial interface IOnDeviceInfoListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnDeviceInfoListener']/method[@name='onDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.linktop.constant.DeviceInfo']]"
		[Register ("onDeviceInfo", "(Lcom/linktop/constant/DeviceInfo;)V", "GetOnDeviceInfo_Lcom_linktop_constant_DeviceInfo_Handler:Com.Linktop.Infs.IOnDeviceInfoListenerInvoker, BleDev")]
		void OnDeviceInfo (global::Com.Linktop.Constant.DeviceInfo? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnDeviceInfoListener']/method[@name='onReadDeviceInfoFailed' and count(parameter)=0]"
		[Register ("onReadDeviceInfoFailed", "()V", "GetOnReadDeviceInfoFailedHandler:Com.Linktop.Infs.IOnDeviceInfoListenerInvoker, BleDev")]
		void OnReadDeviceInfoFailed ();

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnDeviceInfoListener", DoNotGenerateAcw=true)]
	internal partial class IOnDeviceInfoListenerInvoker : global::Java.Lang.Object, IOnDeviceInfoListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnDeviceInfoListener", typeof (IOnDeviceInfoListenerInvoker));

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

		public static IOnDeviceInfoListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDeviceInfoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnDeviceInfoListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDeviceInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnDeviceInfo_Lcom_linktop_constant_DeviceInfo_Handler ()
		{
			if (cb_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_ == null)
				cb_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDeviceInfo_Lcom_linktop_constant_DeviceInfo_);
			return cb_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_;
		}

		static void n_OnDeviceInfo_Lcom_linktop_constant_DeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnDeviceInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_;
		public unsafe void OnDeviceInfo (global::Com.Linktop.Constant.DeviceInfo? p0)
		{
			if (id_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_ == IntPtr.Zero)
				id_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onDeviceInfo", "(Lcom/linktop/constant/DeviceInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceInfo_Lcom_linktop_constant_DeviceInfo_, __args);
		}

		static Delegate? cb_onReadDeviceInfoFailed;
#pragma warning disable 0169
		static Delegate GetOnReadDeviceInfoFailedHandler ()
		{
			if (cb_onReadDeviceInfoFailed == null)
				cb_onReadDeviceInfoFailed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnReadDeviceInfoFailed);
			return cb_onReadDeviceInfoFailed;
		}

		static void n_OnReadDeviceInfoFailed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnDeviceInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnReadDeviceInfoFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onReadDeviceInfoFailed;
		public unsafe void OnReadDeviceInfoFailed ()
		{
			if (id_onReadDeviceInfoFailed == IntPtr.Zero)
				id_onReadDeviceInfoFailed = JNIEnv.GetMethodID (class_ref, "onReadDeviceInfoFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadDeviceInfoFailed);
		}

	}

	// event args for com.linktop.infs.OnDeviceInfoListener.onDeviceInfo
	public partial class DeviceInfoEventArgs : global::System.EventArgs {
		public DeviceInfoEventArgs (global::Com.Linktop.Constant.DeviceInfo? p0)
		{
			this.p0 = p0;
		}

		global::Com.Linktop.Constant.DeviceInfo? p0;

		public global::Com.Linktop.Constant.DeviceInfo? P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnDeviceInfoListenerImplementor")]
	internal sealed partial class IOnDeviceInfoListenerImplementor : global::Java.Lang.Object, IOnDeviceInfoListener {

		object sender;

		public IOnDeviceInfoListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnDeviceInfoListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<DeviceInfoEventArgs>? OnDeviceInfoHandler;
		#pragma warning restore 0649

		public void OnDeviceInfo (global::Com.Linktop.Constant.DeviceInfo? p0)
		{
			var __h = OnDeviceInfoHandler;
			if (__h != null)
				__h (sender, new DeviceInfoEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler? OnReadDeviceInfoFailedHandler;
		#pragma warning restore 0649

		public void OnReadDeviceInfoFailed ()
		{
			var __h = OnReadDeviceInfoFailedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnDeviceInfoListenerImplementor value)
		{
			return value.OnDeviceInfoHandler == null && value.OnReadDeviceInfoFailedHandler == null;
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnDeviceVersionListener']"
	[Register ("com/linktop/infs/OnDeviceVersionListener", "", "Com.Linktop.Infs.IOnDeviceVersionListenerInvoker")]
	public partial interface IOnDeviceVersionListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnDeviceVersionListener']/method[@name='onDeviceVersion' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onDeviceVersion", "(ILjava/lang/String;)V", "GetOnDeviceVersion_ILjava_lang_String_Handler:Com.Linktop.Infs.IOnDeviceVersionListenerInvoker, BleDev")]
		void OnDeviceVersion ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.IWareType", Fields = new string [] {"VerFirmware", "VerHardware", "VerSoftware"})]
		int p0, string? p1);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnDeviceVersionListener", DoNotGenerateAcw=true)]
	internal partial class IOnDeviceVersionListenerInvoker : global::Java.Lang.Object, IOnDeviceVersionListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnDeviceVersionListener", typeof (IOnDeviceVersionListenerInvoker));

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

		public static IOnDeviceVersionListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDeviceVersionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnDeviceVersionListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDeviceVersionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDeviceVersion_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDeviceVersion_ILjava_lang_String_Handler ()
		{
			if (cb_onDeviceVersion_ILjava_lang_String_ == null)
				cb_onDeviceVersion_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnDeviceVersion_ILjava_lang_String_);
			return cb_onDeviceVersion_ILjava_lang_String_;
		}

		static void n_OnDeviceVersion_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnDeviceVersionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceVersion (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDeviceVersion_ILjava_lang_String_;
		public unsafe void OnDeviceVersion ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.IWareType", Fields = new string [] {"VerFirmware", "VerHardware", "VerSoftware"})]
		int p0, string? p1)
		{
			if (id_onDeviceVersion_ILjava_lang_String_ == IntPtr.Zero)
				id_onDeviceVersion_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDeviceVersion", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceVersion_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.linktop.infs.OnDeviceVersionListener.onDeviceVersion
	public partial class DeviceVersionEventArgs : global::System.EventArgs {
		public DeviceVersionEventArgs (int p0, string? p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		string? p1;

		public string? P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnDeviceVersionListenerImplementor")]
	internal sealed partial class IOnDeviceVersionListenerImplementor : global::Java.Lang.Object, IOnDeviceVersionListener {

		object sender;

		public IOnDeviceVersionListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnDeviceVersionListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<DeviceVersionEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnDeviceVersion ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.IWareType", Fields = new string [] {"VerFirmware", "VerHardware", "VerSoftware"})]
		int p0, string? p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DeviceVersionEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnDeviceVersionListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}

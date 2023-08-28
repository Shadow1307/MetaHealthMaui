using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnThermInfoListener']"
	[Register ("com/linktop/infs/OnThermInfoListener", "", "Com.Linktop.Infs.IOnThermInfoListenerInvoker")]
	public partial interface IOnThermInfoListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnThermInfoListener']/method[@name='onThermQRCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onThermQRCode", "(Ljava/lang/String;)V", "GetOnThermQRCode_Ljava_lang_String_Handler:Com.Linktop.Infs.IOnThermInfoListenerInvoker, BleDev")]
		void OnThermQRCode (string? p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnThermInfoListener", DoNotGenerateAcw=true)]
	internal partial class IOnThermInfoListenerInvoker : global::Java.Lang.Object, IOnThermInfoListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnThermInfoListener", typeof (IOnThermInfoListenerInvoker));

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

		public static IOnThermInfoListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnThermInfoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnThermInfoListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnThermInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onThermQRCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnThermQRCode_Ljava_lang_String_Handler ()
		{
			if (cb_onThermQRCode_Ljava_lang_String_ == null)
				cb_onThermQRCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnThermQRCode_Ljava_lang_String_);
			return cb_onThermQRCode_Ljava_lang_String_;
		}

		static void n_OnThermQRCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnThermInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnThermQRCode (p0);
		}
#pragma warning restore 0169

		IntPtr id_onThermQRCode_Ljava_lang_String_;
		public unsafe void OnThermQRCode (string? p0)
		{
			if (id_onThermQRCode_Ljava_lang_String_ == IntPtr.Zero)
				id_onThermQRCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onThermQRCode", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onThermQRCode_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.linktop.infs.OnThermInfoListener.onThermQRCode
	public partial class ThermInfoEventArgs : global::System.EventArgs {
		public ThermInfoEventArgs (string? p0)
		{
			this.p0 = p0;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnThermInfoListenerImplementor")]
	internal sealed partial class IOnThermInfoListenerImplementor : global::Java.Lang.Object, IOnThermInfoListener {

		object sender;

		public IOnThermInfoListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnThermInfoListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ThermInfoEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnThermQRCode (string? p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ThermInfoEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnThermInfoListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}

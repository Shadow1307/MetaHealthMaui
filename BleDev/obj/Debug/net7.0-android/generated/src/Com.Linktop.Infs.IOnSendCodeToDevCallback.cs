using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnSendCodeToDevCallback']"
	[Register ("com/linktop/infs/OnSendCodeToDevCallback", "", "Com.Linktop.Infs.IOnSendCodeToDevCallbackInvoker")]
	public partial interface IOnSendCodeToDevCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnSendCodeToDevCallback']/method[@name='onReceived' and count(parameter)=0]"
		[Register ("onReceived", "()V", "GetOnReceivedHandler:Com.Linktop.Infs.IOnSendCodeToDevCallbackInvoker, BleDev")]
		void OnReceived ();

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnSendCodeToDevCallback", DoNotGenerateAcw=true)]
	internal partial class IOnSendCodeToDevCallbackInvoker : global::Java.Lang.Object, IOnSendCodeToDevCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnSendCodeToDevCallback", typeof (IOnSendCodeToDevCallbackInvoker));

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

		public static IOnSendCodeToDevCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSendCodeToDevCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnSendCodeToDevCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSendCodeToDevCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onReceived;
#pragma warning disable 0169
		static Delegate GetOnReceivedHandler ()
		{
			if (cb_onReceived == null)
				cb_onReceived = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnReceived);
			return cb_onReceived;
		}

		static void n_OnReceived (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnSendCodeToDevCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnReceived ();
		}
#pragma warning restore 0169

		IntPtr id_onReceived;
		public unsafe void OnReceived ()
		{
			if (id_onReceived == IntPtr.Zero)
				id_onReceived = JNIEnv.GetMethodID (class_ref, "onReceived", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceived);
		}

	}
}

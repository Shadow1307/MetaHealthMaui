using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='AuthCheckResult']"
	[Register ("com/linktop/infs/AuthCheckResult", "", "Com.Linktop.Infs.IAuthCheckResultInvoker")]
	public partial interface IAuthCheckResult : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='AuthCheckResult']/method[@name='onAuthCheckResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onAuthCheckResult", "(Z)V", "GetOnAuthCheckResult_ZHandler:Com.Linktop.Infs.IAuthCheckResultInvoker, BleDev")]
		void OnAuthCheckResult (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='AuthCheckResult']/method[@name='onAuthCheckResultTimeout' and count(parameter)=0]"
		[Register ("onAuthCheckResultTimeout", "()V", "GetOnAuthCheckResultTimeoutHandler:Com.Linktop.Infs.IAuthCheckResultInvoker, BleDev")]
		void OnAuthCheckResultTimeout ();

	}

	[global::Android.Runtime.Register ("com/linktop/infs/AuthCheckResult", DoNotGenerateAcw=true)]
	internal partial class IAuthCheckResultInvoker : global::Java.Lang.Object, IAuthCheckResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/AuthCheckResult", typeof (IAuthCheckResultInvoker));

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

		public static IAuthCheckResult? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthCheckResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.AuthCheckResult'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthCheckResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onAuthCheckResult_Z;
#pragma warning disable 0169
		static Delegate GetOnAuthCheckResult_ZHandler ()
		{
			if (cb_onAuthCheckResult_Z == null)
				cb_onAuthCheckResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnAuthCheckResult_Z);
			return cb_onAuthCheckResult_Z;
		}

		static void n_OnAuthCheckResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IAuthCheckResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnAuthCheckResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAuthCheckResult_Z;
		public unsafe void OnAuthCheckResult (bool p0)
		{
			if (id_onAuthCheckResult_Z == IntPtr.Zero)
				id_onAuthCheckResult_Z = JNIEnv.GetMethodID (class_ref, "onAuthCheckResult", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthCheckResult_Z, __args);
		}

		static Delegate? cb_onAuthCheckResultTimeout;
#pragma warning disable 0169
		static Delegate GetOnAuthCheckResultTimeoutHandler ()
		{
			if (cb_onAuthCheckResultTimeout == null)
				cb_onAuthCheckResultTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAuthCheckResultTimeout);
			return cb_onAuthCheckResultTimeout;
		}

		static void n_OnAuthCheckResultTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IAuthCheckResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnAuthCheckResultTimeout ();
		}
#pragma warning restore 0169

		IntPtr id_onAuthCheckResultTimeout;
		public unsafe void OnAuthCheckResultTimeout ()
		{
			if (id_onAuthCheckResultTimeout == IntPtr.Zero)
				id_onAuthCheckResultTimeout = JNIEnv.GetMethodID (class_ref, "onAuthCheckResultTimeout", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthCheckResultTimeout);
		}

	}
}

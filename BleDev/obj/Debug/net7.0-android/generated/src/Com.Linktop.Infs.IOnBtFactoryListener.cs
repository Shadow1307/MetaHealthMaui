using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBtFactoryListener']"
	[Register ("com/linktop/infs/OnBtFactoryListener", "", "Com.Linktop.Infs.IOnBtFactoryListenerInvoker")]
	public partial interface IOnBtFactoryListener : global::Com.Linktop.Infs.IOnBtResultListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBtFactoryListener']/method[@name='a' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("a", "(DD)V", "GetA_DDHandler:Com.Linktop.Infs.IOnBtFactoryListenerInvoker, BleDev")]
		void A (double p0, double p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBtFactoryListener']/method[@name='b' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("b", "(DD)V", "GetB_DDHandler:Com.Linktop.Infs.IOnBtFactoryListenerInvoker, BleDev")]
		void B (double p0, double p1);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnBtFactoryListener", DoNotGenerateAcw=true)]
	internal partial class IOnBtFactoryListenerInvoker : global::Java.Lang.Object, IOnBtFactoryListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnBtFactoryListener", typeof (IOnBtFactoryListenerInvoker));

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

		public static IOnBtFactoryListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBtFactoryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnBtFactoryListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBtFactoryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_a_DD;
#pragma warning disable 0169
		static Delegate GetA_DDHandler ()
		{
			if (cb_a_DD == null)
				cb_a_DD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDD_V) n_A_DD);
			return cb_a_DD;
		}

		static void n_A_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBtFactoryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_a_DD;
		public unsafe void A (double p0, double p1)
		{
			if (id_a_DD == IntPtr.Zero)
				id_a_DD = JNIEnv.GetMethodID (class_ref, "a", "(DD)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_DD, __args);
		}

		static Delegate? cb_b_DD;
#pragma warning disable 0169
		static Delegate GetB_DDHandler ()
		{
			if (cb_b_DD == null)
				cb_b_DD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDD_V) n_B_DD);
			return cb_b_DD;
		}

		static void n_B_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBtFactoryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.B (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_b_DD;
		public unsafe void B (double p0, double p1)
		{
			if (id_b_DD == IntPtr.Zero)
				id_b_DD = JNIEnv.GetMethodID (class_ref, "b", "(DD)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_DD, __args);
		}

		static Delegate? cb_onBtResult_D;
#pragma warning disable 0169
		static Delegate GetOnBtResult_DHandler ()
		{
			if (cb_onBtResult_D == null)
				cb_onBtResult_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_OnBtResult_D);
			return cb_onBtResult_D;
		}

		static void n_OnBtResult_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBtFactoryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBtResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBtResult_D;
		public unsafe void OnBtResult (double p0)
		{
			if (id_onBtResult_D == IntPtr.Zero)
				id_onBtResult_D = JNIEnv.GetMethodID (class_ref, "onBtResult", "(D)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBtResult_D, __args);
		}

	}
}

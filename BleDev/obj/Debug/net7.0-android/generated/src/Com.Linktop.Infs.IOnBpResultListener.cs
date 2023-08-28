using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBpResultListener']"
	[Register ("com/linktop/infs/OnBpResultListener", "", "Com.Linktop.Infs.IOnBpResultListenerInvoker")]
	public partial interface IOnBpResultListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBpResultListener']/method[@name='onBpResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onBpResult", "(III)V", "GetOnBpResult_IIIHandler:Com.Linktop.Infs.IOnBpResultListenerInvoker, BleDev")]
		void OnBpResult (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBpResultListener']/method[@name='onBpResultError' and count(parameter)=0]"
		[Register ("onBpResultError", "()V", "GetOnBpResultErrorHandler:Com.Linktop.Infs.IOnBpResultListenerInvoker, BleDev")]
		void OnBpResultError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBpResultListener']/method[@name='onLeakError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onLeakError", "(I)V", "GetOnLeakError_IHandler:Com.Linktop.Infs.IOnBpResultListenerInvoker, BleDev")]
		void OnLeakError (int p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnBpResultListener", DoNotGenerateAcw=true)]
	internal partial class IOnBpResultListenerInvoker : global::Java.Lang.Object, IOnBpResultListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnBpResultListener", typeof (IOnBpResultListenerInvoker));

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

		public static IOnBpResultListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBpResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnBpResultListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBpResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onBpResult_III;
#pragma warning disable 0169
		static Delegate GetOnBpResult_IIIHandler ()
		{
			if (cb_onBpResult_III == null)
				cb_onBpResult_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnBpResult_III);
			return cb_onBpResult_III;
		}

		static void n_OnBpResult_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBpResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBpResult (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onBpResult_III;
		public unsafe void OnBpResult (int p0, int p1, int p2)
		{
			if (id_onBpResult_III == IntPtr.Zero)
				id_onBpResult_III = JNIEnv.GetMethodID (class_ref, "onBpResult", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBpResult_III, __args);
		}

		static Delegate? cb_onBpResultError;
#pragma warning disable 0169
		static Delegate GetOnBpResultErrorHandler ()
		{
			if (cb_onBpResultError == null)
				cb_onBpResultError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBpResultError);
			return cb_onBpResultError;
		}

		static void n_OnBpResultError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBpResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBpResultError ();
		}
#pragma warning restore 0169

		IntPtr id_onBpResultError;
		public unsafe void OnBpResultError ()
		{
			if (id_onBpResultError == IntPtr.Zero)
				id_onBpResultError = JNIEnv.GetMethodID (class_ref, "onBpResultError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBpResultError);
		}

		static Delegate? cb_onLeakError_I;
#pragma warning disable 0169
		static Delegate GetOnLeakError_IHandler ()
		{
			if (cb_onLeakError_I == null)
				cb_onLeakError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnLeakError_I);
			return cb_onLeakError_I;
		}

		static void n_OnLeakError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBpResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnLeakError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLeakError_I;
		public unsafe void OnLeakError (int p0)
		{
			if (id_onLeakError_I == IntPtr.Zero)
				id_onLeakError_I = JNIEnv.GetMethodID (class_ref, "onLeakError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLeakError_I, __args);
		}

	}

	// event args for com.linktop.infs.OnBpResultListener.onBpResult
	public partial class BpResultEventArgs : global::System.EventArgs {
		public BpResultEventArgs (int p0, int p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

	}

	// event args for com.linktop.infs.OnBpResultListener.onLeakError
	public partial class LeakErrorEventArgs : global::System.EventArgs {
		public LeakErrorEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnBpResultListenerImplementor")]
	internal sealed partial class IOnBpResultListenerImplementor : global::Java.Lang.Object, IOnBpResultListener {

		object sender;

		public IOnBpResultListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnBpResultListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<BpResultEventArgs>? OnBpResultHandler;
		#pragma warning restore 0649

		public void OnBpResult (int p0, int p1, int p2)
		{
			var __h = OnBpResultHandler;
			if (__h != null)
				__h (sender, new BpResultEventArgs (p0, p1, p2));
		}

		#pragma warning disable 0649
		public EventHandler? OnBpResultErrorHandler;
		#pragma warning restore 0649

		public void OnBpResultError ()
		{
			var __h = OnBpResultErrorHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<LeakErrorEventArgs>? OnLeakErrorHandler;
		#pragma warning restore 0649

		public void OnLeakError (int p0)
		{
			var __h = OnLeakErrorHandler;
			if (__h != null)
				__h (sender, new LeakErrorEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnBpResultListenerImplementor value)
		{
			return value.OnBpResultHandler == null && value.OnBpResultErrorHandler == null && value.OnLeakErrorHandler == null;
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBtResultListener']"
	[Register ("com/linktop/infs/OnBtResultListener", "", "Com.Linktop.Infs.IOnBtResultListenerInvoker")]
	public partial interface IOnBtResultListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBtResultListener']/method[@name='onBtResult' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("onBtResult", "(D)V", "GetOnBtResult_DHandler:Com.Linktop.Infs.IOnBtResultListenerInvoker, BleDev")]
		void OnBtResult (double p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnBtResultListener", DoNotGenerateAcw=true)]
	internal partial class IOnBtResultListenerInvoker : global::Java.Lang.Object, IOnBtResultListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnBtResultListener", typeof (IOnBtResultListenerInvoker));

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

		public static IOnBtResultListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBtResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnBtResultListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBtResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBtResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

	// event args for com.linktop.infs.OnBtResultListener.onBtResult
	public partial class BtResultEventArgs : global::System.EventArgs {
		public BtResultEventArgs (double p0)
		{
			this.p0 = p0;
		}

		double p0;

		public double P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnBtResultListenerImplementor")]
	internal sealed partial class IOnBtResultListenerImplementor : global::Java.Lang.Object, IOnBtResultListener {

		object sender;

		public IOnBtResultListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnBtResultListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<BtResultEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnBtResult (double p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BtResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnBtResultListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnCuffLeakTestListener']"
	[Register ("com/linktop/infs/OnCuffLeakTestListener", "", "Com.Linktop.Infs.IOnCuffLeakTestListenerInvoker")]
	public partial interface IOnCuffLeakTestListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnCuffLeakTestListener']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "GetA_IHandler:Com.Linktop.Infs.IOnCuffLeakTestListenerInvoker, BleDev")]
		void A (int p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnCuffLeakTestListener", DoNotGenerateAcw=true)]
	internal partial class IOnCuffLeakTestListenerInvoker : global::Java.Lang.Object, IOnCuffLeakTestListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnCuffLeakTestListener", typeof (IOnCuffLeakTestListenerInvoker));

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

		public static IOnCuffLeakTestListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCuffLeakTestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnCuffLeakTestListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCuffLeakTestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_a_I;
#pragma warning disable 0169
		static Delegate GetA_IHandler ()
		{
			if (cb_a_I == null)
				cb_a_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_A_I);
			return cb_a_I;
		}

		static void n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnCuffLeakTestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_I;
		public unsafe void A (int p0)
		{
			if (id_a_I == IntPtr.Zero)
				id_a_I = JNIEnv.GetMethodID (class_ref, "a", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_I, __args);
		}

	}

	// event args for com.linktop.infs.OnCuffLeakTestListener.a
	public partial class CuffLeakTestEventArgs : global::System.EventArgs {
		public CuffLeakTestEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnCuffLeakTestListenerImplementor")]
	internal sealed partial class IOnCuffLeakTestListenerImplementor : global::Java.Lang.Object, IOnCuffLeakTestListener {

		object sender;

		public IOnCuffLeakTestListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnCuffLeakTestListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<CuffLeakTestEventArgs>? Handler;
		#pragma warning restore 0649

		public void A (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CuffLeakTestEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnCuffLeakTestListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}

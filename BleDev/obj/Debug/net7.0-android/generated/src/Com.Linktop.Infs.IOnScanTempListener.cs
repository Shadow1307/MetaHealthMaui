using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnScanTempListener']"
	[Register ("com/linktop/infs/OnScanTempListener", "", "Com.Linktop.Infs.IOnScanTempListenerInvoker")]
	public partial interface IOnScanTempListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnScanTempListener']/method[@name='onNoTemp' and count(parameter)=0]"
		[Register ("onNoTemp", "()V", "GetOnNoTempHandler:Com.Linktop.Infs.IOnScanTempListenerInvoker, BleDev")]
		void OnNoTemp ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnScanTempListener']/method[@name='onScanTempResult' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("onScanTempResult", "(Ljava/lang/String;DI)V", "GetOnScanTempResult_Ljava_lang_String_DIHandler:Com.Linktop.Infs.IOnScanTempListenerInvoker, BleDev")]
		void OnScanTempResult (string? p0, double p1, int p2);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnScanTempListener", DoNotGenerateAcw=true)]
	internal partial class IOnScanTempListenerInvoker : global::Java.Lang.Object, IOnScanTempListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnScanTempListener", typeof (IOnScanTempListenerInvoker));

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

		public static IOnScanTempListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnScanTempListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnScanTempListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnScanTempListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onNoTemp;
#pragma warning disable 0169
		static Delegate GetOnNoTempHandler ()
		{
			if (cb_onNoTemp == null)
				cb_onNoTemp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnNoTemp);
			return cb_onNoTemp;
		}

		static void n_OnNoTemp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnScanTempListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnNoTemp ();
		}
#pragma warning restore 0169

		IntPtr id_onNoTemp;
		public unsafe void OnNoTemp ()
		{
			if (id_onNoTemp == IntPtr.Zero)
				id_onNoTemp = JNIEnv.GetMethodID (class_ref, "onNoTemp", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNoTemp);
		}

		static Delegate? cb_onScanTempResult_Ljava_lang_String_DI;
#pragma warning disable 0169
		static Delegate GetOnScanTempResult_Ljava_lang_String_DIHandler ()
		{
			if (cb_onScanTempResult_Ljava_lang_String_DI == null)
				cb_onScanTempResult_Ljava_lang_String_DI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLDI_V) n_OnScanTempResult_Ljava_lang_String_DI);
			return cb_onScanTempResult_Ljava_lang_String_DI;
		}

		static void n_OnScanTempResult_Ljava_lang_String_DI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnScanTempListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScanTempResult (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onScanTempResult_Ljava_lang_String_DI;
		public unsafe void OnScanTempResult (string? p0, double p1, int p2)
		{
			if (id_onScanTempResult_Ljava_lang_String_DI == IntPtr.Zero)
				id_onScanTempResult_Ljava_lang_String_DI = JNIEnv.GetMethodID (class_ref, "onScanTempResult", "(Ljava/lang/String;DI)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanTempResult_Ljava_lang_String_DI, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.linktop.infs.OnScanTempListener.onScanTempResult
	public partial class ScanTempResultEventArgs : global::System.EventArgs {
		public ScanTempResultEventArgs (string? p0, double p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

		double p1;

		public double P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnScanTempListenerImplementor")]
	internal sealed partial class IOnScanTempListenerImplementor : global::Java.Lang.Object, IOnScanTempListener {

		object sender;

		public IOnScanTempListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnScanTempListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler? OnNoTempHandler;
		#pragma warning restore 0649

		public void OnNoTemp ()
		{
			var __h = OnNoTempHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<ScanTempResultEventArgs>? OnScanTempResultHandler;
		#pragma warning restore 0649

		public void OnScanTempResult (string? p0, double p1, int p2)
		{
			var __h = OnScanTempResultHandler;
			if (__h != null)
				__h (sender, new ScanTempResultEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IOnScanTempListenerImplementor value)
		{
			return value.OnNoTempHandler == null && value.OnScanTempResultHandler == null;
		}

	}
}

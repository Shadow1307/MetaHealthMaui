using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnTestPaperResultListener']"
	[Register ("com/linktop/infs/OnTestPaperResultListener", "", "Com.Linktop.Infs.IOnTestPaperResultListenerInvoker")]
	public partial interface IOnTestPaperResultListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnTestPaperResultListener']/method[@name='onTestPaperEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onTestPaperEvent", "(ILjava/lang/Object;)V", "GetOnTestPaperEvent_ILjava_lang_Object_Handler:Com.Linktop.Infs.IOnTestPaperResultListenerInvoker, BleDev")]
		void OnTestPaperEvent (int p0, global::Java.Lang.Object? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnTestPaperResultListener']/method[@name='onTestPaperException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTestPaperException", "(I)V", "GetOnTestPaperException_IHandler:Com.Linktop.Infs.IOnTestPaperResultListenerInvoker, BleDev")]
		void OnTestPaperException (int p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnTestPaperResultListener", DoNotGenerateAcw=true)]
	internal partial class IOnTestPaperResultListenerInvoker : global::Java.Lang.Object, IOnTestPaperResultListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnTestPaperResultListener", typeof (IOnTestPaperResultListenerInvoker));

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

		public static IOnTestPaperResultListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnTestPaperResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnTestPaperResultListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnTestPaperResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onTestPaperEvent_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnTestPaperEvent_ILjava_lang_Object_Handler ()
		{
			if (cb_onTestPaperEvent_ILjava_lang_Object_ == null)
				cb_onTestPaperEvent_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnTestPaperEvent_ILjava_lang_Object_);
			return cb_onTestPaperEvent_ILjava_lang_Object_;
		}

		static void n_OnTestPaperEvent_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnTestPaperResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTestPaperEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onTestPaperEvent_ILjava_lang_Object_;
		public unsafe void OnTestPaperEvent (int p0, global::Java.Lang.Object? p1)
		{
			if (id_onTestPaperEvent_ILjava_lang_Object_ == IntPtr.Zero)
				id_onTestPaperEvent_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onTestPaperEvent", "(ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTestPaperEvent_ILjava_lang_Object_, __args);
		}

		static Delegate? cb_onTestPaperException_I;
#pragma warning disable 0169
		static Delegate GetOnTestPaperException_IHandler ()
		{
			if (cb_onTestPaperException_I == null)
				cb_onTestPaperException_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTestPaperException_I);
			return cb_onTestPaperException_I;
		}

		static void n_OnTestPaperException_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnTestPaperResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnTestPaperException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTestPaperException_I;
		public unsafe void OnTestPaperException (int p0)
		{
			if (id_onTestPaperException_I == IntPtr.Zero)
				id_onTestPaperException_I = JNIEnv.GetMethodID (class_ref, "onTestPaperException", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTestPaperException_I, __args);
		}

	}

	// event args for com.linktop.infs.OnTestPaperResultListener.onTestPaperEvent
	public partial class TestPaperEventEventArgs : global::System.EventArgs {
		public TestPaperEventEventArgs (int p0, global::Java.Lang.Object? p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		global::Java.Lang.Object? p1;

		public global::Java.Lang.Object? P1 {
			get { return p1; }
		}

	}

	// event args for com.linktop.infs.OnTestPaperResultListener.onTestPaperException
	public partial class TestPaperExceptionEventArgs : global::System.EventArgs {
		public TestPaperExceptionEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnTestPaperResultListenerImplementor")]
	internal sealed partial class IOnTestPaperResultListenerImplementor : global::Java.Lang.Object, IOnTestPaperResultListener {

		object sender;

		public IOnTestPaperResultListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnTestPaperResultListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<TestPaperEventEventArgs>? OnTestPaperEventHandler;
		#pragma warning restore 0649

		public void OnTestPaperEvent (int p0, global::Java.Lang.Object? p1)
		{
			var __h = OnTestPaperEventHandler;
			if (__h != null)
				__h (sender, new TestPaperEventEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<TestPaperExceptionEventArgs>? OnTestPaperExceptionHandler;
		#pragma warning restore 0649

		public void OnTestPaperException (int p0)
		{
			var __h = OnTestPaperExceptionHandler;
			if (__h != null)
				__h (sender, new TestPaperExceptionEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnTestPaperResultListenerImplementor value)
		{
			return value.OnTestPaperEventHandler == null && value.OnTestPaperExceptionHandler == null;
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnSpO2ResultListener']"
	[Register ("com/linktop/infs/OnSpO2ResultListener", "", "Com.Linktop.Infs.IOnSpO2ResultListenerInvoker")]
	public partial interface IOnSpO2ResultListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnSpO2ResultListener']/method[@name='onSpO2End' and count(parameter)=0]"
		[Register ("onSpO2End", "()V", "GetOnSpO2EndHandler:Com.Linktop.Infs.IOnSpO2ResultListenerInvoker, BleDev")]
		void OnSpO2End ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnSpO2ResultListener']/method[@name='onSpO2Result' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSpO2Result", "(II)V", "GetOnSpO2Result_IIHandler:Com.Linktop.Infs.IOnSpO2ResultListenerInvoker, BleDev")]
		void OnSpO2Result (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnSpO2ResultListener']/method[@name='onSpO2Wave' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onSpO2Wave", "(I)V", "GetOnSpO2Wave_IHandler:Com.Linktop.Infs.IOnSpO2ResultListenerInvoker, BleDev")]
		void OnSpO2Wave (int p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnSpO2ResultListener", DoNotGenerateAcw=true)]
	internal partial class IOnSpO2ResultListenerInvoker : global::Java.Lang.Object, IOnSpO2ResultListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnSpO2ResultListener", typeof (IOnSpO2ResultListenerInvoker));

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

		public static IOnSpO2ResultListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSpO2ResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnSpO2ResultListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSpO2ResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onSpO2End;
#pragma warning disable 0169
		static Delegate GetOnSpO2EndHandler ()
		{
			if (cb_onSpO2End == null)
				cb_onSpO2End = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSpO2End);
			return cb_onSpO2End;
		}

		static void n_OnSpO2End (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnSpO2ResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnSpO2End ();
		}
#pragma warning restore 0169

		IntPtr id_onSpO2End;
		public unsafe void OnSpO2End ()
		{
			if (id_onSpO2End == IntPtr.Zero)
				id_onSpO2End = JNIEnv.GetMethodID (class_ref, "onSpO2End", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpO2End);
		}

		static Delegate? cb_onSpO2Result_II;
#pragma warning disable 0169
		static Delegate GetOnSpO2Result_IIHandler ()
		{
			if (cb_onSpO2Result_II == null)
				cb_onSpO2Result_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnSpO2Result_II);
			return cb_onSpO2Result_II;
		}

		static void n_OnSpO2Result_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnSpO2ResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnSpO2Result (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSpO2Result_II;
		public unsafe void OnSpO2Result (int p0, int p1)
		{
			if (id_onSpO2Result_II == IntPtr.Zero)
				id_onSpO2Result_II = JNIEnv.GetMethodID (class_ref, "onSpO2Result", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpO2Result_II, __args);
		}

		static Delegate? cb_onSpO2Wave_I;
#pragma warning disable 0169
		static Delegate GetOnSpO2Wave_IHandler ()
		{
			if (cb_onSpO2Wave_I == null)
				cb_onSpO2Wave_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnSpO2Wave_I);
			return cb_onSpO2Wave_I;
		}

		static void n_OnSpO2Wave_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnSpO2ResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnSpO2Wave (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSpO2Wave_I;
		public unsafe void OnSpO2Wave (int p0)
		{
			if (id_onSpO2Wave_I == IntPtr.Zero)
				id_onSpO2Wave_I = JNIEnv.GetMethodID (class_ref, "onSpO2Wave", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpO2Wave_I, __args);
		}

	}

	// event args for com.linktop.infs.OnSpO2ResultListener.onSpO2Result
	public partial class SpO2ResultEventArgs : global::System.EventArgs {
		public SpO2ResultEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

	}

	// event args for com.linktop.infs.OnSpO2ResultListener.onSpO2Wave
	public partial class SpO2WaveEventArgs : global::System.EventArgs {
		public SpO2WaveEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnSpO2ResultListenerImplementor")]
	internal sealed partial class IOnSpO2ResultListenerImplementor : global::Java.Lang.Object, IOnSpO2ResultListener {

		object sender;

		public IOnSpO2ResultListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnSpO2ResultListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler? OnSpO2EndHandler;
		#pragma warning restore 0649

		public void OnSpO2End ()
		{
			var __h = OnSpO2EndHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<SpO2ResultEventArgs>? OnSpO2ResultHandler;
		#pragma warning restore 0649

		public void OnSpO2Result (int p0, int p1)
		{
			var __h = OnSpO2ResultHandler;
			if (__h != null)
				__h (sender, new SpO2ResultEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<SpO2WaveEventArgs>? OnSpO2WaveHandler;
		#pragma warning restore 0649

		public void OnSpO2Wave (int p0)
		{
			var __h = OnSpO2WaveHandler;
			if (__h != null)
				__h (sender, new SpO2WaveEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnSpO2ResultListenerImplementor value)
		{
			return value.OnSpO2EndHandler == null && value.OnSpO2ResultHandler == null && value.OnSpO2WaveHandler == null;
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBatteryListener']"
	[Register ("com/linktop/infs/OnBatteryListener", "", "Com.Linktop.Infs.IOnBatteryListenerInvoker")]
	public partial interface IOnBatteryListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBatteryListener']/method[@name='onBatteryCharging' and count(parameter)=0]"
		[Register ("onBatteryCharging", "()V", "GetOnBatteryChargingHandler:Com.Linktop.Infs.IOnBatteryListenerInvoker, BleDev")]
		void OnBatteryCharging ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBatteryListener']/method[@name='onBatteryFull' and count(parameter)=0]"
		[Register ("onBatteryFull", "()V", "GetOnBatteryFullHandler:Com.Linktop.Infs.IOnBatteryListenerInvoker, BleDev")]
		void OnBatteryFull ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBatteryListener']/method[@name='onBatteryQuery' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onBatteryQuery", "(I)V", "GetOnBatteryQuery_IHandler:Com.Linktop.Infs.IOnBatteryListenerInvoker, BleDev")]
		void OnBatteryQuery (int p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnBatteryListener", DoNotGenerateAcw=true)]
	internal partial class IOnBatteryListenerInvoker : global::Java.Lang.Object, IOnBatteryListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnBatteryListener", typeof (IOnBatteryListenerInvoker));

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

		public static IOnBatteryListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBatteryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnBatteryListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBatteryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onBatteryCharging;
#pragma warning disable 0169
		static Delegate GetOnBatteryChargingHandler ()
		{
			if (cb_onBatteryCharging == null)
				cb_onBatteryCharging = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBatteryCharging);
			return cb_onBatteryCharging;
		}

		static void n_OnBatteryCharging (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBatteryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBatteryCharging ();
		}
#pragma warning restore 0169

		IntPtr id_onBatteryCharging;
		public unsafe void OnBatteryCharging ()
		{
			if (id_onBatteryCharging == IntPtr.Zero)
				id_onBatteryCharging = JNIEnv.GetMethodID (class_ref, "onBatteryCharging", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBatteryCharging);
		}

		static Delegate? cb_onBatteryFull;
#pragma warning disable 0169
		static Delegate GetOnBatteryFullHandler ()
		{
			if (cb_onBatteryFull == null)
				cb_onBatteryFull = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBatteryFull);
			return cb_onBatteryFull;
		}

		static void n_OnBatteryFull (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBatteryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBatteryFull ();
		}
#pragma warning restore 0169

		IntPtr id_onBatteryFull;
		public unsafe void OnBatteryFull ()
		{
			if (id_onBatteryFull == IntPtr.Zero)
				id_onBatteryFull = JNIEnv.GetMethodID (class_ref, "onBatteryFull", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBatteryFull);
		}

		static Delegate? cb_onBatteryQuery_I;
#pragma warning disable 0169
		static Delegate GetOnBatteryQuery_IHandler ()
		{
			if (cb_onBatteryQuery_I == null)
				cb_onBatteryQuery_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnBatteryQuery_I);
			return cb_onBatteryQuery_I;
		}

		static void n_OnBatteryQuery_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBatteryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBatteryQuery (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBatteryQuery_I;
		public unsafe void OnBatteryQuery (int p0)
		{
			if (id_onBatteryQuery_I == IntPtr.Zero)
				id_onBatteryQuery_I = JNIEnv.GetMethodID (class_ref, "onBatteryQuery", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBatteryQuery_I, __args);
		}

	}

	// event args for com.linktop.infs.OnBatteryListener.onBatteryQuery
	public partial class BatteryQueryEventArgs : global::System.EventArgs {
		public BatteryQueryEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnBatteryListenerImplementor")]
	internal sealed partial class IOnBatteryListenerImplementor : global::Java.Lang.Object, IOnBatteryListener {

		object sender;

		public IOnBatteryListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnBatteryListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler? OnBatteryChargingHandler;
		#pragma warning restore 0649

		public void OnBatteryCharging ()
		{
			var __h = OnBatteryChargingHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler? OnBatteryFullHandler;
		#pragma warning restore 0649

		public void OnBatteryFull ()
		{
			var __h = OnBatteryFullHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<BatteryQueryEventArgs>? OnBatteryQueryHandler;
		#pragma warning restore 0649

		public void OnBatteryQuery (int p0)
		{
			var __h = OnBatteryQueryHandler;
			if (__h != null)
				__h (sender, new BatteryQueryEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnBatteryListenerImplementor value)
		{
			return value.OnBatteryChargingHandler == null && value.OnBatteryFullHandler == null && value.OnBatteryQueryHandler == null;
		}

	}
}

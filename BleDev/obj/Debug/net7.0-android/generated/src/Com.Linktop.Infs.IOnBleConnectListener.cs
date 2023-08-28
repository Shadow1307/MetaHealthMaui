using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBleConnectListener']"
	[Register ("com/linktop/infs/OnBleConnectListener", "", "Com.Linktop.Infs.IOnBleConnectListenerInvoker")]
	public partial interface IOnBleConnectListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBleConnectListener']/method[@name='onBLENoSupported' and count(parameter)=0]"
		[Register ("onBLENoSupported", "()V", "GetOnBLENoSupportedHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev")]
		void OnBLENoSupported ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBleConnectListener']/method[@name='onBleState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onBleState", "(I)V", "GetOnBleState_IHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev")]
		void OnBleState (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBleConnectListener']/method[@name='onOpenBLE' and count(parameter)=0]"
		[Register ("onOpenBLE", "()V", "GetOnOpenBLEHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev")]
		void OnOpenBLE ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBleConnectListener']/method[@name='onUpdateDialogBleList' and count(parameter)=0]"
		[Register ("onUpdateDialogBleList", "()V", "GetOnUpdateDialogBleListHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev")]
		void OnUpdateDialogBleList ();

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnBleConnectListener", DoNotGenerateAcw=true)]
	internal partial class IOnBleConnectListenerInvoker : global::Java.Lang.Object, IOnBleConnectListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnBleConnectListener", typeof (IOnBleConnectListenerInvoker));

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

		public static IOnBleConnectListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBleConnectListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnBleConnectListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBleConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onBLENoSupported;
#pragma warning disable 0169
		static Delegate GetOnBLENoSupportedHandler ()
		{
			if (cb_onBLENoSupported == null)
				cb_onBLENoSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBLENoSupported);
			return cb_onBLENoSupported;
		}

		static void n_OnBLENoSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBleConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBLENoSupported ();
		}
#pragma warning restore 0169

		IntPtr id_onBLENoSupported;
		public unsafe void OnBLENoSupported ()
		{
			if (id_onBLENoSupported == IntPtr.Zero)
				id_onBLENoSupported = JNIEnv.GetMethodID (class_ref, "onBLENoSupported", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBLENoSupported);
		}

		static Delegate? cb_onBleState_I;
#pragma warning disable 0169
		static Delegate GetOnBleState_IHandler ()
		{
			if (cb_onBleState_I == null)
				cb_onBleState_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnBleState_I);
			return cb_onBleState_I;
		}

		static void n_OnBleState_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBleConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBleState (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBleState_I;
		public unsafe void OnBleState (int p0)
		{
			if (id_onBleState_I == IntPtr.Zero)
				id_onBleState_I = JNIEnv.GetMethodID (class_ref, "onBleState", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBleState_I, __args);
		}

		static Delegate? cb_onOpenBLE;
#pragma warning disable 0169
		static Delegate GetOnOpenBLEHandler ()
		{
			if (cb_onOpenBLE == null)
				cb_onOpenBLE = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnOpenBLE);
			return cb_onOpenBLE;
		}

		static void n_OnOpenBLE (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBleConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnOpenBLE ();
		}
#pragma warning restore 0169

		IntPtr id_onOpenBLE;
		public unsafe void OnOpenBLE ()
		{
			if (id_onOpenBLE == IntPtr.Zero)
				id_onOpenBLE = JNIEnv.GetMethodID (class_ref, "onOpenBLE", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpenBLE);
		}

		static Delegate? cb_onUpdateDialogBleList;
#pragma warning disable 0169
		static Delegate GetOnUpdateDialogBleListHandler ()
		{
			if (cb_onUpdateDialogBleList == null)
				cb_onUpdateDialogBleList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnUpdateDialogBleList);
			return cb_onUpdateDialogBleList;
		}

		static void n_OnUpdateDialogBleList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBleConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnUpdateDialogBleList ();
		}
#pragma warning restore 0169

		IntPtr id_onUpdateDialogBleList;
		public unsafe void OnUpdateDialogBleList ()
		{
			if (id_onUpdateDialogBleList == IntPtr.Zero)
				id_onUpdateDialogBleList = JNIEnv.GetMethodID (class_ref, "onUpdateDialogBleList", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateDialogBleList);
		}

	}

	// event args for com.linktop.infs.OnBleConnectListener.onBleState
	public partial class BleStateEventArgs : global::System.EventArgs {
		public BleStateEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnBleConnectListenerImplementor")]
	internal sealed partial class IOnBleConnectListenerImplementor : global::Java.Lang.Object, IOnBleConnectListener {

		object sender;

		public IOnBleConnectListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnBleConnectListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler? OnBLENoSupportedHandler;
		#pragma warning restore 0649

		public void OnBLENoSupported ()
		{
			var __h = OnBLENoSupportedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<BleStateEventArgs>? OnBleStateHandler;
		#pragma warning restore 0649

		public void OnBleState (int p0)
		{
			var __h = OnBleStateHandler;
			if (__h != null)
				__h (sender, new BleStateEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler? OnOpenBLEHandler;
		#pragma warning restore 0649

		public void OnOpenBLE ()
		{
			var __h = OnOpenBLEHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler? OnUpdateDialogBleListHandler;
		#pragma warning restore 0649

		public void OnUpdateDialogBleList ()
		{
			var __h = OnUpdateDialogBleListHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnBleConnectListenerImplementor value)
		{
			return value.OnBLENoSupportedHandler == null && value.OnBleStateHandler == null && value.OnOpenBLEHandler == null && value.OnUpdateDialogBleListHandler == null;
		}

	}
}

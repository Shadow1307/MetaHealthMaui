using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBpDataListener']"
	[Register ("com/linktop/infs/OnBpDataListener", "", "Com.Linktop.Infs.IOnBpDataListenerInvoker")]
	public partial interface IOnBpDataListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBpDataListener']/method[@name='onFIRAvgFilter' and count(parameter)=2 and parameter[1][@type='com.linktop.constant.ResultData'] and parameter[2][@type='boolean']]"
		[Register ("onFIRAvgFilter", "(Lcom/linktop/constant/ResultData;Z)V", "GetOnFIRAvgFilter_Lcom_linktop_constant_ResultData_ZHandler:Com.Linktop.Infs.IOnBpDataListenerInvoker, BleDev")]
		void OnFIRAvgFilter (global::Com.Linktop.Constant.ResultData? p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnBpDataListener']/method[@name='onRcvPressure' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onRcvPressure", "(I)V", "GetOnRcvPressure_IHandler:Com.Linktop.Infs.IOnBpDataListenerInvoker, BleDev")]
		void OnRcvPressure (int p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnBpDataListener", DoNotGenerateAcw=true)]
	internal partial class IOnBpDataListenerInvoker : global::Java.Lang.Object, IOnBpDataListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnBpDataListener", typeof (IOnBpDataListenerInvoker));

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

		public static IOnBpDataListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBpDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnBpDataListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBpDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z;
#pragma warning disable 0169
		static Delegate GetOnFIRAvgFilter_Lcom_linktop_constant_ResultData_ZHandler ()
		{
			if (cb_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z == null)
				cb_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnFIRAvgFilter_Lcom_linktop_constant_ResultData_Z);
			return cb_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z;
		}

		static void n_OnFIRAvgFilter_Lcom_linktop_constant_ResultData_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBpDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.ResultData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFIRAvgFilter (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z;
		public unsafe void OnFIRAvgFilter (global::Com.Linktop.Constant.ResultData? p0, bool p1)
		{
			if (id_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z == IntPtr.Zero)
				id_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z = JNIEnv.GetMethodID (class_ref, "onFIRAvgFilter", "(Lcom/linktop/constant/ResultData;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFIRAvgFilter_Lcom_linktop_constant_ResultData_Z, __args);
		}

		static Delegate? cb_onRcvPressure_I;
#pragma warning disable 0169
		static Delegate GetOnRcvPressure_IHandler ()
		{
			if (cb_onRcvPressure_I == null)
				cb_onRcvPressure_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnRcvPressure_I);
			return cb_onRcvPressure_I;
		}

		static void n_OnRcvPressure_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnBpDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnRcvPressure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRcvPressure_I;
		public unsafe void OnRcvPressure (int p0)
		{
			if (id_onRcvPressure_I == IntPtr.Zero)
				id_onRcvPressure_I = JNIEnv.GetMethodID (class_ref, "onRcvPressure", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRcvPressure_I, __args);
		}

	}

	// event args for com.linktop.infs.OnBpDataListener.onFIRAvgFilter
	public partial class FIRAvgFilterEventArgs : global::System.EventArgs {
		public FIRAvgFilterEventArgs (global::Com.Linktop.Constant.ResultData? p0, bool p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Linktop.Constant.ResultData? p0;

		public global::Com.Linktop.Constant.ResultData? P0 {
			get { return p0; }
		}

		bool p1;

		public bool P1 {
			get { return p1; }
		}

	}

	// event args for com.linktop.infs.OnBpDataListener.onRcvPressure
	public partial class RcvPressureEventArgs : global::System.EventArgs {
		public RcvPressureEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnBpDataListenerImplementor")]
	internal sealed partial class IOnBpDataListenerImplementor : global::Java.Lang.Object, IOnBpDataListener {

		object sender;

		public IOnBpDataListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnBpDataListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<FIRAvgFilterEventArgs>? OnFIRAvgFilterHandler;
		#pragma warning restore 0649

		public void OnFIRAvgFilter (global::Com.Linktop.Constant.ResultData? p0, bool p1)
		{
			var __h = OnFIRAvgFilterHandler;
			if (__h != null)
				__h (sender, new FIRAvgFilterEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<RcvPressureEventArgs>? OnRcvPressureHandler;
		#pragma warning restore 0649

		public void OnRcvPressure (int p0)
		{
			var __h = OnRcvPressureHandler;
			if (__h != null)
				__h (sender, new RcvPressureEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnBpDataListenerImplementor value)
		{
			return value.OnFIRAvgFilterHandler == null && value.OnRcvPressureHandler == null;
		}

	}
}

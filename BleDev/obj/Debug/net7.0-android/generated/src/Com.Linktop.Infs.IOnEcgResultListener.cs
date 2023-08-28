using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnEcgResultListener']"
	[Register ("com/linktop/infs/OnEcgResultListener", "", "Com.Linktop.Infs.IOnEcgResultListenerInvoker")]
	public partial interface IOnEcgResultListener : global::Com.Linktop.Infs.IFingerDetector {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnEcgResultListener']/method[@name='onDrawWave' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onDrawWave", "(Ljava/lang/Object;)V", "GetOnDrawWave_Ljava_lang_Object_Handler:Com.Linktop.Infs.IOnEcgResultListenerInvoker, BleDev")]
		void OnDrawWave (global::Java.Lang.Object? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnEcgResultListener']/method[@name='onECGValues' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onECGValues", "(II)V", "GetOnECGValues_IIHandler:Com.Linktop.Infs.IOnEcgResultListenerInvoker, BleDev")]
		void OnECGValues ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.Constants", Fields = new string [] {"EcgKeyHeartAge", "EcgKeyHeartBeat", "EcgKeyHeartRate", "EcgKeyHrv", "EcgKeyMood", "EcgKeyRespiratoryRate", "EcgKeyR2r", "EcgKeyRobustHr", "EcgKeyStress"})]
		int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnEcgResultListener']/method[@name='onSignalQuality' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onSignalQuality", "(I)V", "GetOnSignalQuality_IHandler:Com.Linktop.Infs.IOnEcgResultListenerInvoker, BleDev")]
		void OnSignalQuality ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.Constants", Fields = new string [] {"EcgSqGood", "EcgSqMedium", "EcgSqPoor", "EcgSqNotDetected"})]
		int p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnEcgResultListener", DoNotGenerateAcw=true)]
	internal partial class IOnEcgResultListenerInvoker : global::Java.Lang.Object, IOnEcgResultListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnEcgResultListener", typeof (IOnEcgResultListenerInvoker));

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

		public static IOnEcgResultListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnEcgResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnEcgResultListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnEcgResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDrawWave_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnDrawWave_Ljava_lang_Object_Handler ()
		{
			if (cb_onDrawWave_Ljava_lang_Object_ == null)
				cb_onDrawWave_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDrawWave_Ljava_lang_Object_);
			return cb_onDrawWave_Ljava_lang_Object_;
		}

		static void n_OnDrawWave_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnEcgResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawWave (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDrawWave_Ljava_lang_Object_;
		public unsafe void OnDrawWave (global::Java.Lang.Object? p0)
		{
			if (id_onDrawWave_Ljava_lang_Object_ == IntPtr.Zero)
				id_onDrawWave_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onDrawWave", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawWave_Ljava_lang_Object_, __args);
		}

		static Delegate? cb_onECGValues_II;
#pragma warning disable 0169
		static Delegate GetOnECGValues_IIHandler ()
		{
			if (cb_onECGValues_II == null)
				cb_onECGValues_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnECGValues_II);
			return cb_onECGValues_II;
		}

		static void n_OnECGValues_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnEcgResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnECGValues (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onECGValues_II;
		public unsafe void OnECGValues ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.Constants", Fields = new string [] {"EcgKeyHeartAge", "EcgKeyHeartBeat", "EcgKeyHeartRate", "EcgKeyHrv", "EcgKeyMood", "EcgKeyRespiratoryRate", "EcgKeyR2r", "EcgKeyRobustHr", "EcgKeyStress"})]
		int p0, int p1)
		{
			if (id_onECGValues_II == IntPtr.Zero)
				id_onECGValues_II = JNIEnv.GetMethodID (class_ref, "onECGValues", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onECGValues_II, __args);
		}

		static Delegate? cb_onSignalQuality_I;
#pragma warning disable 0169
		static Delegate GetOnSignalQuality_IHandler ()
		{
			if (cb_onSignalQuality_I == null)
				cb_onSignalQuality_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnSignalQuality_I);
			return cb_onSignalQuality_I;
		}

		static void n_OnSignalQuality_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnEcgResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnSignalQuality (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSignalQuality_I;
		public unsafe void OnSignalQuality ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.Constants", Fields = new string [] {"EcgSqGood", "EcgSqMedium", "EcgSqPoor", "EcgSqNotDetected"})]
		int p0)
		{
			if (id_onSignalQuality_I == IntPtr.Zero)
				id_onSignalQuality_I = JNIEnv.GetMethodID (class_ref, "onSignalQuality", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSignalQuality_I, __args);
		}

		static Delegate? cb_onFingerDetection_Z;
#pragma warning disable 0169
		static Delegate GetOnFingerDetection_ZHandler ()
		{
			if (cb_onFingerDetection_Z == null)
				cb_onFingerDetection_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnFingerDetection_Z);
			return cb_onFingerDetection_Z;
		}

		static void n_OnFingerDetection_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnEcgResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnFingerDetection (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFingerDetection_Z;
		public unsafe void OnFingerDetection (bool p0)
		{
			if (id_onFingerDetection_Z == IntPtr.Zero)
				id_onFingerDetection_Z = JNIEnv.GetMethodID (class_ref, "onFingerDetection", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFingerDetection_Z, __args);
		}

	}
}

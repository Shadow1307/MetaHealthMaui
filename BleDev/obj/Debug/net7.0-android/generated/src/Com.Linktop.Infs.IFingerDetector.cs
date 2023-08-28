using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='IFingerDetector']"
	[Register ("com/linktop/infs/IFingerDetector", "", "Com.Linktop.Infs.IFingerDetectorInvoker")]
	public partial interface IFingerDetector : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='IFingerDetector']/method[@name='onFingerDetection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onFingerDetection", "(Z)V", "GetOnFingerDetection_ZHandler:Com.Linktop.Infs.IFingerDetectorInvoker, BleDev")]
		void OnFingerDetection (bool p0);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/IFingerDetector", DoNotGenerateAcw=true)]
	internal partial class IFingerDetectorInvoker : global::Java.Lang.Object, IFingerDetector {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/IFingerDetector", typeof (IFingerDetectorInvoker));

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

		public static IFingerDetector? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFingerDetector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.IFingerDetector'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFingerDetectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IFingerDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

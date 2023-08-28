using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Infs {

	[Register ("com/linktop/infs/OnHRVResultListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Linktop.Infs.IOnHRVResultListener' type. This class will be removed in a future release.")]
	public abstract class OnHRVResultListener : Java.Lang.Object {
		internal OnHRVResultListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_FATIGUE_INDEX']"
		[Register ("KEY_FATIGUE_INDEX")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Infs.IOnHRVResultListener.KeyFatigueIndex'. This class will be removed in a future release.")]
		public const int KeyFatigueIndex = (int) 605;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_HBI_COUNT']"
		[Register ("KEY_HBI_COUNT")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Infs.IOnHRVResultListener.KeyHbiCount'. This class will be removed in a future release.")]
		public const int KeyHbiCount = (int) 606;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_LF_HF']"
		[Register ("KEY_LF_HF")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Infs.IOnHRVResultListener.KeyLfHf'. This class will be removed in a future release.")]
		public const int KeyLfHf = (int) 607;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_MEAN_HR']"
		[Register ("KEY_MEAN_HR")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Infs.IOnHRVResultListener.KeyMeanHr'. This class will be removed in a future release.")]
		public const int KeyMeanHr = (int) 601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_PSI']"
		[Register ("KEY_PSI")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Infs.IOnHRVResultListener.KeyPsi'. This class will be removed in a future release.")]
		public const int KeyPsi = (int) 604;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_RMSSD']"
		[Register ("KEY_RMSSD")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Infs.IOnHRVResultListener.KeyRmssd'. This class will be removed in a future release.")]
		public const int KeyRmssd = (int) 603;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_SDNN']"
		[Register ("KEY_SDNN")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Infs.IOnHRVResultListener.KeySdnn'. This class will be removed in a future release.")]
		public const int KeySdnn = (int) 602;

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']"
	[Register ("com/linktop/infs/OnHRVResultListener", "", "Com.Linktop.Infs.IOnHRVResultListenerInvoker")]
	public partial interface IOnHRVResultListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_FATIGUE_INDEX']"
		[Register ("KEY_FATIGUE_INDEX")]
		public const int KeyFatigueIndex = (int) 605;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_HBI_COUNT']"
		[Register ("KEY_HBI_COUNT")]
		public const int KeyHbiCount = (int) 606;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_LF_HF']"
		[Register ("KEY_LF_HF")]
		public const int KeyLfHf = (int) 607;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_MEAN_HR']"
		[Register ("KEY_MEAN_HR")]
		public const int KeyMeanHr = (int) 601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_PSI']"
		[Register ("KEY_PSI")]
		public const int KeyPsi = (int) 604;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_RMSSD']"
		[Register ("KEY_RMSSD")]
		public const int KeyRmssd = (int) 603;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/field[@name='KEY_SDNN']"
		[Register ("KEY_SDNN")]
		public const int KeySdnn = (int) 602;

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/method[@name='onHRVResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onHRVResult", "(ILjava/lang/Object;)V", "GetOnHRVResult_ILjava_lang_Object_Handler:Com.Linktop.Infs.IOnHRVResultListenerInvoker, BleDev")]
		void OnHRVResult (int p0, global::Java.Lang.Object? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.infs']/interface[@name='OnHRVResultListener']/method[@name='onSignalData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSignalData", "(II)V", "GetOnSignalData_IIHandler:Com.Linktop.Infs.IOnHRVResultListenerInvoker, BleDev")]
		void OnSignalData (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/linktop/infs/OnHRVResultListener", DoNotGenerateAcw=true)]
	internal partial class IOnHRVResultListenerInvoker : global::Java.Lang.Object, IOnHRVResultListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/infs/OnHRVResultListener", typeof (IOnHRVResultListenerInvoker));

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

		public static IOnHRVResultListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnHRVResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.infs.OnHRVResultListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnHRVResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onHRVResult_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnHRVResult_ILjava_lang_Object_Handler ()
		{
			if (cb_onHRVResult_ILjava_lang_Object_ == null)
				cb_onHRVResult_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnHRVResult_ILjava_lang_Object_);
			return cb_onHRVResult_ILjava_lang_Object_;
		}

		static void n_OnHRVResult_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnHRVResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnHRVResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onHRVResult_ILjava_lang_Object_;
		public unsafe void OnHRVResult (int p0, global::Java.Lang.Object? p1)
		{
			if (id_onHRVResult_ILjava_lang_Object_ == IntPtr.Zero)
				id_onHRVResult_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onHRVResult", "(ILjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHRVResult_ILjava_lang_Object_, __args);
		}

		static Delegate? cb_onSignalData_II;
#pragma warning disable 0169
		static Delegate GetOnSignalData_IIHandler ()
		{
			if (cb_onSignalData_II == null)
				cb_onSignalData_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnSignalData_II);
			return cb_onSignalData_II;
		}

		static void n_OnSignalData_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnHRVResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnSignalData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSignalData_II;
		public unsafe void OnSignalData (int p0, int p1)
		{
			if (id_onSignalData_II == IntPtr.Zero)
				id_onSignalData_II = JNIEnv.GetMethodID (class_ref, "onSignalData", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSignalData_II, __args);
		}

	}

	// event args for com.linktop.infs.OnHRVResultListener.onHRVResult
	public partial class HRVResultEventArgs : global::System.EventArgs {
		public HRVResultEventArgs (int p0, global::Java.Lang.Object? p1)
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

	// event args for com.linktop.infs.OnHRVResultListener.onSignalData
	public partial class SignalDataEventArgs : global::System.EventArgs {
		public SignalDataEventArgs (int p0, int p1)
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

	[global::Android.Runtime.Register ("mono/com/linktop/infs/OnHRVResultListenerImplementor")]
	internal sealed partial class IOnHRVResultListenerImplementor : global::Java.Lang.Object, IOnHRVResultListener {

		object sender;

		public IOnHRVResultListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/linktop/infs/OnHRVResultListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<HRVResultEventArgs>? OnHRVResultHandler;
		#pragma warning restore 0649

		public void OnHRVResult (int p0, global::Java.Lang.Object? p1)
		{
			var __h = OnHRVResultHandler;
			if (__h != null)
				__h (sender, new HRVResultEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<SignalDataEventArgs>? OnSignalDataHandler;
		#pragma warning restore 0649

		public void OnSignalData (int p0, int p1)
		{
			var __h = OnSignalDataHandler;
			if (__h != null)
				__h (sender, new SignalDataEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnHRVResultListenerImplementor value)
		{
			return value.OnHRVResultHandler == null && value.OnSignalDataHandler == null;
		}

	}
}

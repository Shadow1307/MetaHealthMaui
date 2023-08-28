using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService {

	[Register ("com/linktop/whealthService/MeasureType", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Linktop.WhealthService.IMeasureType' type. This class will be removed in a future release.")]
	public abstract class MeasureType : Java.Lang.Object {
		internal MeasureType ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='BG']"
		[Register ("BG")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Bg'. This class will be removed in a future release.")]
		public const int Bg = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='BP']"
		[Register ("BP")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Bp'. This class will be removed in a future release.")]
		public const int Bp = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='BT']"
		[Register ("BT")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Bt'. This class will be removed in a future release.")]
		public const int Bt = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='CHOL']"
		[Register ("CHOL")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Chol'. This class will be removed in a future release.")]
		public const int Chol = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='ECG']"
		[Register ("ECG")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Ecg'. This class will be removed in a future release.")]
		public const int Ecg = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='HRV']"
		[Register ("HRV")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Hrv'. This class will be removed in a future release.")]
		public const int Hrv = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='SPO2']"
		[Register ("SPO2")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Spo2'. This class will be removed in a future release.")]
		public const int Spo2 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='UA']"
		[Register ("UA")]
		[global::System.Obsolete (@"Use 'Com.Linktop.WhealthService.IMeasureType.Ua'. This class will be removed in a future release.")]
		public const int Ua = (int) 8;

		// The following are fields from: java.lang.annotation.Annotation

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable

		// The following are fields from: Java.Interop.IJavaPeerable

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']"
	[Register ("com/linktop/whealthService/MeasureType", "", "Com.Linktop.WhealthService.IMeasureTypeInvoker")]
	public partial interface IMeasureType : global::Java.Lang.Annotation.IAnnotation {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='BG']"
		[Register ("BG")]
		public const int Bg = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='BP']"
		[Register ("BP")]
		public const int Bp = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='BT']"
		[Register ("BT")]
		public const int Bt = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='CHOL']"
		[Register ("CHOL")]
		public const int Chol = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='ECG']"
		[Register ("ECG")]
		public const int Ecg = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='HRV']"
		[Register ("HRV")]
		public const int Hrv = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='SPO2']"
		[Register ("SPO2")]
		public const int Spo2 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='MeasureType']/field[@name='UA']"
		[Register ("UA")]
		public const int Ua = (int) 8;

	}

	[global::Android.Runtime.Register ("com/linktop/whealthService/MeasureType", DoNotGenerateAcw=true)]
	internal partial class IMeasureTypeInvoker : global::Java.Lang.Object, IMeasureType {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/MeasureType", typeof (IMeasureTypeInvoker));

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

		public static IMeasureType? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMeasureType> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.whealthService.MeasureType'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMeasureTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.IMeasureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class? AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.IMeasureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe bool Equals (global::Java.Lang.Object? obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate? cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.IMeasureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate? cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.IMeasureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string? ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Constant {

	[Register ("com/linktop/constant/IUserProfile", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Linktop.Constant.IUserProfile' type. This class will be removed in a future release.")]
	public abstract class UserProfile : Java.Lang.Object {
		internal UserProfile ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/field[@name='FEMALE']"
		[Register ("FEMALE")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Constant.IUserProfile.Female'. This class will be removed in a future release.")]
		public const int Female = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/field[@name='MALE']"
		[Register ("MALE")]
		[global::System.Obsolete (@"Use 'Com.Linktop.Constant.IUserProfile.Male'. This class will be removed in a future release.")]
		public const int Male = (int) 1;

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']"
	[Register ("com/linktop/constant/IUserProfile", "", "Com.Linktop.Constant.IUserProfileInvoker")]
	public partial interface IUserProfile : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/field[@name='FEMALE']"
		[Register ("FEMALE")]
		public const int Female = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/field[@name='MALE']"
		[Register ("MALE")]
		public const int Male = (int) 1;

		long Birthday {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/method[@name='getBirthday' and count(parameter)=0]"
			[Register ("getBirthday", "()J", "GetGetBirthdayHandler:Com.Linktop.Constant.IUserProfileInvoker, BleDev")]
			get; 
		}

		int Gender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/method[@name='getGender' and count(parameter)=0]"
			[Register ("getGender", "()I", "GetGetGenderHandler:Com.Linktop.Constant.IUserProfileInvoker, BleDev")]
			get; 
		}

		int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler:Com.Linktop.Constant.IUserProfileInvoker, BleDev")]
			get; 
		}

		string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler:Com.Linktop.Constant.IUserProfileInvoker, BleDev")]
			get; 
		}

		int Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/interface[@name='IUserProfile']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()I", "GetGetWeightHandler:Com.Linktop.Constant.IUserProfileInvoker, BleDev")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/linktop/constant/IUserProfile", DoNotGenerateAcw=true)]
	internal partial class IUserProfileInvoker : global::Java.Lang.Object, IUserProfile {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/constant/IUserProfile", typeof (IUserProfileInvoker));

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

		public static IUserProfile? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUserProfile> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.constant.IUserProfile'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUserProfileInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getBirthday;
#pragma warning disable 0169
		static Delegate GetGetBirthdayHandler ()
		{
			if (cb_getBirthday == null)
				cb_getBirthday = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetBirthday);
			return cb_getBirthday;
		}

		static long n_GetBirthday (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Birthday;
		}
#pragma warning restore 0169

		IntPtr id_getBirthday;
		public unsafe long Birthday {
			get {
				if (id_getBirthday == IntPtr.Zero)
					id_getBirthday = JNIEnv.GetMethodID (class_ref, "getBirthday", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBirthday);
			}
		}

		static Delegate? cb_getGender;
#pragma warning disable 0169
		static Delegate GetGetGenderHandler ()
		{
			if (cb_getGender == null)
				cb_getGender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetGender);
			return cb_getGender;
		}

		static int n_GetGender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Gender;
		}
#pragma warning restore 0169

		IntPtr id_getGender;
		public unsafe int Gender {
			get {
				if (id_getGender == IntPtr.Zero)
					id_getGender = JNIEnv.GetMethodID (class_ref, "getGender", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGender);
			}
		}

		static Delegate? cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public unsafe int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
			}
		}

		static Delegate? cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		IntPtr id_getUsername;
		public unsafe string Username {
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsername), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getWeight;
#pragma warning disable 0169
		static Delegate GetGetWeightHandler ()
		{
			if (cb_getWeight == null)
				cb_getWeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWeight);
			return cb_getWeight;
		}

		static int n_GetWeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Weight;
		}
#pragma warning restore 0169

		IntPtr id_getWeight;
		public unsafe int Weight {
			get {
				if (id_getWeight == IntPtr.Zero)
					id_getWeight = JNIEnv.GetMethodID (class_ref, "getWeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWeight);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/util/Communicate", DoNotGenerateAcw=true)]
	public partial class Communicate : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/util/Communicate", typeof (Communicate));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Communicate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/constructor[@name='Communicate' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe Communicate (global::Com.Linktop.WhealthService.Util.IBleDev? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/linktop/whealthService/util/IBleDev;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_a_BarrayB;
#pragma warning disable 0169
		static Delegate GetA_BarrayBHandler ()
		{
			if (cb_a_BarrayB == null)
				cb_a_BarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPBL_V) n_A_BarrayB);
			return cb_a_BarrayB;
		}

		static void n_A_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.A (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='a' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("a", "(B[B)V", "GetA_BarrayBHandler")]
		public virtual unsafe void A (sbyte p0, byte[]? p1)
		{
			const string __id = "a.(B[B)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_a_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_io_File_Handler ()
		{
			if (cb_a_Ljava_io_File_ == null)
				cb_a_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_Ljava_io_File_);
			return cb_a_Ljava_io_File_;
		}

		static void n_A_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("a", "(Ljava/io/File;)V", "GetA_Ljava_io_File_Handler")]
		public virtual unsafe void A (global::Java.IO.File? p0)
		{
			const string __id = "a.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_authCheck_Lcom_linktop_infs_AuthCheckResult_;
#pragma warning disable 0169
		static Delegate GetAuthCheck_Lcom_linktop_infs_AuthCheckResult_Handler ()
		{
			if (cb_authCheck_Lcom_linktop_infs_AuthCheckResult_ == null)
				cb_authCheck_Lcom_linktop_infs_AuthCheckResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AuthCheck_Lcom_linktop_infs_AuthCheckResult_);
			return cb_authCheck_Lcom_linktop_infs_AuthCheckResult_;
		}

		static void n_AuthCheck_Lcom_linktop_infs_AuthCheckResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IAuthCheckResult?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IAuthCheckResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthCheck (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='authCheck' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.AuthCheckResult']]"
		[Register ("authCheck", "(Lcom/linktop/infs/AuthCheckResult;)V", "GetAuthCheck_Lcom_linktop_infs_AuthCheckResult_Handler")]
		public virtual unsafe void AuthCheck (global::Com.Linktop.Infs.IAuthCheckResult? p0)
		{
			const string __id = "authCheck.(Lcom/linktop/infs/AuthCheckResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_b_Z;
#pragma warning disable 0169
		static Delegate GetB_ZHandler ()
		{
			if (cb_b_Z == null)
				cb_b_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_B_Z);
			return cb_b_Z;
		}

		static void n_B_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.B (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)V", "GetB_ZHandler")]
		public virtual unsafe void B (bool p0)
		{
			const string __id = "b.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_needDeviceAuthCheck;
#pragma warning disable 0169
		static Delegate GetNeedDeviceAuthCheckHandler ()
		{
			if (cb_needDeviceAuthCheck == null)
				cb_needDeviceAuthCheck = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NeedDeviceAuthCheck);
			return cb_needDeviceAuthCheck;
		}

		static bool n_NeedDeviceAuthCheck (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NeedDeviceAuthCheck ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='needDeviceAuthCheck' and count(parameter)=0]"
		[Register ("needDeviceAuthCheck", "()Z", "GetNeedDeviceAuthCheckHandler")]
		public virtual unsafe bool NeedDeviceAuthCheck ()
		{
			const string __id = "needDeviceAuthCheck.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_;
#pragma warning disable 0169
		static Delegate GetNeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_Handler ()
		{
			if (cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_ == null)
				cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_NeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_);
			return cb_needDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_;
		}

		static void n_NeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IAuthCheckResult?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IAuthCheckResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NeedDeviceAuthCheck (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='needDeviceAuthCheck' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.AuthCheckResult']]"
		[Register ("needDeviceAuthCheck", "(Lcom/linktop/infs/AuthCheckResult;)V", "GetNeedDeviceAuthCheck_Lcom_linktop_infs_AuthCheckResult_Handler")]
		public virtual unsafe void NeedDeviceAuthCheck (global::Com.Linktop.Infs.IAuthCheckResult? p0)
		{
			const string __id = "needDeviceAuthCheck.(Lcom/linktop/infs/AuthCheckResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_packageParse_arrayB;
#pragma warning disable 0169
		static Delegate GetPackageParse_arrayBHandler ()
		{
			if (cb_packageParse_arrayB == null)
				cb_packageParse_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PackageParse_arrayB);
			return cb_packageParse_arrayB;
		}

		static void n_PackageParse_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PackageParse (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/class[@name='Communicate']/method[@name='packageParse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("packageParse", "([B)V", "GetPackageParse_arrayBHandler")]
		public virtual unsafe void PackageParse (byte[]? p0)
		{
			const string __id = "packageParse.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}

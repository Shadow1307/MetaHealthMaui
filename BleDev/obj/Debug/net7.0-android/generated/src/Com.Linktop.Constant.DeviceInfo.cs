using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Constant {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']"
	[global::Android.Runtime.Register ("com/linktop/constant/DeviceInfo", DoNotGenerateAcw=true)]
	public partial class DeviceInfo : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/constant/DeviceInfo", typeof (DeviceInfo));

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

		protected DeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/constructor[@name='DeviceInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/constructor[@name='DeviceInfo' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DeviceInfo (string? p0, string? p1, string? p2, string? p3, string? p4, string? p5, string? p6, string? p7) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
			IntPtr native_p6 = JNIEnv.NewString ((string?)p6);
			IntPtr native_p7 = JNIEnv.NewString ((string?)p7);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static Delegate? cb_getAKey;
#pragma warning disable 0169
		static Delegate GetGetAKeyHandler ()
		{
			if (cb_getAKey == null)
				cb_getAKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAKey);
			return cb_getAKey;
		}

		static IntPtr n_GetAKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AKey);
		}
#pragma warning restore 0169

		static Delegate? cb_setAKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAKey_Ljava_lang_String_Handler ()
		{
			if (cb_setAKey_Ljava_lang_String_ == null)
				cb_setAKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAKey_Ljava_lang_String_);
			return cb_setAKey_Ljava_lang_String_;
		}

		static void n_SetAKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AKey = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? AKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getAKey' and count(parameter)=0]"
			[Register ("getAKey", "()Ljava/lang/String;", "GetGetAKeyHandler")]
			get {
				const string __id = "getAKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setAKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAKey", "(Ljava/lang/String;)V", "GetSetAKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAKey.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		static Delegate? cb_setDeviceId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceId_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceId_Ljava_lang_String_ == null)
				cb_setDeviceId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceId_Ljava_lang_String_);
			return cb_setDeviceId_Ljava_lang_String_;
		}

		static void n_SetDeviceId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				const string __id = "getDeviceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setDeviceId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceId", "(Ljava/lang/String;)V", "GetSetDeviceId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getDeviceKey;
#pragma warning disable 0169
		static Delegate GetGetDeviceKeyHandler ()
		{
			if (cb_getDeviceKey == null)
				cb_getDeviceKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceKey);
			return cb_getDeviceKey;
		}

		static IntPtr n_GetDeviceKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DeviceKey);
		}
#pragma warning restore 0169

		static Delegate? cb_setDeviceKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceKey_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceKey_Ljava_lang_String_ == null)
				cb_setDeviceKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceKey_Ljava_lang_String_);
			return cb_setDeviceKey_Ljava_lang_String_;
		}

		static void n_SetDeviceKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceKey = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? DeviceKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getDeviceKey' and count(parameter)=0]"
			[Register ("getDeviceKey", "()Ljava/lang/String;", "GetGetDeviceKeyHandler")]
			get {
				const string __id = "getDeviceKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setDeviceKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceKey", "(Ljava/lang/String;)V", "GetSetDeviceKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceKey.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DeviceType);
		}
#pragma warning restore 0169

		static Delegate? cb_setDeviceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceType_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceType_Ljava_lang_String_ == null)
				cb_setDeviceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceType_Ljava_lang_String_);
			return cb_setDeviceType_Ljava_lang_String_;
		}

		static void n_SetDeviceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Ljava/lang/String;", "GetGetDeviceTypeHandler")]
			get {
				const string __id = "getDeviceType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setDeviceType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceType", "(Ljava/lang/String;)V", "GetSetDeviceType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getFactory;
#pragma warning disable 0169
		static Delegate GetGetFactoryHandler ()
		{
			if (cb_getFactory == null)
				cb_getFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFactory);
			return cb_getFactory;
		}

		static IntPtr n_GetFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Factory);
		}
#pragma warning restore 0169

		static Delegate? cb_setFactory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFactory_Ljava_lang_String_Handler ()
		{
			if (cb_setFactory_Ljava_lang_String_ == null)
				cb_setFactory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFactory_Ljava_lang_String_);
			return cb_setFactory_Ljava_lang_String_;
		}

		static void n_SetFactory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Factory = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getFactory' and count(parameter)=0]"
			[Register ("getFactory", "()Ljava/lang/String;", "GetGetFactoryHandler")]
			get {
				const string __id = "getFactory.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setFactory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFactory", "(Ljava/lang/String;)V", "GetSetFactory_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFactory.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getProdMonth;
#pragma warning disable 0169
		static Delegate GetGetProdMonthHandler ()
		{
			if (cb_getProdMonth == null)
				cb_getProdMonth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProdMonth);
			return cb_getProdMonth;
		}

		static IntPtr n_GetProdMonth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ProdMonth);
		}
#pragma warning restore 0169

		static Delegate? cb_setProdMonth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProdMonth_Ljava_lang_String_Handler ()
		{
			if (cb_setProdMonth_Ljava_lang_String_ == null)
				cb_setProdMonth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProdMonth_Ljava_lang_String_);
			return cb_setProdMonth_Ljava_lang_String_;
		}

		static void n_SetProdMonth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProdMonth = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? ProdMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getProdMonth' and count(parameter)=0]"
			[Register ("getProdMonth", "()Ljava/lang/String;", "GetGetProdMonthHandler")]
			get {
				const string __id = "getProdMonth.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setProdMonth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdMonth", "(Ljava/lang/String;)V", "GetSetProdMonth_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProdMonth.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getProdYear;
#pragma warning disable 0169
		static Delegate GetGetProdYearHandler ()
		{
			if (cb_getProdYear == null)
				cb_getProdYear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProdYear);
			return cb_getProdYear;
		}

		static IntPtr n_GetProdYear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ProdYear);
		}
#pragma warning restore 0169

		static Delegate? cb_setProdYear_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProdYear_Ljava_lang_String_Handler ()
		{
			if (cb_setProdYear_Ljava_lang_String_ == null)
				cb_setProdYear_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProdYear_Ljava_lang_String_);
			return cb_setProdYear_Ljava_lang_String_;
		}

		static void n_SetProdYear_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProdYear = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? ProdYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getProdYear' and count(parameter)=0]"
			[Register ("getProdYear", "()Ljava/lang/String;", "GetGetProdYearHandler")]
			get {
				const string __id = "getProdYear.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setProdYear' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdYear", "(Ljava/lang/String;)V", "GetSetProdYear_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProdYear.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getReserved;
#pragma warning disable 0169
		static Delegate GetGetReservedHandler ()
		{
			if (cb_getReserved == null)
				cb_getReserved = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReserved);
			return cb_getReserved;
		}

		static IntPtr n_GetReserved (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Reserved);
		}
#pragma warning restore 0169

		static Delegate? cb_setReserved_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReserved_Ljava_lang_String_Handler ()
		{
			if (cb_setReserved_Ljava_lang_String_ == null)
				cb_setReserved_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReserved_Ljava_lang_String_);
			return cb_setReserved_Ljava_lang_String_;
		}

		static void n_SetReserved_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Reserved = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string? Reserved {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='getReserved' and count(parameter)=0]"
			[Register ("getReserved", "()Ljava/lang/String;", "GetGetReservedHandler")]
			get {
				const string __id = "getReserved.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setReserved' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReserved", "(Ljava/lang/String;)V", "GetSetReserved_Ljava_lang_String_Handler")]
			set {
				const string __id = "setReserved.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_setDeviceInfo_Lcom_linktop_constant_DeviceInfo_;
#pragma warning disable 0169
		static Delegate GetSetDeviceInfo_Lcom_linktop_constant_DeviceInfo_Handler ()
		{
			if (cb_setDeviceInfo_Lcom_linktop_constant_DeviceInfo_ == null)
				cb_setDeviceInfo_Lcom_linktop_constant_DeviceInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceInfo_Lcom_linktop_constant_DeviceInfo_);
			return cb_setDeviceInfo_Lcom_linktop_constant_DeviceInfo_;
		}

		static void n_SetDeviceInfo_Lcom_linktop_constant_DeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.DeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='DeviceInfo']/method[@name='setDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.linktop.constant.DeviceInfo']]"
		[Register ("setDeviceInfo", "(Lcom/linktop/constant/DeviceInfo;)V", "GetSetDeviceInfo_Lcom_linktop_constant_DeviceInfo_Handler")]
		public virtual unsafe void SetDeviceInfo (global::Com.Linktop.Constant.DeviceInfo? p0)
		{
			const string __id = "setDeviceInfo.(Lcom/linktop/constant/DeviceInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}

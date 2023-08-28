using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/TestPaperTask", DoNotGenerateAcw=true)]
	public partial class TestPaperTask : global::Com.Linktop.WhealthService.Task.HcModuleTask {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EVENT_BLOOD_SAMPLE_DETECTING']"
		[Register ("EVENT_BLOOD_SAMPLE_DETECTING")]
		public const int EventBloodSampleDetecting = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EVENT_PAPER_IN']"
		[Register ("EVENT_PAPER_IN")]
		public const int EventPaperIn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EVENT_PAPER_READ']"
		[Register ("EVENT_PAPER_READ")]
		public const int EventPaperRead = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EVENT_TEST_RESULT']"
		[Register ("EVENT_TEST_RESULT")]
		public const int EventTestResult = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EVENT_TEST_RESULT_FAC']"
		[Register ("EVENT_TEST_RESULT_FAC")]
		public const int EventTestResultFac = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EXCEPTION_DEVICE_ERROR']"
		[Register ("EXCEPTION_DEVICE_ERROR")]
		public const int ExceptionDeviceError = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EXCEPTION_PAPER_OUT']"
		[Register ("EXCEPTION_PAPER_OUT")]
		public const int ExceptionPaperOut = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EXCEPTION_PAPER_USED']"
		[Register ("EXCEPTION_PAPER_USED")]
		public const int ExceptionPaperUsed = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EXCEPTION_TESTING_PAPER_OUT']"
		[Register ("EXCEPTION_TESTING_PAPER_OUT")]
		public const int ExceptionTestingPaperOut = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EXCEPTION_TIMEOUT_FOR_CHECK_PAPER_IN']"
		[Register ("EXCEPTION_TIMEOUT_FOR_CHECK_PAPER_IN")]
		public const int ExceptionTimeoutForCheckPaperIn = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='EXCEPTION_TIMEOUT_FOR_DETECT_BLOOD_SAMPLE']"
		[Register ("EXCEPTION_TIMEOUT_FOR_DETECT_BLOOD_SAMPLE")]
		public const int ExceptionTimeoutForDetectBloodSample = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='TEST_PAPER_CALIBRATION_RESULT']"
		[Register ("TEST_PAPER_CALIBRATION_RESULT")]
		public const int TestPaperCalibrationResult = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/field[@name='TEST_PAPER_SET_VER_RESULT']"
		[Register ("TEST_PAPER_SET_VER_RESULT")]
		public const int TestPaperSetVerResult = (int) 7;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/TestPaperTask", typeof (TestPaperTask));

		internal static new IntPtr class_ref {
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

		protected TestPaperTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/constructor[@name='TestPaperTask' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe TestPaperTask (global::Android.Content.Context? p0, global::Com.Linktop.WhealthService.Util.IBleDev? p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/linktop/whealthService/util/IBleDev;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_isDoubleADC;
#pragma warning disable 0169
		static Delegate GetIsDoubleADCHandler ()
		{
			if (cb_isDoubleADC == null)
				cb_isDoubleADC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDoubleADC);
			return cb_isDoubleADC;
		}

		static bool n_IsDoubleADC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsDoubleADC;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDoubleADC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='isDoubleADC' and count(parameter)=0]"
			[Register ("isDoubleADC", "()Z", "GetIsDoubleADCHandler")]
			get {
				const string __id = "isDoubleADC.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isModuleExist;
#pragma warning disable 0169
		static Delegate GetIsModuleExistHandler ()
		{
			if (cb_isModuleExist == null)
				cb_isModuleExist = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsModuleExist);
			return cb_isModuleExist;
		}

		static bool n_IsModuleExist (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsModuleExist;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsModuleExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='isModuleExist' and count(parameter)=0]"
			[Register ("isModuleExist", "()Z", "GetIsModuleExistHandler")]
			get {
				const string __id = "isModuleExist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_a_I;
#pragma warning disable 0169
		static Delegate GetA_IHandler ()
		{
			if (cb_a_I == null)
				cb_a_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_A_I);
			return cb_a_I;
		}

		static void n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "GetA_IHandler")]
		public virtual unsafe void A (int p0)
		{
			const string __id = "a.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_checkModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_;
#pragma warning disable 0169
		static Delegate GetCheckModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_Handler ()
		{
			if (cb_checkModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_ == null)
				cb_checkModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CheckModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_);
			return cb_checkModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_;
		}

		static void n_CheckModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Infs.IOnSendCodeToDevCallback?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnSendCodeToDevCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckModuleExist (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='checkModuleExist' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnSendCodeToDevCallback']]"
		[Register ("checkModuleExist", "(Lcom/linktop/infs/OnSendCodeToDevCallback;)V", "GetCheckModuleExist_Lcom_linktop_infs_OnSendCodeToDevCallback_Handler")]
		public virtual unsafe void CheckModuleExist (global::Com.Linktop.Infs.IOnSendCodeToDevCallback? p0)
		{
			const string __id = "checkModuleExist.(Lcom/linktop/infs/OnSendCodeToDevCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_dealData_arrayB;
#pragma warning disable 0169
		static Delegate GetDealData_arrayBHandler ()
		{
			if (cb_dealData_arrayB == null)
				cb_dealData_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DealData_arrayB);
			return cb_dealData_arrayB;
		}

		static void n_DealData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DealData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("dealData", "([B)V", "GetDealData_arrayBHandler")]
		public override unsafe void DealData (byte[]? p0)
		{
			const string __id = "dealData.([B)V";
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

		static Delegate? cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_F);
			return cb_f;
		}

		static void n_F (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.F ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "GetFHandler")]
		public virtual unsafe void F ()
		{
			const string __id = "f.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='getBgValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getBgValue", "(D)I", "")]
		public static unsafe int GetBgValue (double p0)
		{
			const string __id = "getBgValue.(D)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='getBgValueForHMD' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("getBgValueForHMD", "([DD)[D", "")]
		public static unsafe double[]? GetBgValueForHMD (double[]? p0, double p1)
		{
			const string __id = "getBgValueForHMD.([DD)[D";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='getValue' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='double[]']]"
		[Register ("getValue", "(ILjava/lang/String;Ljava/lang/String;[D)D", "")]
		public static unsafe double GetValue (int p0, string? p1, string? p2, double[]? p3)
		{
			const string __id = "getValue.(ILjava/lang/String;Ljava/lang/String;[D)D";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate? cb_j;
#pragma warning disable 0169
		static Delegate GetJHandler ()
		{
			if (cb_j == null)
				cb_j = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_J);
			return cb_j;
		}

		static void n_J (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.J ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()V", "GetJHandler")]
		public virtual unsafe void J ()
		{
			const string __id = "j.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_setTestPaper_ILcom_linktop_constant_TestPaper_;
#pragma warning disable 0169
		static Delegate GetSetTestPaper_ILcom_linktop_constant_TestPaper_Handler ()
		{
			if (cb_setTestPaper_ILcom_linktop_constant_TestPaper_ == null)
				cb_setTestPaper_ILcom_linktop_constant_TestPaper_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetTestPaper_ILcom_linktop_constant_TestPaper_);
			return cb_setTestPaper_ILcom_linktop_constant_TestPaper_;
		}

		static void n_SetTestPaper_ILcom_linktop_constant_TestPaper_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.TestPaper> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTestPaper (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='setTestPaper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.linktop.constant.TestPaper']]"
		[Register ("setTestPaper", "(ILcom/linktop/constant/TestPaper;)V", "GetSetTestPaper_ILcom_linktop_constant_TestPaper_Handler")]
		public virtual unsafe void SetTestPaper ([global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})]
		int p0, global::Com.Linktop.Constant.TestPaper? p1)
		{
			const string __id = "setTestPaper.(ILcom/linktop/constant/TestPaper;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_setTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_;
#pragma warning disable 0169
		static Delegate GetSetTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_Handler ()
		{
			if (cb_setTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_ == null)
				cb_setTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_);
			return cb_setTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_;
		}

		static void n_SetTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Com.Linktop.Infs.IOnTestPaperResultListener?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Infs.IOnTestPaperResultListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTestPaperResultListener (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='setTestPaperResultListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.linktop.infs.OnTestPaperResultListener']]"
		[Register ("setTestPaperResultListener", "(ILcom/linktop/infs/OnTestPaperResultListener;)V", "GetSetTestPaperResultListener_ILcom_linktop_infs_OnTestPaperResultListener_Handler")]
		public virtual unsafe void SetTestPaperResultListener ([global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})]
		int p0, global::Com.Linktop.Infs.IOnTestPaperResultListener? p1)
		{
			const string __id = "setTestPaperResultListener.(ILcom/linktop/infs/OnTestPaperResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate? cb_start_I;
#pragma warning disable 0169
		static Delegate GetStart_IHandler ()
		{
			if (cb_start_I == null)
				cb_start_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Start_I);
			return cb_start_I;
		}

		static void n_Start_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Start (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='TestPaperTask']/method[@name='start' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("start", "(I)V", "GetStart_IHandler")]
		public virtual unsafe void Start ([global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})]
		int p0)
		{
			const string __id = "start.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}

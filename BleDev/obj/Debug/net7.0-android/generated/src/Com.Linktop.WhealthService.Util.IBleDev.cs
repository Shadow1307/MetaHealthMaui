using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']"
	[Register ("com/linktop/whealthService/util/IBleDev", "", "Com.Linktop.WhealthService.Util.IBleDevInvoker")]
	public partial interface IBleDev : IJavaObject, IJavaPeerable {
		global::Com.Linktop.WhealthService.Task.AckTask? AckTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getAckTask' and count(parameter)=0]"
			[Register ("getAckTask", "()Lcom/linktop/whealthService/task/AckTask;", "GetGetAckTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Task.BatteryTask? BatteryTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getBatteryTask' and count(parameter)=0]"
			[Register ("getBatteryTask", "()Lcom/linktop/whealthService/task/BatteryTask;", "GetGetBatteryTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Task.BpTask? BpTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getBpTask' and count(parameter)=0]"
			[Register ("getBpTask", "()Lcom/linktop/whealthService/task/BpTask;", "GetGetBpTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Task.BtTask? BtTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getBtTask' and count(parameter)=0]"
			[Register ("getBtTask", "()Lcom/linktop/whealthService/task/BtTask;", "GetGetBtTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Util.Communicate? Communicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getCommunicate' and count(parameter)=0]"
			[Register ("getCommunicate", "()Lcom/linktop/whealthService/util/Communicate;", "GetGetCommunicateHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Task.DeviceTask? DeviceTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getDeviceTask' and count(parameter)=0]"
			[Register ("getDeviceTask", "()Lcom/linktop/whealthService/task/DeviceTask;", "GetGetDeviceTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Task.EcgTask? EcgTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getEcgTask' and count(parameter)=0]"
			[Register ("getEcgTask", "()Lcom/linktop/whealthService/task/EcgTask;", "GetGetEcgTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		bool Measuring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='isMeasuring' and count(parameter)=0]"
			[Register ("isMeasuring", "()Z", "GetIsMeasuringHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='setMeasuring' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMeasuring", "(Z)V", "GetSetMeasuring_ZHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			set; 
		}

		global::Com.Linktop.WhealthService.Task.OxTask? OxTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getOxTask' and count(parameter)=0]"
			[Register ("getOxTask", "()Lcom/linktop/whealthService/task/OxTask;", "GetGetOxTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Task.SysErrorTask? SysErrorTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getSysErrorTask' and count(parameter)=0]"
			[Register ("getSysErrorTask", "()Lcom/linktop/whealthService/task/SysErrorTask;", "GetGetSysErrorTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.WhealthService.Task.TestPaperTask? TestPaperTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getTestPaperTask' and count(parameter)=0]"
			[Register ("getTestPaperTask", "()Lcom/linktop/whealthService/task/TestPaperTask;", "GetGetTestPaperTaskHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 
		}

		global::Com.Linktop.Constant.IUserProfile? UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/linktop/constant/IUserProfile;", "GetGetUserProfileHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='setUserProfile' and count(parameter)=1 and parameter[1][@type='com.linktop.constant.IUserProfile']]"
			[Register ("setUserProfile", "(Lcom/linktop/constant/IUserProfile;)V", "GetSetUserProfile_Lcom_linktop_constant_IUserProfile_Handler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
			set; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='clearCmdToSend' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("clearCmdToSend", "(BB)V", "GetClearCmdToSend_BBHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
		void ClearCmdToSend (sbyte p0, sbyte p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='cmdToSend' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("cmdToSend", "([B)V", "GetCmdToSend_arrayBHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
		void CmdToSend (byte[]? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='onInnerThrowableCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onInnerThrowableCallback", "(Ljava/lang/Throwable;)V", "GetOnInnerThrowableCallback_Ljava_lang_Throwable_Handler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
		void OnInnerThrowableCallback (global::Java.Lang.Throwable? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.util']/interface[@name='IBleDev']/method[@name='updateBleConnectIntervalFailed' and count(parameter)=0]"
		[Register ("updateBleConnectIntervalFailed", "()V", "GetUpdateBleConnectIntervalFailedHandler:Com.Linktop.WhealthService.Util.IBleDevInvoker, BleDev")]
		void UpdateBleConnectIntervalFailed ();

	}

	[global::Android.Runtime.Register ("com/linktop/whealthService/util/IBleDev", DoNotGenerateAcw=true)]
	internal partial class IBleDevInvoker : global::Java.Lang.Object, IBleDev {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/util/IBleDev", typeof (IBleDevInvoker));

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

		public static IBleDev? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleDev> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.whealthService.util.IBleDev'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleDevInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getAckTask;
#pragma warning disable 0169
		static Delegate GetGetAckTaskHandler ()
		{
			if (cb_getAckTask == null)
				cb_getAckTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAckTask);
			return cb_getAckTask;
		}

		static IntPtr n_GetAckTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AckTask);
		}
#pragma warning restore 0169

		IntPtr id_getAckTask;
		public unsafe global::Com.Linktop.WhealthService.Task.AckTask? AckTask {
			get {
				if (id_getAckTask == IntPtr.Zero)
					id_getAckTask = JNIEnv.GetMethodID (class_ref, "getAckTask", "()Lcom/linktop/whealthService/task/AckTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.AckTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAckTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getBatteryTask;
#pragma warning disable 0169
		static Delegate GetGetBatteryTaskHandler ()
		{
			if (cb_getBatteryTask == null)
				cb_getBatteryTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBatteryTask);
			return cb_getBatteryTask;
		}

		static IntPtr n_GetBatteryTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.BatteryTask);
		}
#pragma warning restore 0169

		IntPtr id_getBatteryTask;
		public unsafe global::Com.Linktop.WhealthService.Task.BatteryTask? BatteryTask {
			get {
				if (id_getBatteryTask == IntPtr.Zero)
					id_getBatteryTask = JNIEnv.GetMethodID (class_ref, "getBatteryTask", "()Lcom/linktop/whealthService/task/BatteryTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BatteryTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getBpTask;
#pragma warning disable 0169
		static Delegate GetGetBpTaskHandler ()
		{
			if (cb_getBpTask == null)
				cb_getBpTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBpTask);
			return cb_getBpTask;
		}

		static IntPtr n_GetBpTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.BpTask);
		}
#pragma warning restore 0169

		IntPtr id_getBpTask;
		public unsafe global::Com.Linktop.WhealthService.Task.BpTask? BpTask {
			get {
				if (id_getBpTask == IntPtr.Zero)
					id_getBpTask = JNIEnv.GetMethodID (class_ref, "getBpTask", "()Lcom/linktop/whealthService/task/BpTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BpTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBpTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getBtTask;
#pragma warning disable 0169
		static Delegate GetGetBtTaskHandler ()
		{
			if (cb_getBtTask == null)
				cb_getBtTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBtTask);
			return cb_getBtTask;
		}

		static IntPtr n_GetBtTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.BtTask);
		}
#pragma warning restore 0169

		IntPtr id_getBtTask;
		public unsafe global::Com.Linktop.WhealthService.Task.BtTask? BtTask {
			get {
				if (id_getBtTask == IntPtr.Zero)
					id_getBtTask = JNIEnv.GetMethodID (class_ref, "getBtTask", "()Lcom/linktop/whealthService/task/BtTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BtTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBtTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getCommunicate;
#pragma warning disable 0169
		static Delegate GetGetCommunicateHandler ()
		{
			if (cb_getCommunicate == null)
				cb_getCommunicate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommunicate);
			return cb_getCommunicate;
		}

		static IntPtr n_GetCommunicate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Communicate);
		}
#pragma warning restore 0169

		IntPtr id_getCommunicate;
		public unsafe global::Com.Linktop.WhealthService.Util.Communicate? Communicate {
			get {
				if (id_getCommunicate == IntPtr.Zero)
					id_getCommunicate = JNIEnv.GetMethodID (class_ref, "getCommunicate", "()Lcom/linktop/whealthService/util/Communicate;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCommunicate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getDeviceTask;
#pragma warning disable 0169
		static Delegate GetGetDeviceTaskHandler ()
		{
			if (cb_getDeviceTask == null)
				cb_getDeviceTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceTask);
			return cb_getDeviceTask;
		}

		static IntPtr n_GetDeviceTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.DeviceTask);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceTask;
		public unsafe global::Com.Linktop.WhealthService.Task.DeviceTask? DeviceTask {
			get {
				if (id_getDeviceTask == IntPtr.Zero)
					id_getDeviceTask = JNIEnv.GetMethodID (class_ref, "getDeviceTask", "()Lcom/linktop/whealthService/task/DeviceTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.DeviceTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getEcgTask;
#pragma warning disable 0169
		static Delegate GetGetEcgTaskHandler ()
		{
			if (cb_getEcgTask == null)
				cb_getEcgTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEcgTask);
			return cb_getEcgTask;
		}

		static IntPtr n_GetEcgTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.EcgTask);
		}
#pragma warning restore 0169

		IntPtr id_getEcgTask;
		public unsafe global::Com.Linktop.WhealthService.Task.EcgTask? EcgTask {
			get {
				if (id_getEcgTask == IntPtr.Zero)
					id_getEcgTask = JNIEnv.GetMethodID (class_ref, "getEcgTask", "()Lcom/linktop/whealthService/task/EcgTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.EcgTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEcgTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_isMeasuring;
#pragma warning disable 0169
		static Delegate GetIsMeasuringHandler ()
		{
			if (cb_isMeasuring == null)
				cb_isMeasuring = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMeasuring);
			return cb_isMeasuring;
		}

		static bool n_IsMeasuring (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Measuring;
		}
#pragma warning restore 0169

		static Delegate? cb_setMeasuring_Z;
#pragma warning disable 0169
		static Delegate GetSetMeasuring_ZHandler ()
		{
			if (cb_setMeasuring_Z == null)
				cb_setMeasuring_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMeasuring_Z);
			return cb_setMeasuring_Z;
		}

		static void n_SetMeasuring_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Measuring = p0;
		}
#pragma warning restore 0169

		IntPtr id_isMeasuring;
		IntPtr id_setMeasuring_Z;
		public unsafe bool Measuring {
			get {
				if (id_isMeasuring == IntPtr.Zero)
					id_isMeasuring = JNIEnv.GetMethodID (class_ref, "isMeasuring", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMeasuring);
			}
			set {
				if (id_setMeasuring_Z == IntPtr.Zero)
					id_setMeasuring_Z = JNIEnv.GetMethodID (class_ref, "setMeasuring", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMeasuring_Z, __args);
			}
		}

		static Delegate? cb_getOxTask;
#pragma warning disable 0169
		static Delegate GetGetOxTaskHandler ()
		{
			if (cb_getOxTask == null)
				cb_getOxTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOxTask);
			return cb_getOxTask;
		}

		static IntPtr n_GetOxTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OxTask);
		}
#pragma warning restore 0169

		IntPtr id_getOxTask;
		public unsafe global::Com.Linktop.WhealthService.Task.OxTask? OxTask {
			get {
				if (id_getOxTask == IntPtr.Zero)
					id_getOxTask = JNIEnv.GetMethodID (class_ref, "getOxTask", "()Lcom/linktop/whealthService/task/OxTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.OxTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOxTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSysErrorTask;
#pragma warning disable 0169
		static Delegate GetGetSysErrorTaskHandler ()
		{
			if (cb_getSysErrorTask == null)
				cb_getSysErrorTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSysErrorTask);
			return cb_getSysErrorTask;
		}

		static IntPtr n_GetSysErrorTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.SysErrorTask);
		}
#pragma warning restore 0169

		IntPtr id_getSysErrorTask;
		public unsafe global::Com.Linktop.WhealthService.Task.SysErrorTask? SysErrorTask {
			get {
				if (id_getSysErrorTask == IntPtr.Zero)
					id_getSysErrorTask = JNIEnv.GetMethodID (class_ref, "getSysErrorTask", "()Lcom/linktop/whealthService/task/SysErrorTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.SysErrorTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSysErrorTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getTestPaperTask;
#pragma warning disable 0169
		static Delegate GetGetTestPaperTaskHandler ()
		{
			if (cb_getTestPaperTask == null)
				cb_getTestPaperTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTestPaperTask);
			return cb_getTestPaperTask;
		}

		static IntPtr n_GetTestPaperTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.TestPaperTask);
		}
#pragma warning restore 0169

		IntPtr id_getTestPaperTask;
		public unsafe global::Com.Linktop.WhealthService.Task.TestPaperTask? TestPaperTask {
			get {
				if (id_getTestPaperTask == IntPtr.Zero)
					id_getTestPaperTask = JNIEnv.GetMethodID (class_ref, "getTestPaperTask", "()Lcom/linktop/whealthService/task/TestPaperTask;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTestPaperTask), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getUserProfile;
#pragma warning disable 0169
		static Delegate GetGetUserProfileHandler ()
		{
			if (cb_getUserProfile == null)
				cb_getUserProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserProfile);
			return cb_getUserProfile;
		}

		static IntPtr n_GetUserProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.UserProfile);
		}
#pragma warning restore 0169

		static Delegate? cb_setUserProfile_Lcom_linktop_constant_IUserProfile_;
#pragma warning disable 0169
		static Delegate GetSetUserProfile_Lcom_linktop_constant_IUserProfile_Handler ()
		{
			if (cb_setUserProfile_Lcom_linktop_constant_IUserProfile_ == null)
				cb_setUserProfile_Lcom_linktop_constant_IUserProfile_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUserProfile_Lcom_linktop_constant_IUserProfile_);
			return cb_setUserProfile_Lcom_linktop_constant_IUserProfile_;
		}

		static void n_SetUserProfile_Lcom_linktop_constant_IUserProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Constant.IUserProfile?)global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserProfile = p0;
		}
#pragma warning restore 0169

		IntPtr id_getUserProfile;
		IntPtr id_setUserProfile_Lcom_linktop_constant_IUserProfile_;
		public unsafe global::Com.Linktop.Constant.IUserProfile? UserProfile {
			get {
				if (id_getUserProfile == IntPtr.Zero)
					id_getUserProfile = JNIEnv.GetMethodID (class_ref, "getUserProfile", "()Lcom/linktop/constant/IUserProfile;");
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setUserProfile_Lcom_linktop_constant_IUserProfile_ == IntPtr.Zero)
					id_setUserProfile_Lcom_linktop_constant_IUserProfile_ = JNIEnv.GetMethodID (class_ref, "setUserProfile", "(Lcom/linktop/constant/IUserProfile;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserProfile_Lcom_linktop_constant_IUserProfile_, __args);
			}
		}

		static Delegate? cb_clearCmdToSend_BB;
#pragma warning disable 0169
		static Delegate GetClearCmdToSend_BBHandler ()
		{
			if (cb_clearCmdToSend_BB == null)
				cb_clearCmdToSend_BB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPBB_V) n_ClearCmdToSend_BB);
			return cb_clearCmdToSend_BB;
		}

		static void n_ClearCmdToSend_BB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ClearCmdToSend (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_clearCmdToSend_BB;
		public unsafe void ClearCmdToSend (sbyte p0, sbyte p1)
		{
			if (id_clearCmdToSend_BB == IntPtr.Zero)
				id_clearCmdToSend_BB = JNIEnv.GetMethodID (class_ref, "clearCmdToSend", "(BB)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearCmdToSend_BB, __args);
		}

		static Delegate? cb_cmdToSend_arrayB;
#pragma warning disable 0169
		static Delegate GetCmdToSend_arrayBHandler ()
		{
			if (cb_cmdToSend_arrayB == null)
				cb_cmdToSend_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CmdToSend_arrayB);
			return cb_cmdToSend_arrayB;
		}

		static void n_CmdToSend_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.CmdToSend (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_cmdToSend_arrayB;
		public unsafe void CmdToSend (byte[]? p0)
		{
			if (id_cmdToSend_arrayB == IntPtr.Zero)
				id_cmdToSend_arrayB = JNIEnv.GetMethodID (class_ref, "cmdToSend", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cmdToSend_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_onInnerThrowableCallback_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnInnerThrowableCallback_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onInnerThrowableCallback_Ljava_lang_Throwable_ == null)
				cb_onInnerThrowableCallback_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnInnerThrowableCallback_Ljava_lang_Throwable_);
			return cb_onInnerThrowableCallback_Ljava_lang_Throwable_;
		}

		static void n_OnInnerThrowableCallback_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInnerThrowableCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInnerThrowableCallback_Ljava_lang_Throwable_;
		public unsafe void OnInnerThrowableCallback (global::Java.Lang.Throwable? p0)
		{
			if (id_onInnerThrowableCallback_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onInnerThrowableCallback_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onInnerThrowableCallback", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInnerThrowableCallback_Ljava_lang_Throwable_, __args);
		}

		static Delegate? cb_updateBleConnectIntervalFailed;
#pragma warning disable 0169
		static Delegate GetUpdateBleConnectIntervalFailedHandler ()
		{
			if (cb_updateBleConnectIntervalFailed == null)
				cb_updateBleConnectIntervalFailed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UpdateBleConnectIntervalFailed);
			return cb_updateBleConnectIntervalFailed;
		}

		static void n_UpdateBleConnectIntervalFailed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.UpdateBleConnectIntervalFailed ();
		}
#pragma warning restore 0169

		IntPtr id_updateBleConnectIntervalFailed;
		public unsafe void UpdateBleConnectIntervalFailed ()
		{
			if (id_updateBleConnectIntervalFailed == IntPtr.Zero)
				id_updateBleConnectIntervalFailed = JNIEnv.GetMethodID (class_ref, "updateBleConnectIntervalFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateBleConnectIntervalFailed);
		}

	}
}

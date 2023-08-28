using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/BleDevManager", DoNotGenerateAcw=true)]
	public sealed partial class BleDevManager : global::Java.Lang.Object, global::Com.Linktop.WhealthService.Util.IBleDev {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager.CmdThread']"
		[global::Android.Runtime.Register ("com/linktop/whealthService/BleDevManager$CmdThread", DoNotGenerateAcw=true)]
		public abstract partial class CmdThread : global::Java.Lang.Thread {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/BleDevManager$CmdThread", typeof (CmdThread));

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

			protected CmdThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager.CmdThread']/constructor[@name='BleDevManager.CmdThread' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CmdThread () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate? cb_dealCmd_arrayB;
#pragma warning disable 0169
			static Delegate GetDealCmd_arrayBHandler ()
			{
				if (cb_dealCmd_arrayB == null)
					cb_dealCmd_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DealCmd_arrayB);
				return cb_dealCmd_arrayB;
			}

			static void n_DealCmd_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.BleDevManager.CmdThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.DealCmd (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager.CmdThread']/method[@name='dealCmd' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("dealCmd", "([B)V", "GetDealCmd_arrayBHandler")]
			protected abstract void DealCmd (byte[]? p0);

		}

		[global::Android.Runtime.Register ("com/linktop/whealthService/BleDevManager$CmdThread", DoNotGenerateAcw=true)]
		internal partial class CmdThreadInvoker : CmdThread {
			public CmdThreadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/BleDevManager$CmdThread", typeof (CmdThreadInvoker));

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager.CmdThread']/method[@name='dealCmd' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("dealCmd", "([B)V", "GetDealCmd_arrayBHandler")]
			protected override unsafe void DealCmd (byte[]? p0)
			{
				const string __id = "dealCmd.([B)V";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='BleDevManager.OnSDKThrowableCallback']"
		[Register ("com/linktop/whealthService/BleDevManager$OnSDKThrowableCallback", "", "Com.Linktop.WhealthService.BleDevManager/IOnSDKThrowableCallbackInvoker")]
		public partial interface IOnSDKThrowableCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/interface[@name='BleDevManager.OnSDKThrowableCallback']/method[@name='onSDKThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onSDKThrowable", "(Ljava/lang/Throwable;)V", "GetOnSDKThrowable_Ljava_lang_Throwable_Handler:Com.Linktop.WhealthService.BleDevManager/IOnSDKThrowableCallbackInvoker, BleDev")]
			void OnSDKThrowable (global::Java.Lang.Throwable? p0);

		}

		[global::Android.Runtime.Register ("com/linktop/whealthService/BleDevManager$OnSDKThrowableCallback", DoNotGenerateAcw=true)]
		internal partial class IOnSDKThrowableCallbackInvoker : global::Java.Lang.Object, IOnSDKThrowableCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/BleDevManager$OnSDKThrowableCallback", typeof (IOnSDKThrowableCallbackInvoker));

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

			public static IOnSDKThrowableCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSDKThrowableCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.whealthService.BleDevManager.OnSDKThrowableCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSDKThrowableCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onSDKThrowable_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnSDKThrowable_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onSDKThrowable_Ljava_lang_Throwable_ == null)
					cb_onSDKThrowable_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSDKThrowable_Ljava_lang_Throwable_);
				return cb_onSDKThrowable_Ljava_lang_Throwable_;
			}

			static void n_OnSDKThrowable_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.BleDevManager.IOnSDKThrowableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSDKThrowable (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSDKThrowable_Ljava_lang_Throwable_;
			public unsafe void OnSDKThrowable (global::Java.Lang.Throwable? p0)
			{
				if (id_onSDKThrowable_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onSDKThrowable_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onSDKThrowable", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSDKThrowable_Ljava_lang_Throwable_, __args);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/BleDevManager", typeof (BleDevManager));

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

		internal BleDevManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/constructor[@name='BleDevManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BleDevManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Com.Linktop.WhealthService.Task.AckTask? AckTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getAckTask' and count(parameter)=0]"
			[Register ("getAckTask", "()Lcom/linktop/whealthService/task/AckTask;", "")]
			get {
				const string __id = "getAckTask.()Lcom/linktop/whealthService/task/AckTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.AckTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.BatteryTask? BatteryTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getBatteryTask' and count(parameter)=0]"
			[Register ("getBatteryTask", "()Lcom/linktop/whealthService/task/BatteryTask;", "")]
			get {
				const string __id = "getBatteryTask.()Lcom/linktop/whealthService/task/BatteryTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BatteryTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.BpTask? BpTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getBpTask' and count(parameter)=0]"
			[Register ("getBpTask", "()Lcom/linktop/whealthService/task/BpTask;", "")]
			get {
				const string __id = "getBpTask.()Lcom/linktop/whealthService/task/BpTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BpTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.BtTask? BtTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getBtTask' and count(parameter)=0]"
			[Register ("getBtTask", "()Lcom/linktop/whealthService/task/BtTask;", "")]
			get {
				const string __id = "getBtTask.()Lcom/linktop/whealthService/task/BtTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.BtTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Util.Communicate? Communicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getCommunicate' and count(parameter)=0]"
			[Register ("getCommunicate", "()Lcom/linktop/whealthService/util/Communicate;", "")]
			get {
				const string __id = "getCommunicate.()Lcom/linktop/whealthService/util/Communicate;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.Communicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.DeviceTask? DeviceTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getDeviceTask' and count(parameter)=0]"
			[Register ("getDeviceTask", "()Lcom/linktop/whealthService/task/DeviceTask;", "")]
			get {
				const string __id = "getDeviceTask.()Lcom/linktop/whealthService/task/DeviceTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.DeviceTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.EcgTask? EcgTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getEcgTask' and count(parameter)=0]"
			[Register ("getEcgTask", "()Lcom/linktop/whealthService/task/EcgTask;", "")]
			get {
				const string __id = "getEcgTask.()Lcom/linktop/whealthService/task/EcgTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.EcgTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool Measuring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='isMeasuring' and count(parameter)=0]"
			[Register ("isMeasuring", "()Z", "")]
			get {
				const string __id = "isMeasuring.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='setMeasuring' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMeasuring", "(Z)V", "")]
			set {
				const string __id = "setMeasuring.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.OxTask? OxTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getOxTask' and count(parameter)=0]"
			[Register ("getOxTask", "()Lcom/linktop/whealthService/task/OxTask;", "")]
			get {
				const string __id = "getOxTask.()Lcom/linktop/whealthService/task/OxTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.OxTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.SysErrorTask? SysErrorTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getSysErrorTask' and count(parameter)=0]"
			[Register ("getSysErrorTask", "()Lcom/linktop/whealthService/task/SysErrorTask;", "")]
			get {
				const string __id = "getSysErrorTask.()Lcom/linktop/whealthService/task/SysErrorTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.SysErrorTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.WhealthService.Task.TestPaperTask? TestPaperTask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getTestPaperTask' and count(parameter)=0]"
			[Register ("getTestPaperTask", "()Lcom/linktop/whealthService/task/TestPaperTask;", "")]
			get {
				const string __id = "getTestPaperTask.()Lcom/linktop/whealthService/task/TestPaperTask;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.TestPaperTask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Linktop.Constant.IUserProfile? UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Lcom/linktop/constant/IUserProfile;", "")]
			get {
				const string __id = "getUserProfile.()Lcom/linktop/constant/IUserProfile;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.IUserProfile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='setUserProfile' and count(parameter)=1 and parameter[1][@type='com.linktop.constant.IUserProfile']]"
			[Register ("setUserProfile", "(Lcom/linktop/constant/IUserProfile;)V", "")]
			set {
				const string __id = "setUserProfile.(Lcom/linktop/constant/IUserProfile;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='clearCmdToSend' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("clearCmdToSend", "(BB)V", "")]
		public unsafe void ClearCmdToSend (sbyte p0, sbyte p1)
		{
			const string __id = "clearCmdToSend.(BB)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='cmdToSend' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("cmdToSend", "([B)V", "")]
		public unsafe void CmdToSend (byte[]? p0)
		{
			const string __id = "cmdToSend.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='initHC' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.linktop.whealthService.BleDevManager.OnSDKThrowableCallback']]"
		[Register ("initHC", "(Landroid/content/Context;Lcom/linktop/whealthService/BleDevManager$OnSDKThrowableCallback;)V", "")]
		public unsafe void InitHC (global::Android.Content.Context? p0, global::Com.Linktop.WhealthService.BleDevManager.IOnSDKThrowableCallback? p1)
		{
			const string __id = "initHC.(Landroid/content/Context;Lcom/linktop/whealthService/BleDevManager$OnSDKThrowableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='onInnerThrowableCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onInnerThrowableCallback", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void OnInnerThrowableCallback (global::Java.Lang.Throwable? p0)
		{
			const string __id = "onInnerThrowableCallback.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='setCmdThread' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.BleDevManager.CmdThread']]"
		[Register ("setCmdThread", "(Lcom/linktop/whealthService/BleDevManager$CmdThread;)V", "")]
		public unsafe void SetCmdThread (global::Com.Linktop.WhealthService.BleDevManager.CmdThread? p0)
		{
			const string __id = "setCmdThread.(Lcom/linktop/whealthService/BleDevManager$CmdThread;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='unInitHC' and count(parameter)=0]"
		[Register ("unInitHC", "()V", "")]
		public unsafe void UnInitHC ()
		{
			const string __id = "unInitHC.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService']/class[@name='BleDevManager']/method[@name='updateBleConnectIntervalFailed' and count(parameter)=0]"
		[Register ("updateBleConnectIntervalFailed", "()V", "")]
		public unsafe void UpdateBleConnectIntervalFailed ()
		{
			const string __id = "updateBleConnectIntervalFailed.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}

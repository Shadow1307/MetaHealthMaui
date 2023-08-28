using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='HcModuleTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/HcModuleTask", DoNotGenerateAcw=true)]
	public abstract partial class HcModuleTask : global::Com.Linktop.WhealthService.Task.ModuleTask {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/HcModuleTask", typeof (HcModuleTask));

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

		protected HcModuleTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getIBleDev;
#pragma warning disable 0169
		static Delegate GetGetIBleDevHandler ()
		{
			if (cb_getIBleDev == null)
				cb_getIBleDev = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIBleDev);
			return cb_getIBleDev;
		}

		static IntPtr n_GetIBleDev (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.HcModuleTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IBleDev);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Linktop.WhealthService.Util.IBleDev? IBleDev {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='HcModuleTask']/method[@name='getIBleDev' and count(parameter)=0]"
			[Register ("getIBleDev", "()Lcom/linktop/whealthService/util/IBleDev;", "GetGetIBleDevHandler")]
			get {
				const string __id = "getIBleDev.()Lcom/linktop/whealthService/util/IBleDev;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Util.IBleDev> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_start_arrayLcom_linktop_constant_Pair_;
#pragma warning disable 0169
		static Delegate GetStart_arrayLcom_linktop_constant_Pair_Handler ()
		{
			if (cb_start_arrayLcom_linktop_constant_Pair_ == null)
				cb_start_arrayLcom_linktop_constant_Pair_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Start_arrayLcom_linktop_constant_Pair_);
			return cb_start_arrayLcom_linktop_constant_Pair_;
		}

		static void n_Start_arrayLcom_linktop_constant_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.HcModuleTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Linktop.Constant.Pair[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Linktop.Constant.Pair));
			__this.Start (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='HcModuleTask']/method[@name='start' and count(parameter)=1 and parameter[1][@type='com.linktop.constant.Pair...']]"
		[Register ("start", "([Lcom/linktop/constant/Pair;)V", "GetStart_arrayLcom_linktop_constant_Pair_Handler")]
		public virtual unsafe void Start (params global::Com.Linktop.Constant.Pair[]? p0)
		{
			const string __id = "start.([Lcom/linktop/constant/Pair;)V";
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

		static Delegate? cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.HcModuleTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='HcModuleTask']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/linktop/whealthService/task/HcModuleTask", DoNotGenerateAcw=true)]
	internal partial class HcModuleTaskInvoker : HcModuleTask {
		public HcModuleTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/HcModuleTask", typeof (HcModuleTaskInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='ModuleTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("dealData", "([B)V", "GetDealData_arrayBHandler")]
		public override unsafe void DealData (byte[]? p0)
		{
			const string __id = "dealData.([B)V";
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
}

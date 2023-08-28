using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='DeviceTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/DeviceTask", DoNotGenerateAcw=true)]
	public sealed partial class DeviceTask : global::Com.Linktop.WhealthService.Task.ModuleTask {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/DeviceTask", typeof (DeviceTask));

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

		internal DeviceTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='DeviceTask']/constructor[@name='DeviceTask' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe DeviceTask (global::Com.Linktop.WhealthService.Util.IBleDev? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='DeviceTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("dealData", "([B)V", "")]
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='DeviceTask']/method[@name='getDeviceInfo' and count(parameter)=0]"
		[Register ("getDeviceInfo", "()V", "")]
		public unsafe void GetDeviceInfo ()
		{
			const string __id = "getDeviceInfo.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='DeviceTask']/method[@name='setOnDeviceInfoListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnDeviceInfoListener']]"
		[Register ("setOnDeviceInfoListener", "(Lcom/linktop/infs/OnDeviceInfoListener;)V", "")]
		public unsafe void SetOnDeviceInfoListener (global::Com.Linktop.Infs.IOnDeviceInfoListener? p0)
		{
			const string __id = "setOnDeviceInfoListener.(Lcom/linktop/infs/OnDeviceInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		#region "Event implementation for Com.Linktop.Infs.IOnDeviceInfoListener"

		public event EventHandler<global::Com.Linktop.Infs.DeviceInfoEventArgs> DeviceInfo {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDeviceInfoListener,
				__CreateIOnDeviceInfoListenerImplementor,
				SetOnDeviceInfoListener,
				__h => __h.OnDeviceInfoHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDeviceInfoListener,
				global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor.__IsEmpty,
				__v => SetOnDeviceInfoListener (null),
				__h => __h.OnDeviceInfoHandler -= value);
			}
		}

		public event EventHandler ReadDeviceInfoFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDeviceInfoListener,
				__CreateIOnDeviceInfoListenerImplementor,
				SetOnDeviceInfoListener,
				__h => __h.OnReadDeviceInfoFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnDeviceInfoListener, global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor>(
				ref weak_implementor_SetOnDeviceInfoListener,
				global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor.__IsEmpty,
				__v => SetOnDeviceInfoListener (null),
				__h => __h.OnReadDeviceInfoFailedHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnDeviceInfoListener;

		global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor __CreateIOnDeviceInfoListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnDeviceInfoListenerImplementor (this);
		}

		#endregion

	}
}

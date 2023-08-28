using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BtTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/BtTask", DoNotGenerateAcw=true)]
	public sealed partial class BtTask : global::Com.Linktop.WhealthService.Task.HcModuleTask {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/BtTask", typeof (BtTask));

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

		internal BtTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BtTask']/constructor[@name='BtTask' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe BtTask (global::Com.Linktop.WhealthService.Util.IBleDev? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BtTask']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)V", "")]
		public unsafe void A (byte[]? p0)
		{
			const string __id = "a.([B)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BtTask']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBtFactoryListener']]"
		[Register ("a", "(Lcom/linktop/infs/OnBtFactoryListener;)V", "")]
		public unsafe void A (global::Com.Linktop.Infs.IOnBtFactoryListener? p0)
		{
			const string __id = "a.(Lcom/linktop/infs/OnBtFactoryListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BtTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BtTask']/method[@name='setOnBtResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBtResultListener']]"
		[Register ("setOnBtResultListener", "(Lcom/linktop/infs/OnBtResultListener;)V", "")]
		public unsafe void SetOnBtResultListener (global::Com.Linktop.Infs.IOnBtResultListener? p0)
		{
			const string __id = "setOnBtResultListener.(Lcom/linktop/infs/OnBtResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		#region "Event implementation for Com.Linktop.Infs.IOnBtResultListener"

		public event EventHandler<global::Com.Linktop.Infs.BtResultEventArgs> BtResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBtResultListener, global::Com.Linktop.Infs.IOnBtResultListenerImplementor>(
				ref weak_implementor_SetOnBtResultListener,
				__CreateIOnBtResultListenerImplementor,
				SetOnBtResultListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBtResultListener, global::Com.Linktop.Infs.IOnBtResultListenerImplementor>(
				ref weak_implementor_SetOnBtResultListener,
				global::Com.Linktop.Infs.IOnBtResultListenerImplementor.__IsEmpty,
				__v => SetOnBtResultListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBtResultListener;

		global::Com.Linktop.Infs.IOnBtResultListenerImplementor __CreateIOnBtResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBtResultListenerImplementor (this);
		}

		#endregion

	}
}

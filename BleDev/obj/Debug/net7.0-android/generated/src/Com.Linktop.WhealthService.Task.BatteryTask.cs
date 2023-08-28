using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BatteryTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/BatteryTask", DoNotGenerateAcw=true)]
	public sealed partial class BatteryTask : global::Com.Linktop.WhealthService.Task.ModuleTask {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/BatteryTask", typeof (BatteryTask));

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

		internal BatteryTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BatteryTask']/constructor[@name='BatteryTask' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe BatteryTask (global::Com.Linktop.WhealthService.Util.IBleDev? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool IsCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BatteryTask']/method[@name='isCharging' and count(parameter)=0]"
			[Register ("isCharging", "()Z", "")]
			get {
				const string __id = "isCharging.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Power {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BatteryTask']/method[@name='getPower' and count(parameter)=0]"
			[Register ("getPower", "()I", "")]
			get {
				const string __id = "getPower.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BatteryTask']/method[@name='batteryQuery' and count(parameter)=0]"
		[Register ("batteryQuery", "()V", "")]
		public unsafe void BatteryQuery ()
		{
			const string __id = "batteryQuery.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BatteryTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BatteryTask']/method[@name='setBatteryStateListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBatteryListener']]"
		[Register ("setBatteryStateListener", "(Lcom/linktop/infs/OnBatteryListener;)V", "")]
		public unsafe void SetBatteryStateListener (global::Com.Linktop.Infs.IOnBatteryListener? p0)
		{
			const string __id = "setBatteryStateListener.(Lcom/linktop/infs/OnBatteryListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		#region "Event implementation for Com.Linktop.Infs.IOnBatteryListener"

		public event EventHandler BatteryCharging {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetBatteryStateListener,
				__CreateIOnBatteryListenerImplementor,
				SetBatteryStateListener,
				__h => __h.OnBatteryChargingHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetBatteryStateListener,
				global::Com.Linktop.Infs.IOnBatteryListenerImplementor.__IsEmpty,
				__v => SetBatteryStateListener (null),
				__h => __h.OnBatteryChargingHandler -= value);
			}
		}

		public event EventHandler BatteryFull {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetBatteryStateListener,
				__CreateIOnBatteryListenerImplementor,
				SetBatteryStateListener,
				__h => __h.OnBatteryFullHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetBatteryStateListener,
				global::Com.Linktop.Infs.IOnBatteryListenerImplementor.__IsEmpty,
				__v => SetBatteryStateListener (null),
				__h => __h.OnBatteryFullHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.BatteryQueryEventArgs> BatteryQueryEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetBatteryStateListener,
				__CreateIOnBatteryListenerImplementor,
				SetBatteryStateListener,
				__h => __h.OnBatteryQueryHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBatteryListener, global::Com.Linktop.Infs.IOnBatteryListenerImplementor>(
				ref weak_implementor_SetBatteryStateListener,
				global::Com.Linktop.Infs.IOnBatteryListenerImplementor.__IsEmpty,
				__v => SetBatteryStateListener (null),
				__h => __h.OnBatteryQueryHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetBatteryStateListener;

		global::Com.Linktop.Infs.IOnBatteryListenerImplementor __CreateIOnBatteryListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBatteryListenerImplementor (this);
		}

		#endregion

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/OxTask", DoNotGenerateAcw=true)]
	public sealed partial class OxTask : global::Com.Linktop.WhealthService.Task.HcModuleTask {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/OxTask", typeof (OxTask));

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

		internal OxTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']/constructor[@name='OxTask' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe OxTask (global::Android.Content.Context? p0, global::Com.Linktop.WhealthService.Util.IBleDev? p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public unsafe void A (bool p0)
		{
			const string __id = "a.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()I", "")]
		public unsafe int B ()
		{
			const string __id = "b.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public unsafe bool C ()
		{
			const string __id = "c.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']/method[@name='setOnHrvResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnHRVResultListener']]"
		[Register ("setOnHrvResultListener", "(Lcom/linktop/infs/OnHRVResultListener;)V", "")]
		public unsafe void SetOnHrvResultListener (global::Com.Linktop.Infs.IOnHRVResultListener? p0)
		{
			const string __id = "setOnHrvResultListener.(Lcom/linktop/infs/OnHRVResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='OxTask']/method[@name='setOnSpO2ResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnSpO2ResultListener']]"
		[Register ("setOnSpO2ResultListener", "(Lcom/linktop/infs/OnSpO2ResultListener;)V", "")]
		public unsafe void SetOnSpO2ResultListener (global::Com.Linktop.Infs.IOnSpO2ResultListener? p0)
		{
			const string __id = "setOnSpO2ResultListener.(Lcom/linktop/infs/OnSpO2ResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		#region "Event implementation for Com.Linktop.Infs.IOnHRVResultListener"

		public event EventHandler<global::Com.Linktop.Infs.HRVResultEventArgs> HRVResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				__CreateIOnHRVResultListenerImplementor,
				SetOnHrvResultListener,
				__h => __h.OnHRVResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				global::Com.Linktop.Infs.IOnHRVResultListenerImplementor.__IsEmpty,
				__v => SetOnHrvResultListener (null),
				__h => __h.OnHRVResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.SignalDataEventArgs> SignalData {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				__CreateIOnHRVResultListenerImplementor,
				SetOnHrvResultListener,
				__h => __h.OnSignalDataHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnHRVResultListener, global::Com.Linktop.Infs.IOnHRVResultListenerImplementor>(
				ref weak_implementor_SetOnHrvResultListener,
				global::Com.Linktop.Infs.IOnHRVResultListenerImplementor.__IsEmpty,
				__v => SetOnHrvResultListener (null),
				__h => __h.OnSignalDataHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnHrvResultListener;

		global::Com.Linktop.Infs.IOnHRVResultListenerImplementor __CreateIOnHRVResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnHRVResultListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnSpO2ResultListener"

		public event EventHandler SpO2End {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				__CreateIOnSpO2ResultListenerImplementor,
				SetOnSpO2ResultListener,
				__h => __h.OnSpO2EndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor.__IsEmpty,
				__v => SetOnSpO2ResultListener (null),
				__h => __h.OnSpO2EndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.SpO2ResultEventArgs> SpO2Result {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				__CreateIOnSpO2ResultListenerImplementor,
				SetOnSpO2ResultListener,
				__h => __h.OnSpO2ResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor.__IsEmpty,
				__v => SetOnSpO2ResultListener (null),
				__h => __h.OnSpO2ResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.SpO2WaveEventArgs> SpO2Wave {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				__CreateIOnSpO2ResultListenerImplementor,
				SetOnSpO2ResultListener,
				__h => __h.OnSpO2WaveHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnSpO2ResultListener, global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor>(
				ref weak_implementor_SetOnSpO2ResultListener,
				global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor.__IsEmpty,
				__v => SetOnSpO2ResultListener (null),
				__h => __h.OnSpO2WaveHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnSpO2ResultListener;

		global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor __CreateIOnSpO2ResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnSpO2ResultListenerImplementor (this);
		}

		#endregion

	}
}

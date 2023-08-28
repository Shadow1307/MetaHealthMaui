using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/BpTask", DoNotGenerateAcw=true)]
	public sealed partial class BpTask : global::Com.Linktop.WhealthService.Task.HcModuleTask {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/field[@name='C']"
		[Register ("C")]
		public int C {
			get {
				const string __id = "C.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "C.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/field[@name='H']"
		[Register ("H")]
		public static IList<int>? H {
			get {
				const string __id = "H.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "H.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/field[@name='I']"
		[Register ("I")]
		public static IList<int>? I {
			get {
				const string __id = "I.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "I.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/field[@name='J']"
		[Register ("J")]
		public static int J {
			get {
				const string __id = "J.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "J.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/BpTask", typeof (BpTask));

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

		internal BpTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/constructor[@name='BpTask' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe BpTask (global::Com.Linktop.WhealthService.Util.IBleDev? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool IsMeasureWrist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/method[@name='isMeasureWrist' and count(parameter)=0]"
			[Register ("isMeasureWrist", "()Z", "")]
			get {
				const string __id = "isMeasureWrist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/method[@name='a' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("a", "(ZI)V", "")]
		public unsafe void A (bool p0, int p1)
		{
			const string __id = "a.(ZI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/method[@name='setMeasurePosition' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMeasurePosition", "(Z)V", "")]
		public unsafe void SetMeasurePosition (bool p0)
		{
			const string __id = "setMeasurePosition.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/method[@name='setOnBpDataListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBpDataListener']]"
		[Register ("setOnBpDataListener", "(Lcom/linktop/infs/OnBpDataListener;)V", "")]
		public unsafe void SetOnBpDataListener (global::Com.Linktop.Infs.IOnBpDataListener? p0)
		{
			const string __id = "setOnBpDataListener.(Lcom/linktop/infs/OnBpDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='BpTask']/method[@name='setOnBpResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnBpResultListener']]"
		[Register ("setOnBpResultListener", "(Lcom/linktop/infs/OnBpResultListener;)V", "")]
		public unsafe void SetOnBpResultListener (global::Com.Linktop.Infs.IOnBpResultListener? p0)
		{
			const string __id = "setOnBpResultListener.(Lcom/linktop/infs/OnBpResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		#region "Event implementation for Com.Linktop.Infs.IOnBpDataListener"

		public event EventHandler<global::Com.Linktop.Infs.FIRAvgFilterEventArgs> FIRAvgFilter {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				__CreateIOnBpDataListenerImplementor,
				SetOnBpDataListener,
				__h => __h.OnFIRAvgFilterHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				global::Com.Linktop.Infs.IOnBpDataListenerImplementor.__IsEmpty,
				__v => SetOnBpDataListener (null),
				__h => __h.OnFIRAvgFilterHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.RcvPressureEventArgs> RcvPressure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				__CreateIOnBpDataListenerImplementor,
				SetOnBpDataListener,
				__h => __h.OnRcvPressureHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpDataListener, global::Com.Linktop.Infs.IOnBpDataListenerImplementor>(
				ref weak_implementor_SetOnBpDataListener,
				global::Com.Linktop.Infs.IOnBpDataListenerImplementor.__IsEmpty,
				__v => SetOnBpDataListener (null),
				__h => __h.OnRcvPressureHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBpDataListener;

		global::Com.Linktop.Infs.IOnBpDataListenerImplementor __CreateIOnBpDataListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBpDataListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Linktop.Infs.IOnBpResultListener"

		public event EventHandler<global::Com.Linktop.Infs.BpResultEventArgs> BpResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				__CreateIOnBpResultListenerImplementor,
				SetOnBpResultListener,
				__h => __h.OnBpResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				global::Com.Linktop.Infs.IOnBpResultListenerImplementor.__IsEmpty,
				__v => SetOnBpResultListener (null),
				__h => __h.OnBpResultHandler -= value);
			}
		}

		public event EventHandler BpResultError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				__CreateIOnBpResultListenerImplementor,
				SetOnBpResultListener,
				__h => __h.OnBpResultErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				global::Com.Linktop.Infs.IOnBpResultListenerImplementor.__IsEmpty,
				__v => SetOnBpResultListener (null),
				__h => __h.OnBpResultErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Linktop.Infs.LeakErrorEventArgs> LeakError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				__CreateIOnBpResultListenerImplementor,
				SetOnBpResultListener,
				__h => __h.OnLeakErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Linktop.Infs.IOnBpResultListener, global::Com.Linktop.Infs.IOnBpResultListenerImplementor>(
				ref weak_implementor_SetOnBpResultListener,
				global::Com.Linktop.Infs.IOnBpResultListenerImplementor.__IsEmpty,
				__v => SetOnBpResultListener (null),
				__h => __h.OnLeakErrorHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnBpResultListener;

		global::Com.Linktop.Infs.IOnBpResultListenerImplementor __CreateIOnBpResultListenerImplementor ()
		{
			return new global::Com.Linktop.Infs.IOnBpResultListenerImplementor (this);
		}

		#endregion

	}
}

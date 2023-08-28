using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/EcgTask", DoNotGenerateAcw=true)]
	public sealed partial class EcgTask : global::Com.Linktop.WhealthService.Task.HcModuleTask {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/field[@name='ecgStep']"
		[Register ("ecgStep")]
		public int EcgStep {
			get {
				const string __id = "ecgStep.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ecgStep.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/EcgTask", typeof (EcgTask));

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

		internal EcgTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/constructor[@name='EcgTask' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe EcgTask (global::Android.Content.Context? p0, global::Com.Linktop.WhealthService.Util.IBleDev? p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool ModuleExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='isModuleExist' and count(parameter)=0]"
			[Register ("isModuleExist", "()Z", "")]
			get {
				const string __id = "isModuleExist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='setModuleExist' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setModuleExist", "(Z)V", "")]
			set {
				const string __id = "setModuleExist.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='checkModuleExist' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnSendCodeToDevCallback']]"
		[Register ("checkModuleExist", "(Lcom/linktop/infs/OnSendCodeToDevCallback;)V", "")]
		public unsafe void CheckModuleExist (global::Com.Linktop.Infs.IOnSendCodeToDevCallback? p0)
		{
			const string __id = "checkModuleExist.(Lcom/linktop/infs/OnSendCodeToDevCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='dealEcgVal' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("dealEcgVal", "([B)V", "")]
		public unsafe void DealEcgVal (byte[]? p0)
		{
			const string __id = "dealEcgVal.([B)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='init' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("init", "([I)V", "")]
		public unsafe void Init (params int[]? p0)
		{
			const string __id = "init.([I)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='queryEcgTestEnable' and count(parameter)=0]"
		[Register ("queryEcgTestEnable", "()Z", "")]
		public unsafe bool QueryEcgTestEnable ()
		{
			const string __id = "queryEcgTestEnable.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='setOnEcgResultListener' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnEcgResultListener']]"
		[Register ("setOnEcgResultListener", "(Lcom/linktop/infs/OnEcgResultListener;)V", "")]
		public unsafe void SetOnEcgResultListener (global::Com.Linktop.Infs.IOnEcgResultListener? p0)
		{
			const string __id = "setOnEcgResultListener.(Lcom/linktop/infs/OnEcgResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='setParam' and count(parameter)=0]"
		[Register ("setParam", "()V", "")]
		public unsafe void SetParam ()
		{
			const string __id = "setParam.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='EcgTask']/method[@name='unInit' and count(parameter)=0]"
		[Register ("unInit", "()V", "")]
		public unsafe void UnInit ()
		{
			const string __id = "unInit.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmissionManager']"
	[global::Android.Runtime.Register ("com/linktop/MonitorDataTransmissionManager", DoNotGenerateAcw=true)]
	public sealed partial class MonitorDataTransmissionManager : global::Com.Linktop.MonitorDataTransmission {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/MonitorDataTransmissionManager", typeof (MonitorDataTransmissionManager));

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

		internal MonitorDataTransmissionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Linktop.MonitorDataTransmissionManager? Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmissionManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/linktop/MonitorDataTransmissionManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/linktop/MonitorDataTransmissionManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Linktop.MonitorDataTransmissionManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmissionManager']/method[@name='isDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isDebug", "(Z)V", "")]
		public static unsafe void IsDebug (bool p0)
		{
			const string __id = "isDebug.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmissionManager']/method[@name='setOnTestPaperResultListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.linktop.infs.OnTestPaperResultListener']]"
		[Register ("setOnTestPaperResultListener", "(ILcom/linktop/infs/OnTestPaperResultListener;)V", "")]
		public unsafe void SetOnTestPaperResultListener ([global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})]
		int p0, global::Com.Linktop.Infs.IOnTestPaperResultListener? p1)
		{
			const string __id = "setOnTestPaperResultListener.(ILcom/linktop/infs/OnTestPaperResultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmissionManager']/method[@name='startMeasure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.linktop.constant.Pair...']]"
		[Register ("startMeasure", "(I[Lcom/linktop/constant/Pair;)V", "")]
		public unsafe void StartMeasure ([global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})]
		int p0, params global::Com.Linktop.Constant.Pair[]? p1)
		{
			const string __id = "startMeasure.(I[Lcom/linktop/constant/Pair;)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop']/class[@name='MonitorDataTransmissionManager']/method[@name='stopMeasure' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stopMeasure", "(I)V", "")]
		public unsafe void StopMeasure ([global::Android.Runtime.IntDef (Type = "Com.Linktop.WhealthService.IMeasureType", Fields = new string [] {"Bp", "Bt", "Bg", "Spo2", "Ecg", "Hrv", "Ua", "Chol"})]
		int p0)
		{
			const string __id = "stopMeasure.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}

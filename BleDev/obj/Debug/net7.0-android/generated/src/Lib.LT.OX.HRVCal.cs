using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Lib.LT.OX {

	// Metadata.xml XPath class reference: path="/api/package[@name='lib.lt.ox']/class[@name='HRVCal']"
	[global::Android.Runtime.Register ("lib/lt/ox/HRVCal", DoNotGenerateAcw=true)]
	public partial class HRVCal : global::Java.Lang.Thread {

		// Metadata.xml XPath field reference: path="/api/package[@name='lib.lt.ox']/class[@name='HRVCal']/field[@name='v']"
		[Register ("v")]
		public static int V {
			get {
				const string __id = "v.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("lib/lt/ox/HRVCal", typeof (HRVCal));

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

		protected HRVCal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='lib.lt.ox']/class[@name='HRVCal']/constructor[@name='HRVCal' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.linktop.infs.OnHRVResultListener']]"
		[Register (".ctor", "(IILcom/linktop/infs/OnHRVResultListener;)V", "")]
		public unsafe HRVCal ([global::Android.Runtime.IntDef (Type = "Com.Linktop.Constant.Constants", Fields = new string [] {"SamplingRate125Hz", "SamplingRate250Hz", "SamplingRate500Hz"})]
		int p0, int p1, global::Com.Linktop.Infs.IOnHRVResultListener? p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILcom/linktop/infs/OnHRVResultListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate? cb_a_I;
#pragma warning disable 0169
		static Delegate GetA_IHandler ()
		{
			if (cb_a_I == null)
				cb_a_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_A_I);
			return cb_a_I;
		}

		static void n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Lib.LT.OX.HRVCal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='lib.lt.ox']/class[@name='HRVCal']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "GetA_IHandler")]
		public virtual unsafe void A (int p0)
		{
			const string __id = "a.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}

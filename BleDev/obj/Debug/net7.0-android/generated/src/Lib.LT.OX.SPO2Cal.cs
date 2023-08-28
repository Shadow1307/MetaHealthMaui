using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Lib.LT.OX {

	// Metadata.xml XPath class reference: path="/api/package[@name='lib.lt.ox']/class[@name='SPO2Cal']"
	[global::Android.Runtime.Register ("lib/lt/ox/SPO2Cal", DoNotGenerateAcw=true)]
	public partial class SPO2Cal : global::Java.Lang.Thread {
		static readonly JniPeerMembers _members = new XAPeerMembers ("lib/lt/ox/SPO2Cal", typeof (SPO2Cal));

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

		protected SPO2Cal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='lib.lt.ox']/class[@name='SPO2Cal']/constructor[@name='SPO2Cal' and count(parameter)=1 and parameter[1][@type='com.linktop.infs.OnSpO2ResultListener']]"
		[Register (".ctor", "(Lcom/linktop/infs/OnSpO2ResultListener;)V", "")]
		public unsafe SPO2Cal (global::Com.Linktop.Infs.IOnSpO2ResultListener? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/linktop/infs/OnSpO2ResultListener;)V";

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

		static Delegate? cb_a_arrayI;
#pragma warning disable 0169
		static Delegate GetA_arrayIHandler ()
		{
			if (cb_a_arrayI == null)
				cb_a_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_arrayI);
			return cb_a_arrayI;
		}

		static void n_A_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Lib.LT.OX.SPO2Cal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (int[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.A (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='lib.lt.ox']/class[@name='SPO2Cal']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("a", "([I)V", "GetA_arrayIHandler")]
		public virtual unsafe void A (params int[]? p0)
		{
			const string __id = "a.([I)V";
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

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Constant {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.constant']/class[@name='Pair']"
	[global::Android.Runtime.Register ("com/linktop/constant/Pair", DoNotGenerateAcw=true)]
	public partial class Pair : global::Android.Util.Pair {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/constant/Pair", typeof (Pair));

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

		protected Pair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='Pair']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("create", "(Ljava/lang/Integer;Ljava/lang/Object;)Lcom/linktop/constant/Pair;", "")]
		public static unsafe global::Com.Linktop.Constant.Pair? Create (global::Java.Lang.Integer? p0, global::Java.Lang.Object? p1)
		{
			const string __id = "create.(Ljava/lang/Integer;Ljava/lang/Object;)Lcom/linktop/constant/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Linktop.Constant.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Lib.LT.OX {

	// Metadata.xml XPath class reference: path="/api/package[@name='lib.lt.ox']/class[@name='PPGSgn']"
	[global::Android.Runtime.Register ("lib/lt/ox/PPGSgn", DoNotGenerateAcw=true)]
	public partial class PPGSgn : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='lib.lt.ox']/class[@name='PPGSgn']/field[@name='a']"
		[Register ("a")]
		public long A {
			get {
				const string __id = "a.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "a.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='lib.lt.ox']/class[@name='PPGSgn']/field[@name='b']"
		[Register ("b")]
		public double B {
			get {
				const string __id = "b.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "b.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='lib.lt.ox']/class[@name='PPGSgn']/field[@name='c']"
		[Register ("c")]
		public double C {
			get {
				const string __id = "c.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "c.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='lib.lt.ox']/class[@name='PPGSgn']/field[@name='d']"
		[Register ("d")]
		public int D {
			get {
				const string __id = "d.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "d.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("lib/lt/ox/PPGSgn", typeof (PPGSgn));

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

		protected PPGSgn (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='lib.lt.ox']/class[@name='PPGSgn']/constructor[@name='PPGSgn' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='int']]"
		[Register (".ctor", "(JDDI)V", "")]
		public unsafe PPGSgn (long p0, double p1, double p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JDDI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='lib.lt.ox']/class[@name='PPGSgn']/constructor[@name='PPGSgn' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register (".ctor", "(JDI)V", "")]
		public unsafe PPGSgn (long p0, double p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JDI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}

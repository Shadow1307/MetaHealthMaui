using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSignalQuality']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoSignalQuality", DoNotGenerateAcw=true)]
	public sealed partial class NskAlgoSignalQuality : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSignalQuality']/field[@name='NSK_ALGO_SQ_GOOD']"
		[Register ("NSK_ALGO_SQ_GOOD")]
		public const int NskAlgoSqGood = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSignalQuality']/field[@name='NSK_ALGO_SQ_MEDIUM']"
		[Register ("NSK_ALGO_SQ_MEDIUM")]
		public const int NskAlgoSqMedium = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSignalQuality']/field[@name='NSK_ALGO_SQ_NOT_DETECTED']"
		[Register ("NSK_ALGO_SQ_NOT_DETECTED")]
		public const int NskAlgoSqNotDetected = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSignalQuality']/field[@name='NSK_ALGO_SQ_POOR']"
		[Register ("NSK_ALGO_SQ_POOR")]
		public const int NskAlgoSqPoor = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoSignalQuality", typeof (NskAlgoSignalQuality));

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

		internal NskAlgoSignalQuality (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSignalQuality']/constructor[@name='NskAlgoSignalQuality' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NskAlgoSignalQuality (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSignalQuality']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoState", DoNotGenerateAcw=true)]
	public sealed partial class NskAlgoState : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_BASELINE_EXPIRED']"
		[Register ("NSK_ALGO_REASON_BASELINE_EXPIRED")]
		public const int NskAlgoReasonBaselineExpired = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_BY_USER']"
		[Register ("NSK_ALGO_REASON_BY_USER")]
		public const int NskAlgoReasonByUser = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_CB_CHANGED']"
		[Register ("NSK_ALGO_REASON_CB_CHANGED")]
		public const int NskAlgoReasonCbChanged = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_CONFIG_CHANGED']"
		[Register ("NSK_ALGO_REASON_CONFIG_CHANGED")]
		public const int NskAlgoReasonConfigChanged = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_MASK']"
		[Register ("NSK_ALGO_REASON_MASK")]
		public const int NskAlgoReasonMask = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_NO_BASELINE']"
		[Register ("NSK_ALGO_REASON_NO_BASELINE")]
		public const int NskAlgoReasonNoBaseline = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_SIGNAL_QUALITY']"
		[Register ("NSK_ALGO_REASON_SIGNAL_QUALITY")]
		public const int NskAlgoReasonSignalQuality = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_REASON_USER_PROFILE_CHANGED']"
		[Register ("NSK_ALGO_REASON_USER_PROFILE_CHANGED")]
		public const int NskAlgoReasonUserProfileChanged = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_STATE_COLLECTING_BASELINE_DATA']"
		[Register ("NSK_ALGO_STATE_COLLECTING_BASELINE_DATA")]
		public const int NskAlgoStateCollectingBaselineData = (int) 768;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_STATE_INITED']"
		[Register ("NSK_ALGO_STATE_INITED")]
		public const int NskAlgoStateInited = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_STATE_MASK']"
		[Register ("NSK_ALGO_STATE_MASK")]
		public const int NskAlgoStateMask = (int) 65280;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_STATE_PAUSE']"
		[Register ("NSK_ALGO_STATE_PAUSE")]
		public const int NskAlgoStatePause = (int) 1280;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_STATE_RUNNING']"
		[Register ("NSK_ALGO_STATE_RUNNING")]
		public const int NskAlgoStateRunning = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_STATE_STOP']"
		[Register ("NSK_ALGO_STATE_STOP")]
		public const int NskAlgoStateStop = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/field[@name='NSK_ALGO_STATE_UNINTIED']"
		[Register ("NSK_ALGO_STATE_UNINTIED")]
		public const int NskAlgoStateUnintied = (int) 1536;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoState", typeof (NskAlgoState));

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

		internal NskAlgoState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/constructor[@name='NskAlgoState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NskAlgoState (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoState']/method[@name='getValue' and count(parameter)=0]"
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

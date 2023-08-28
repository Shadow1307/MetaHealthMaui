using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoECGValueType", DoNotGenerateAcw=true)]
	public sealed partial class NskAlgoECGValueType : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_TYPE_UNKNOWN']"
		[Register ("NSK_ALGO_ECG_TYPE_UNKNOWN")]
		public const int NskAlgoEcgTypeUnknown = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_AFIB']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_AFIB")]
		public const int NskAlgoEcgValueTypeAfib = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_BASELINE_UPDATED']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_BASELINE_UPDATED")]
		public const int NskAlgoEcgValueTypeBaselineUpdated = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_HEARTAGE']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_HEARTAGE")]
		public const int NskAlgoEcgValueTypeHeartage = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_HEARTBEAT']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_HEARTBEAT")]
		public const int NskAlgoEcgValueTypeHeartbeat = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_HR']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_HR")]
		public const int NskAlgoEcgValueTypeHr = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_HRV']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_HRV")]
		public const int NskAlgoEcgValueTypeHrv = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_HRV_FREQDOMAIN']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_HRV_FREQDOMAIN")]
		public const int NskAlgoEcgValueTypeHrvFreqdomain = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_HRV_TIMEDOMAIN']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_HRV_TIMEDOMAIN")]
		public const int NskAlgoEcgValueTypeHrvTimedomain = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_MOOD']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_MOOD")]
		public const int NskAlgoEcgValueTypeMood = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_R2R']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_R2R")]
		public const int NskAlgoEcgValueTypeR2r = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_RDETECTED']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_RDETECTED")]
		public const int NskAlgoEcgValueTypeRdetected = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_RESPIRATORY_RATE']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_RESPIRATORY_RATE")]
		public const int NskAlgoEcgValueTypeRespiratoryRate = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_ROBUST_HR']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_ROBUST_HR")]
		public const int NskAlgoEcgValueTypeRobustHr = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_SMOOTH']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_SMOOTH")]
		public const int NskAlgoEcgValueTypeSmooth = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/field[@name='NSK_ALGO_ECG_VALUE_TYPE_STRESS']"
		[Register ("NSK_ALGO_ECG_VALUE_TYPE_STRESS")]
		public const int NskAlgoEcgValueTypeStress = (int) 10;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoECGValueType", typeof (NskAlgoECGValueType));

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

		internal NskAlgoECGValueType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/constructor[@name='NskAlgoECGValueType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NskAlgoECGValueType (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGValueType']/method[@name='getValue' and count(parameter)=0]"
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

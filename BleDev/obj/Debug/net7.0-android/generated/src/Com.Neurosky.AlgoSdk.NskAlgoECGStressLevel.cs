using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoECGStressLevel", DoNotGenerateAcw=true)]
	public sealed partial class NskAlgoECGStressLevel : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/field[@name='NSK_ALGO_ECG_STRESS_LEVEL_HIGH']"
		[Register ("NSK_ALGO_ECG_STRESS_LEVEL_HIGH")]
		public const int NskAlgoEcgStressLevelHigh = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/field[@name='NSK_ALGO_ECG_STRESS_LEVEL_INVALID']"
		[Register ("NSK_ALGO_ECG_STRESS_LEVEL_INVALID")]
		public const int NskAlgoEcgStressLevelInvalid = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/field[@name='NSK_ALGO_ECG_STRESS_LEVEL_LOW']"
		[Register ("NSK_ALGO_ECG_STRESS_LEVEL_LOW")]
		public const int NskAlgoEcgStressLevelLow = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/field[@name='NSK_ALGO_ECG_STRESS_LEVEL_MEDIUM']"
		[Register ("NSK_ALGO_ECG_STRESS_LEVEL_MEDIUM")]
		public const int NskAlgoEcgStressLevelMedium = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/field[@name='NSK_ALGO_ECG_STRESS_LEVEL_NO']"
		[Register ("NSK_ALGO_ECG_STRESS_LEVEL_NO")]
		public const int NskAlgoEcgStressLevelNo = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/field[@name='NSK_ALGO_ECG_STRESS_LEVEL_VERYHIGH']"
		[Register ("NSK_ALGO_ECG_STRESS_LEVEL_VERYHIGH")]
		public const int NskAlgoEcgStressLevelVeryhigh = (int) 5;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoECGStressLevel", typeof (NskAlgoECGStressLevel));

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

		internal NskAlgoECGStressLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/constructor[@name='NskAlgoECGStressLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NskAlgoECGStressLevel (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoECGStressLevel']/method[@name='getValue' and count(parameter)=0]"
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

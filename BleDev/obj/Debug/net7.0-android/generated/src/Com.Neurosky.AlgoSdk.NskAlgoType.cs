using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoType", DoNotGenerateAcw=true)]
	public sealed partial class NskAlgoType : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_AFIB']"
		[Register ("NSK_ALGO_TYPE_ECG_AFIB")]
		public const int NskAlgoTypeEcgAfib = (int) 8388608;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_HEARTAGE']"
		[Register ("NSK_ALGO_TYPE_ECG_HEARTAGE")]
		public const int NskAlgoTypeEcgHeartage = (int) 524288;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_HEARTRATE']"
		[Register ("NSK_ALGO_TYPE_ECG_HEARTRATE")]
		public const int NskAlgoTypeEcgHeartrate = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_HRV']"
		[Register ("NSK_ALGO_TYPE_ECG_HRV")]
		public const int NskAlgoTypeEcgHrv = (int) 1048576;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_HRVFD']"
		[Register ("NSK_ALGO_TYPE_ECG_HRVFD")]
		public const int NskAlgoTypeEcgHrvfd = (int) 33554432;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_HRVTD']"
		[Register ("NSK_ALGO_TYPE_ECG_HRVTD")]
		public const int NskAlgoTypeEcgHrvtd = (int) 16777216;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_MOOD']"
		[Register ("NSK_ALGO_TYPE_ECG_MOOD")]
		public const int NskAlgoTypeEcgMood = (int) 262144;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_RESPIRATORY']"
		[Register ("NSK_ALGO_TYPE_ECG_RESPIRATORY")]
		public const int NskAlgoTypeEcgRespiratory = (int) 4194304;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_SMOOTH']"
		[Register ("NSK_ALGO_TYPE_ECG_SMOOTH")]
		public const int NskAlgoTypeEcgSmooth = (int) 2097152;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/field[@name='NSK_ALGO_TYPE_ECG_STRESS']"
		[Register ("NSK_ALGO_TYPE_ECG_STRESS")]
		public const int NskAlgoTypeEcgStress = (int) 131072;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoType", typeof (NskAlgoType));

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

		internal NskAlgoType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/constructor[@name='NskAlgoType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NskAlgoType (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoType']/method[@name='getValue' and count(parameter)=0]"
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

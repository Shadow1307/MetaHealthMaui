using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoDataType']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoDataType", DoNotGenerateAcw=true)]
	public sealed partial class NskAlgoDataType : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoDataType']/field[@name='NSK_ALGO_DATA_TYPE_BULK_ECG']"
		[Register ("NSK_ALGO_DATA_TYPE_BULK_ECG")]
		public const int NskAlgoDataTypeBulkEcg = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoDataType']/field[@name='NSK_ALGO_DATA_TYPE_ECG']"
		[Register ("NSK_ALGO_DATA_TYPE_ECG")]
		public const int NskAlgoDataTypeEcg = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoDataType']/field[@name='NSK_ALGO_DATA_TYPE_ECG_PQ']"
		[Register ("NSK_ALGO_DATA_TYPE_ECG_PQ")]
		public const int NskAlgoDataTypeEcgPq = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoDataType']/field[@name='NSK_ALGO_DATA_TYPE_MAX']"
		[Register ("NSK_ALGO_DATA_TYPE_MAX")]
		public const int NskAlgoDataTypeMax = (int) 9;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoDataType", typeof (NskAlgoDataType));

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

		internal NskAlgoDataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoDataType']/constructor[@name='NskAlgoDataType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NskAlgoDataType (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoDataType']/method[@name='getValue' and count(parameter)=0]"
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

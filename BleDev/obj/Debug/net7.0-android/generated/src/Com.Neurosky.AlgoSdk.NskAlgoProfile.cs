using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoProfile", DoNotGenerateAcw=true)]
	public partial class NskAlgoProfile : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']/field[@name='dob']"
		[Register ("dob")]
		public global::Java.Util.Date? Dob {
			get {
				const string __id = "dob.Ljava/util/Date;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dob.Ljava/util/Date;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']/field[@name='gender']"
		[Register ("gender")]
		public bool Gender {
			get {
				const string __id = "gender.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "gender.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']/field[@name='name']"
		[Register ("name")]
		public string? Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']/field[@name='userId']"
		[Register ("userId")]
		public int UserId {
			get {
				const string __id = "userId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "userId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']/field[@name='weight']"
		[Register ("weight")]
		public int Weight {
			get {
				const string __id = "weight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "weight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoProfile", typeof (NskAlgoProfile));

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

		protected NskAlgoProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoProfile']/constructor[@name='NskAlgoProfile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NskAlgoProfile () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}

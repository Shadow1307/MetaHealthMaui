using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.Constant {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']"
	[global::Android.Runtime.Register ("com/linktop/constant/UUIDConfig", DoNotGenerateAcw=true)]
	public sealed partial class UUIDConfig : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='CCC']"
		[Register ("CCC")]
		public const string Ccc = (string) "00002902-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='DEV_INFO_FIRMWARE_REV_UUID']"
		[Register ("DEV_INFO_FIRMWARE_REV_UUID")]
		public const string DevInfoFirmwareRevUuid = (string) "00002A26-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='DEV_INFO_HARDWARE_PCB_UUID']"
		[Register ("DEV_INFO_HARDWARE_PCB_UUID")]
		public const string DevInfoHardwarePcbUuid = (string) "00002A27-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='DEV_INFO_SER_UUID']"
		[Register ("DEV_INFO_SER_UUID")]
		public const string DevInfoSerUuid = (string) "0000180A-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='DEV_INFO_SOFTWARE_REV_UUID']"
		[Register ("DEV_INFO_SOFTWARE_REV_UUID")]
		public const string DevInfoSoftwareRevUuid = (string) "00002A28-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='HEART_RATE_MEASUREMENT_CHARA']"
		[Register ("HEART_RATE_MEASUREMENT_CHARA")]
		public const string HeartRateMeasurementChara = (string) "0000fff4-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='HEART_RATE_WRITE_CHARA']"
		[Register ("HEART_RATE_WRITE_CHARA")]
		public const string HeartRateWriteChara = (string) "0000fff1-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='HRP_SERVICE']"
		[Register ("HRP_SERVICE")]
		public const string HrpService = (string) "0000ff27-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='THERM_CONNECT_CONFIRM']"
		[Register ("THERM_CONNECT_CONFIRM")]
		public const string ThermConnectConfirm = (string) "0000fff5-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='THERM_QR_CODE']"
		[Register ("THERM_QR_CODE")]
		public const string ThermQrCode = (string) "00002A24-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='THERM_QR_CODE_SERVICE']"
		[Register ("THERM_QR_CODE_SERVICE")]
		public const string ThermQrCodeService = (string) "0000180A-0000-1000-8000-00805f9b34fb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/field[@name='THERM_SERVICE']"
		[Register ("THERM_SERVICE")]
		public const string ThermService = (string) "0000fff0-0000-1000-8000-00805f9b34fb";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/constant/UUIDConfig", typeof (UUIDConfig));

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

		internal UUIDConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/constructor[@name='UUIDConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UUIDConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/method[@name='getParcelUuid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParcelUuid", "(Ljava/lang/String;)Landroid/os/ParcelUuid;", "")]
		public static unsafe global::Android.OS.ParcelUuid? GetParcelUuid (string? p0)
		{
			const string __id = "getParcelUuid.(Ljava/lang/String;)Landroid/os/ParcelUuid;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.constant']/class[@name='UUIDConfig']/method[@name='getUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUUID", "(Ljava/lang/String;)Ljava/util/UUID;", "")]
		public static unsafe global::Java.Util.UUID? GetUUID (string? p0)
		{
			const string __id = "getUUID.(Ljava/lang/String;)Ljava/util/UUID;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
